/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

// Funciona na Placa Exto NEO201 e na PicGenios
// alterar flexlcd.h para o LCD funcionar em cada uma das placas
// teclado configurado apenas para NEO201, por�m linha 2 do teclado n�o funciona na placa NEO201. O c�digo salta a linha 2.



#define _XTAL_FREQ 8000000
#include <xc.h>
#include "configbits.h"
#include "teclado.h"
#include "flexlcd.h"



//Variables
unsigned char tecla = 0;

void main(void) 
{
    ADCON0 = 0b00000000; // Desabilita o conversor A/D
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    INTCON = 0b00000000;
    INTCON2 = 0b10000000; 
    INTCON2bits.RBPU = 1; // All PORTB pull-ups are disabled
    INTCON3 = 0b00000000; 
    // Input or Output
    TRISB = 0b00000000; // configurado dentro da biblioteca
    TRISC = 0b00000000;
    TRISD = 0b00001111; 
    TRISE = 0b00000000;
    // Clear ports
    PORTA = 0; 
    LATA = 0;
    PORTB = 0; 
    LATB =  0b00000111;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0; 
    LATD = 0;
    PORTE = 0; 
    LATE = 0;
    
    Lcd_Init();
    __delay_ms(100);
    Lcd_Cmd(LCD_CURSOR_OFF);
    Lcd_Out(1, 0, "  AUT  CAT341   ");
    Lcd_Out(2, 0, "Sist. Embarcados");
    __delay_ms(1000);

    Lcd_Cmd(LCD_CLEAR);
    __delay_ms(100);
    Lcd_Out(1, 0, "Tecla:         ");
    
    while(1) 
    {
        CLRWDT();
        
        //C2 = 0;

        tecla = tc_tecla();  

        if (tecla == '1')
        {
            Lcd_Out(2, 0, "1");
            __delay_ms(100);
        }
        if (tecla == '2')
        {
            Lcd_Out(2, 0, "2");
            __delay_ms(100);
        }
        if (tecla == '3')
        {
            Lcd_Out(2, 0, "3");
            __delay_ms(100);
        }
        if (tecla == '4')
        {
            Lcd_Out(2, 0, "4");
            __delay_ms(100);
        }
        if (tecla == '5')
        {
            Lcd_Out(2, 0, "5");
            __delay_ms(100);
        }
        if (tecla == '6')
        {
            Lcd_Out(2, 0, "6");
            __delay_ms(100);
        }
        if (tecla == '7')
        {
            Lcd_Out(2, 0, "7");
            __delay_ms(100);
        }
        if (tecla == '8')
        {
            Lcd_Out(2, 0, "8");
            __delay_ms(100);
        }
        if (tecla == '9')
        {
            Lcd_Out(2, 0, "9");
            __delay_ms(100);
        }
        if (tecla == '0')
        {
            Lcd_Out(2, 0, "0");
            __delay_ms(100);
        }
        if (tecla == 'x')
        {
            Lcd_Out(2, 0, "x");
            __delay_ms(100);
        }
        if (tecla == '-')
        {
            Lcd_Out(2, 0, "-");
            __delay_ms(100);
        }
        if (tecla == 'A')
        {
            Lcd_Out(2, 0, "A");
            __delay_ms(100);
        }
        if (tecla == 'B')
        {
            Lcd_Out(2, 0, "B");
            __delay_ms(100);
        }
        if (tecla == 'C')
        {
            Lcd_Out(2, 0, "C");
            __delay_ms(100);
        }
        if (tecla == 'D')
        {
            Lcd_Out(2, 0, "D");
            __delay_ms(100);
        }
        if (tecla == 'F')
        {
            Lcd_Out(2, 0, "F");
            __delay_ms(100);
        }
        
    }

}
