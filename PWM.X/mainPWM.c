/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */

// Funciona na Placa Exto NEO201 e na PicGenios
// alterar flexlcd.h para o LCD funcionar em cada uma das placas

#define _XTAL_FREQ 8000000
#include "configbits.h"
#include <xc.h>
#include "flexlcd.h"
#include "pwm.h"

unsigned int duty = 10;

void main(void) 
{
    ADCON0 = 0b00000000; // Desabilita o conversor A/D
    ADCON1 = 0b00001111; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1; // Pull-up resistors
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
    Lcd_Out(2, 0, "      PWM       ");
    
    PWM1_Init(1000);  // configura frequencia do PWM para 1kHz
    PWM1_Start(); // configura registradores e inicia PWM
    
    while(1) 
    {
        CLRWDT();   
    }
    return;
}
