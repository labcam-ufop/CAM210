/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

// Funciona na Placa Exto NEO201 e na PicGenios
// alterar flexlcd.h para o LCD funcionar em cada uma das placas
// teclado configurado apenas para NEO201, porém linha 2 do teclado não funciona na placa NEO201. O código salta a linha 2.



#define _XTAL_FREQ 8000000
#include <xc.h>
#include "configbits.h"
#include "teclado.h"
#include "flexlcd.h"
#include "atraso.h"


//Variables
unsigned char tecla = ' ';

void main(void) 
{
    ADCON0 = 0b00000000; // Desabilita o conversor A/D
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    INTCON = 0b00000000;
    INTCON2 = 0b10000000; // All PORTB pull-ups are disabled
    INTCON2bits.RBPU = 0;
    INTCON3 = 0b00000000; 
    // Input or Output
    TRISB = 0b00001111; // configurado dentro da biblioteca
    TRISC = 0b00000000;
    TRISD = 0; 
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
    Lcd_Out(1, 0, "  AUT  CAT341  ");
    Lcd_Out(2, 0, "Sist. Embarcados");
    __delay_ms(200);
    while(1) 
    {
        CLRWDT();
        
        //C2 = 0;
        
        tecla = tc_tecla();  
        //__delay_ms(200);
        //Lcd_Out(2, 1, tecla);
        if (tecla == '1')
        {
            Lcd_Out(1, 0, "1");
            __delay_ms(100);
        }
        else if (tecla == '2')
        {
            Lcd_Out(1, 0, "2");
            __delay_ms(100);
        }
        else if (tecla == '3')
        {
            Lcd_Out(1, 0, "3");
            __delay_ms(100);
        }
        else if (tecla == '4')
        {
            Lcd_Out(1, 0, "4");
            __delay_ms(100);
        }
        else if (tecla == '5')
        {
            Lcd_Out(1, 0, "5");
            __delay_ms(100);
        }
        else if (tecla == '6')
        {
            Lcd_Out(1, 0, "6");
            __delay_ms(100);
        }
        else if (tecla == '7')
        {
            Lcd_Out(1, 0, "7");
        }
        else if (tecla == '8')
        {
            Lcd_Out(1, 0, "8");
        }
        else if (tecla == '9')
        {
            Lcd_Out(1, 0, "9");
        }
        else if (tecla == '0')
        {
            Lcd_Out(1, 0, "0");
        }
        else if (tecla == 'x')
        {
            Lcd_Out(1, 0, "x");
        }
        else if (tecla == '-')
        {
            Lcd_Out(1, 0, "-");
        }
        else if (tecla == 'A')
        {
            Lcd_Out(1, 0, "A");
        }
        else if (tecla == 'B')
        {
            Lcd_Out(1, 0, "B");
        }
        else if (tecla == 'C')
        {
            Lcd_Out(1, 0, "C");
        }
        else if (tecla == 'D')
        {
            Lcd_Out(1, 0, "D");
        }
        else if (tecla == 'F')
        {
            Lcd_Out(1, 0, "F");
        }
        
    }

}
