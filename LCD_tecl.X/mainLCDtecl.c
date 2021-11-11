/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */
#define _XTAL_FREQ 8000000
#include <xc.h>
#include "configbits.h"
//#include "teclado.h"
#include "flexlcd.h"


//Variables
unsigned char tecla;
char key = ' ';

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
    ADCON0 = 0b00000000; // Desabilita o conversor A/D
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    INTCON = 0b00000000;
    INTCON2 = 0b10000000; // All PORTB pull-ups are disabled
    INTCON3 = 0b00000000;
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
    
    Lcd_Init();
    Lcd_Cmd(LCD_CURSOR_OFF);
    __delay_ms(100);
    while(1) 
    {
    CLRWDT();
    C1 = 1; C2 = 1; C3 = 1;
    C1 = 0; //habilita primeira coluna
    if(!L1)        {__delaywdt_ms(20); if (!L1) {key = '1';  Lcd_Out2(1, 0, "1");}}
    else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '4';  Lcd_Out2(1, 0, "4");}}
    else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '7';  Lcd_Out2(1, 0, "7");}}
    else if(!L4)   {__delaywdt_ms(20); if (!L4){key = 'x';  Lcd_Out2(1, 0, "x");}}

    C1 = 1;
    C2 = 0;

    if(!L1)        {__delaywdt_ms(20); if (!L1){key = '2';  Lcd_Out2(1, 0, "2");}}
    else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '5';  Lcd_Out2(1, 0, "5");}}
    else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '8';  Lcd_Out2(1, 0, "8");}}
    else if(!L4)   {__delay_ms(20); if (!L4){key = '0';  Lcd_Out2(1, 0, "0");}}

    C2 = 1;
    C3 = 0;

    if(!L1)        {__delaywdt_ms(20); if (!L1){key = '3';  Lcd_Out2(1, 0, "3");}}
    else if(!L2)   {__delaywdt_ms(20); if (!L2){key = '6';  Lcd_Out2(1, 0, "6");}}
    else if(!L3)   {__delaywdt_ms(20); if (!L3){key = '9';  Lcd_Out2(1, 0, "9");}}
    else if(!L4)   {__delaywdt_ms(20); if (!L4){key = '-';  Lcd_Out2(1, 0, "-");}}

    C3 = 1;
    __delaywdt_ms(5);
   
    }
    return;
}
