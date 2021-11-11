/******************************************************************************/
/* Files to Include                                                           */
/******************************************************************************/

#if defined(__XC)
    #include <xc.h>        /* XC8 General Include File */
#elif defined(HI_TECH_C)
    #include <htc.h>       /* HiTech General Include File */
#elif defined(__18CXX)
    #include <p18cxxx.h>   /* C18 General Include File */
#endif

#if defined(__XC) || defined(HI_TECH_C)

#include <stdint.h>        /* For uint8_t definition */
#include <stdbool.h>       /* For true/false definition */

#endif

#define _XTAL_FREQ 10000000
//#include "configbits.h"
#include "system.h"        /* System funct/params, like osc/peripheral config */
#include "user.h"          /* User funct/params, such as InitApp */
#include "modbus.h"
#include <usart.h>
#include "flexlcd.h"
#include <stdio.h>


char str[16];

/******************************************************************************/
/* Main Program                                                               */
/******************************************************************************/

void main(void)
{
    //teste
    holdingReg[0] = 10;
    // Input or Output
    TRISA = 0xFF;
    TRISB = 0b00000000; 
    TRISC = 0b10000001;
    TRISD = 0b00000000; 
    TRISE = 0b00000000;
    // Clear ports
    PORTA = 0; 
    LATA = 0;
    PORTB = 0; 
    LATB = 0;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0; 
    LATD = 0;
    PORTE = 0; 
    LATE = 0;  
    
  OpnUSART();
  ConfigInterrupts();

  Lcd_Init();
  Lcd_Cmd(LCD_CURSOR_OFF); 
  Lcd_Out(1, 0, "MODBUS");
  while(1)
  {
    if(modbusMessage){
      decodeIt();}

    sprintf(str, "%02X %02X %02X %02X", holdingReg[0],
    holdingReg[1],holdingReg[2],holdingReg[3]); 
    Lcd_Out(2, 0, str);
    
        
        LATD = holdingReg[0];
        LATEbits.LATE0 = coils[0];
  }

}
void interrupt isr(void)
{
  if(PIR1bits.RCIF)
  { // USART receive interrupt flag has been set
         
    if((!endOfMessage)&&(!newMessage)){
      if(PIR1bits.TXIF){     // check if the TXREG is empty
        received[z] = ReceiveBuffer;
        z++;
        timerCount = 0;
      }
    }
    if(newMessage){
      OpenTmr0();
      if(PIR1bits.TXIF){     // check if the TXREG is empty
        received[z] = ReceiveBuffer;
        z++;
        newMessage = 0;
        endOfMessage = 0;
        messageLength = 0;
        modbusMessage = 0;
        timerCount = 0;
        return;
      }
    }
  PIR1bits.RCIF = 0;
  }
  if(INTCONbits.TMR0IF){ //TMR0 interrupt flag
    modbusDelay();  //Resets timer for 1.04ms
    timerCount++;
    if(timerCount > 4){
      endOfMessage = 1;
      newMessage = 1;
      messageLength = z;
      modbusMessage = 1;
      for(z=(messageLength);z!=125;z++){ //Clear rest of message
        received[z] = 0;
      }
      z=0;
      T0CONbits.TMR0ON = 0; //Close timer0
      timerCount = 0;
    }
   INTCONbits.TMR0IF = 0;  // Clear flag
  }
}

