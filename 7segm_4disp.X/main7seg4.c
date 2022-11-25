/*
 * File:   main.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

// Contagem nos displays via INT0, RB1 ou RB2
// Funciona na placa de desenvolvimento Exto NEO201, apenas os displays 2, 3 e 4
// Funciona no PICSimLAB, placa PICGenios

#include "configbits.h"
#define _XTAL_FREQ 8000000
#include <xc.h>
#include "display7s.h"

// variables
int count = 0;
unsigned char tmp;
__bit bt_press = 0;
#define t_filtro 10;
int filtro0 = t_filtro;


#define bt_up PORTBbits.RB1
#define bt_up2 PORTBbits.RB2

void main(void) 
{
    ////////////////////////
    /// Configure Ports
    ////////////////////////
    TRISA = 0b00000000; //
    TRISB = 0b00000111; //
    TRISD = 0b00000000; //
    TRISE = 0b00000000;
    PORTA = 0; //All pins off
    LATA = 0; //All pins off
    PORTB = 0; //All pins off
    LATB = 0; //All pins off
    PORTD = 0; //All pins off
    LATD = 0; //All pins off   
    PORTE = 0; //All pins off
    LATE = 0; //All pins off   
    
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
    //TMR0IF: TMR0 Overflow Interrupt Flag bit
    INTCONbits.TMR0IF = 0; // TMR0 register has overflowed (must be cleared in software)
    //TMR0IE: TMR0 Overflow Interrupt Enable bit
    INTCONbits.TMR0IE = 1; //1 = Enables the TMR0 overflow interrupt

    //Timer 0 config
    T0CON = 0b11000101; // 8bit and 1:64 Prescale
    TMR0 = 131;
    ei(); // Enable global interrupt
    
    while(1) 
    {
        CLRWDT();
        for(int i=0;i<4;i++)
        {
            switch(i)
            {
               case 0: 
                 LATA = 0b00100000;
                 LATD = display7s(tmp);	
                 break;
               case 1: 
                 LATA =0b00000100;
                 LATD = display7s(tmp);	
                 break;
               case 2:            
                 LATA =0b00001000; // transistor do PICSIMLAB
                 LATE = 0b00000001; // transistor da EXTO
                 LATD = display7s(tmp);	
                 break;
               case 3: 
                 LATA =0b00010000; // transistor do PICSIMLAB
                 LATE = 0b00000100; // transistor da EXTO
                 LATD = display7s(tmp);	
                 break;
            }
            __delaywdt_ms(1);	

        }
        
        if (bt_up==0)            // O botão UP está pressionado ?
        {               // sim,
            if (!(bt_press))      // O botão UP já foi tratado ?
            {            // não.
                if (filtro0 > 0)   // Fim do filtro do botão UP ?
                {
                    filtro0--;   // Não, então decrementa o filtro
                }
                else 
                {         // Sim, Faz a ação do botão
                    bt_press = 1;   // Marca que o botão está pressionado
                    tmp++;
                    if (tmp>15) tmp=0;
                }
            }
        }
        else
        {               // botão liberado
            filtro0 = t_filtro; // inicia o filtro do botão 
            bt_press = 0;   // marca que o botão foi liberado
        }     
        if (bt_up2 == 0)
        {
            tmp++;
            if (tmp>15) tmp=0;
            __delaywdt_ms(200);
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
    if (INTCONbits.INT0F == 1)
    {              
        tmp++;
        if (tmp>15) tmp=0;
        INTCONbits.INT0F = 0; // Clear interrupt flag
    }
    if (INTCONbits.TMR0IF == 1)
    {
        INTCONbits.TMR0IF = 0; // Clear interrupt flag
        TMR0 = 131;
        count ++;
        if (count == 250)
        {
            count = 0;
            LATBbits.LATB3 = ~LATBbits.LATB3; //não tem LED neste pino na placa, apenas no simulador
            
        }
        
    }
}
