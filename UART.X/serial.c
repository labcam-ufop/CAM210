/* ########################################################################

   PICsim - PIC simulator http://sourceforge.net/projects/picsim/

   ########################################################################

   Copyright (c) : 2015  Luis Claudio Gambôa Lopes

   This program is free software; you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation; either version 2, or (at your option)
   any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program; if not, write to the Free Software
   Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

   For e-mail suggestions :  lcgamboa@yahoo.com
   ######################################################################## */

#include <xc.h>
#include"serial.h"
#define _XTAL_FREQ 8000000

void serial_init(void)
{
    BAUDCONbits.BRG16 = 0;
    SPBRG = 51; // baud rate de 9600  - FOSC=8MHz   
        
	//Configuracao da serial
    TXSTAbits.TX9=0;    //transmissao em 8 bits
    TXSTAbits.TXEN=1;  //habilita transmissao
    TXSTAbits.SYNC=0;  //modo assincrono
    TXSTAbits.BRGH=1;  //high baud rate
    RCSTAbits.SPEN=1;  //habilita porta serial - rx
    RCSTAbits.RX9=0;   //recepcao em 8 bits
    RCSTAbits.CREN=1;  //recepcao continua


}

void serial_tx(unsigned char val)
{
  TXREG=val;
  while(!TXSTAbits.TRMT);
}

void serial_tx_str(const char* val)
{
  unsigned char i=0;
  
  while(val[i])
  {
    serial_tx(val[i]);
    i++; 
  }
}

unsigned char serial_rx(unsigned int timeout)
{
  unsigned int to=0;

  if(RCSTAbits.FERR || RCSTAbits.OERR)//trata erro
  {
      RCSTAbits.CREN=0;
      RCSTAbits.CREN=1;
  }

  while(((to < timeout)||(!timeout))&&(!PIR1bits.RCIF))
  {
    __delaywdt_ms(20);
    to+=20; 
  }
  if(PIR1bits.RCIF)
    return RCREG;
  else
    return 0xA5;
}
char*  serial_rx_str(char * buff, unsigned int size, unsigned int timeout)
{
  unsigned int to=0;
  unsigned int i;
  if(RCSTAbits.FERR || RCSTAbits.OERR)//trata erro
  {
      RCSTAbits.CREN=0;
      RCSTAbits.CREN=1;
  }

  size--;
  for(i=0 ; i< size; )
  {
    while(((to < timeout)||(!timeout))&&(!PIR1bits.RCIF))
    {
      __delaywdt_ms(1);
      to+=1; 
    }
    if(PIR1bits.RCIF)
    {
      do
      {
        buff[i]= RCREG;
        i++;
      }while((PIR1bits.RCIF)&&(i < size));
    }
    else
    {
      buff[i]= 0;//terminador NULL 
      return buff;
    }
  }
  buff[i]= 0;//final buffer 
  return buff;
}


char*  serial_rx_str_until(char * buff, unsigned int size, unsigned char term)
{

  unsigned int i;
  if(RCSTAbits.FERR || RCSTAbits.OERR)//trata erro
  {
      RCSTAbits.CREN=0;
      RCSTAbits.CREN=1;
  }

  size--;
  i=0;
  do
  {
    while(!PIR1bits.RCIF)
    {
      __delaywdt_ms(1);
    }
    do
    {
      buff[i]= RCREG;
      i++;
    }while((PIR1bits.RCIF)&&(i < size)&&(buff[i-1]!=term));
    
  }while((i < size)&&(buff[i-1]!=term));
  
  
  buff[i]= 0;//final buffer 
  return buff;
}
