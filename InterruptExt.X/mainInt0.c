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
    TRISB = 0b00000011; //
    TRISD = 0b00000000; //All pins as output
    PORTB = 0; //All pins off
    LATB = 0; //All pins off
    PORTD = 0; //All pins off
    LATD = 0; //All pins off   
    
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O digital
    // RBPU: PORTB Pull-up Enable bit 
    INTCON2bits.RBPU = 1; // 0 = PORTB pull-ups are enabled by individual port latch values 
    ////////////////////////
    /// Configure Ports
    ////////////////////////
    // INTEDG0: External Interrupt 0 Edge Select bit 
    INTCON2bits.INTEDG0 = 0; // 0 = Interrupt on falling edge
    // INT0IF: INT0 External Interrupt Flag bit
    INTCONbits.INT0IF = 0; // The INT0 external interrupt occurred (must be cleared in software) 
    // INT0IE: INT0 External Interrupt Enable bit 
    INTCONbits.INT0IE = 1; //1 = Enables the INT0 external interrupt 
          
    
//    INTEDG1 = 0;
//    INT1IF = 0;
//    INT1IE = 1;
    
    INTCONbits.GIE = 1;
    //ei(); // Enable global interrupt
    while(1) 
    {
        CLRWDT();
        LATDbits.LATD1 = ~LATDbits.LATD1;
        __delaywdt_ms(500);
        if (PORTBbits.RB1==0)
        {
            LATDbits.LD2 = 1;
        }
        else
        {
            LATDbits.LD2 = 0;
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
void interrupt isr(void)
{
    if (INTCONbits.INT0IF == 1)
    {
        // Clear interrupt flag
        INTCONbits.INT0IF = 0;
        // Toggle led
        LATDbits.LATD0 = ~LATDbits.LATD0;
        __delaywdt_ms(2000);
    }
//    if (INT1F == 1)
//    {
//        INT1F = 0;
//        LATD2 = ~LATD2;
//    }
}
