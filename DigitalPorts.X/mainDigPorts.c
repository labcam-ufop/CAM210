/*
 * File:   main.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

#include "configbits.h" // fuses de grava��o
#define _XTAL_FREQ 8000000
#include <xc.h>


#define Bt1 PORTBbits.RB0

#define Led1 LATDbits.LD0


void main(void) 
{
    //ADCON0 = 0b00000000;
    //ADCON1 = 6; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1;
    TRISB = 0b00000001; //
    TRISC = 0x00; //All pins as output
    TRISD = 0x00; //All pins as output
    PORTB = 0; //All pins off
    LATB = 0; //All pins off  ,
    PORTC = 0; //All pins off
    LATC = 0; //All pins off      
    PORTD = 0; //All pins off
    LATD = 0; //All pins off        
    while(1) 
    {
        CLRWDT();
        if (Bt1 == 0)
        {
            Led1 = 1; //Turn RB0 on
        }
        else
        {
            Led1 = 0; //Turn RB1 off
        }
    }
    return;
}

