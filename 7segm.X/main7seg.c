/*
 * File:   main.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */
// Funciona no simulador PICSimLab, com a placa PICG�nios
// Funciona na placa de desenvolvimento Exto NEO201

#include "configbits.h"
#define _XTAL_FREQ 8000000
#include <xc.h>
#include "display7s.h"

// variables
int count = 0;
unsigned char tmp;

void main(void) 
{
    ////////////////////////
    /// Configure Ports
    ////////////////////////
    TRISA = 0b00000000; //
    TRISB = 0b00000001; //
    TRISD = 0b00000000; //
    PORTA = 0; //All pins off
    LATA = 0; //All pins off
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
    // INTEDG0: External Interrupt 0 Edge Select bit 
    INTCON2bits.INTEDG0 = 0; // 0 = Interrupt on falling edge
    // INT0IF: INT0 External Interrupt Flag bit
    INTCONbits.INT0IF = 0; // The INT0 external interrupt occurred (must be cleared in software) 
    // INT0IE: INT0 External Interrupt Enable bit 
    INTCONbits.INT0IE = 1; //1 = Enables the INT0 external interrupt 
    //TMR0IF: TMR0 Overflow Interrupt Flag bit
    INTCONbits.TMR0IF = 0; // TMR0 register has overflowed (must be cleared in software)
    //TMR0IE: TMR0 Overflow Interrupt Enable bit
    INTCONbits.TMR0IE = 1; //1 = Enables the TMR0 overflow interrupt

    //Timer 0 config
    T0CON = 0b11000101; // 8bit and 1:64 Prescale
    TMR0 = 131;
    ei(); // Enable global interrupt
    
    LATAbits.LATA2 = 1; //habilita Display 1 da PICGenios
    while(1) 
    {
        CLRWDT();
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
    if (INTCONbits.INT0F == 1)
    {
        INTCONbits.INT0F = 0; // Clear interrupt flag
        tmp = 0;
    }
    if (INTCONbits.TMR0IF == 1)
    {
        INTCONbits.TMR0IF = 0; // Clear interrupt flag
        TMR0 = 131;
        count ++;
        if (count == 250)
        {
            count = 0;
            LATBbits.LATB1 = ~LATBbits.LATB1;
            LATD = display7s(tmp);
            tmp++;
            if (tmp > 15)
            {
                tmp = 0;
            }
        }
        
    }
}
