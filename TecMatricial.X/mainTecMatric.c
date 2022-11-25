/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

// Funciona apenas na PICGênios

#include "configbits.h"

#define _XTAL_FREQ 8000000
#include <xc.h>
//Variables
char tecla;

//identifiers
#define rele1 LATCbits.LC0
#define rele2 LATEbits.LE0



// saídas (colunas), ativadas por 0
#define C1 LATBbits.LB0
#define C2 LATBbits.LB1
#define C3 LATBbits.LB2

// entradas (linhas), com pull-up externo
#define L1 PORTDbits.RD3
#define L2 PORTDbits.RD2
#define L3 PORTDbits.RD1
#define L4 PORTDbits.RD0

unsigned char teclado(void); 

void main(void) 
{
    ADCON0 = 0b00000000;
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1; // Pull-up resistors off
    // Input or Output
    TRISB = 0b00000000; 
    TRISC = 0b00000000;
    TRISD = 0b00001111; 
    TRISE = 0b00000000;
    // Clear ports
    PORTB = 0xFF; 
    LATB = 0xFF;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0; 
    LATD = 0;
    PORTE = 0; 
    LATE = 0;
    while(1) 
    {
        CLRWDT();
        tecla = teclado();
        if (tecla == '1')
        {
            rele1 = 1;
        }
        if (tecla == '2')
        {
            rele2 = 1;
        }
        if (tecla == '3')
        {
            rele1 = 0;
            rele2 = 0;
        }
        
    }
    return;
}

unsigned char teclado(void)
{
   char key = ' ';
   C1 = 1; C2 = 1; C3 = 1;
   C1 = 0; //habilita primeira coluna
   if(!L1)        {__delaywdt_ms(20); if (!L1){key = '1'; }}
   else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '4'; }}
   else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '7'; }}
   else if(!L4)   {__delaywdt_ms(20); if (!L4){key = 'x'; }}
   
   C1 = 1;
   C2 = 0;

   if(!L1)        {__delaywdt_ms(20); if (!L1){key = '2';  }}
   else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '5';  }}
   else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '8';  }}
   else if(!L4)   {__delaywdt_ms(20); if (!L4){key = '0';  }}
   
   C2 = 1;
   C3 = 0;

   if(!L1)        {__delaywdt_ms(20); if (!L1){key = '3';  }}
   else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '6';  }}
   else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '9';  }}
   else if(!L4)   {__delaywdt_ms(20); if (!L4){key = '-';  }}
   
   C3 = 1;
   __delaywdt_ms(5);
   
   return(key);
}
