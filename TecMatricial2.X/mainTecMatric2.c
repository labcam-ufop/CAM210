/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */
#define _XTAL_FREQ 8000000
#include "configbits.h"
#include "teclado.h"
#include "atraso.h"
#include <xc.h>
//Variables
char tecla;

//identifiers
#define rele1 LATCbits.LC0
#define rele2 LATEbits.LE0

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
        //CLRWDT();
        tecla = tc_tecla(1500)+0x30;
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
