/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */
#define _XTAL_FREQ 8000000
#include "configbits.h"
#include <xc.h>
#include "flexlcd.h"

//Variables
char tecla, key;

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

void main(void) 
{
    //ADCON0 = 0b00000000;
    //ADCON1 = 6; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 0; // Pull-up resistors
    // Input or Output
    TRISB = 0b00000000; 
    TRISC = 0b00000000;
    TRISD = 0b00001111; 
    TRISE = 0b00000000;
    // Clear ports
    PORTB = 0; 
    LATB = 0;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0; 
    LATD = 0;
    PORTE = 0; 
    LATE = 0;
    
    Lcd_Init();
    Lcd_Cmd(LCD_CURSOR_OFF);
    Lcd_Out(1, 0, "PROFICAM  CAM210");
    Lcd_Out(2, 0, "Sist. Embarcados");
    while(1) 
    {
        CLRWDT();
        C1 = 1; C2 = 1; C3 = 1;
    C1 = 0; //habilita primeira coluna
    if(!L1)        {__delaywdt_ms(10); if (!L1) {key = '1';  }}
    else if(!L2)   {__delaywdt_ms(10); if (!L2){key = '4';  }}
    else if(!L3)   {__delaywdt_ms(10); if (!L3){key = '7';  }}
    else if(!L4)   {__delaywdt_ms(10); if (!L4){key = 'x';  }}

    C1 = 1;
    C2 = 0;

    if(!L1)        {__delaywdt_ms(10); if (!L1){key = '2';  }}
    else if(!L2)   {__delaywdt_ms(10); if (!L2){key = '5';  }}
    else if(!L3)   {__delaywdt_ms(10); if (!L3){key = '8';  }}
    else if(!L4)   {__delay_ms(10); if (!L4){key = '0';  }}

    C2 = 1;
    C3 = 0;

    if(!L1)        {__delaywdt_ms(10); if (!L1){key = '3';  }}
    else if(!L2)   {__delaywdt_ms(10); if (!L2){key = '6';  }}
    else if(!L3)   {__delaywdt_ms(10); if (!L3){key = '9';  }}
    else if(!L4)   {__delaywdt_ms(10); if (!L4){key = '-';  }}

    C3 = 1;
    __delaywdt_ms(5);
    tecla = key;
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
