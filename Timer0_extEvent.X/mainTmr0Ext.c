/*
 * File:   main.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

#include "configbits.h"
#define _XTAL_FREQ 8000000
#include <xc.h>


void main(void) 
{
    ////////////////////////
    /// Configure Ports
    ////////////////////////
    TRISB = 0b00000001; //All pins as output
    TRISD = 0b00000000; //All pins as output
    PORTB = 0; //All pins off
    LATB = 0; //All pins off
    PORTD = 0; //All pins off
    LATD = 0; //All pins off   
   
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O digital
    // RBPU: PORTB Pull-up Enable bit 
    INTCON2bits.RBPU = 0; // 0 = PORTB pull-ups are enabled by individual port latch values 
    ////////////////////////
    /// Configure Ports
    ////////////////////////
    // Timer as external event counter
    T0CON = 0b10011111;
    TMR0 = 0;
    while(1) 
    {
        CLRWDT();
        if (TMR0 > 10)
        {
            LATDbits.LATD0 = ~LATDbits.LATD0; // Toggle led     
        }
    }
    
    return;
}
/**************************************************************
* Function: void interrupt isr(void)
*
* Returns: Nothing
*
* Description: Interrupt triggered on pushbutton press
***************************************************************/
void interrupt isr(void){

}
