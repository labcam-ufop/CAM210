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
#include "adc.h"
#include <stdio.h>
#include "itoa.h"


//Variables
unsigned int adcResult;
char tecla, key;
float volt = 0;
char str[4], date[10], time[10];

#define aquecedor LATCbits.LC1


void main(void) 
{
    //ADCON0 = 0b00000000;
    ADCON1 = 0x6; //configura todos os pinos AD da porta B como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1; // Pull-up resistors off
        
    // Input or Output
    TRISA = 0xFF;
    TRISB = 0b00000000; 
    TRISC = 0b00000000;
    TRISD = 0b00001111; 
    TRISE = 0b00000000;
    // Clear ports
    PORTA = 0; 
    LATA = 0;
    PORTB = 0; 
    LATB = 0;
    PORTC = 0; 
    LATC = 0;
    PORTD = 0; 
    LATD = 0;
    PORTE = 0; 
    LATE = 0;
    
    adc_init(); // configura registradores ADCON
    Lcd_Init();
    Lcd_Cmd(LCD_CURSOR_OFF); 
    
    aquecedor = 1; //Na placa EXTO NEO201, incluir jumper em RC1/SW0 e SW0/Aquecedor
    // ventilador está em RC2
    // lm35 em AN0
    
unsigned int adc_amostra(unsigned char canal);
    while(1) 
    {
        CLRWDT();
        adcResult = (adc_amostra(1));  //Sensor de temperatura: PICGêncios AN1, Exto AN0
        volt = (adcResult*5.0)/1023;
        sprintf(str, "ADC = %04d", adcResult);
        Lcd_Out(1, 0, str);
        sprintf(str, "Tensao = %05.2f V", volt); // 05.f = 5 dígitos (preencher
                     //de 0 quando vazio), incluindo o zero, e 2 casas decimais
        Lcd_Out(2, 0, str);
    
    }
    return;
}
