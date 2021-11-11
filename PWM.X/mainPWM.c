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
#include "adc.h"
#include <stdio.h>
#include "itoa.h"
#include "pwm.h"


//Variables
unsigned int duty = 255, count = 0; // 0 a 255
char str[5];

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
    ADCON0 = 0b00000000; // Configura todos pinos para digital
    ADCON1 = 0x06; // desabilita o conversor A/D
    //ADCON2 = 0b00000000;    
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1; // Pull-up resistors off
    T1CON = 0b10000011; // configura Timer1
    //PIE1bits.TMR1IE = 1; // TMR1 enable interrupt
    //PIR1bits.TMR1IF = 0; // TMR1 interrupt flag
    TMR1L = 0; 
    TMR1H = 0; // valor inicial
    
    // Input or Output
    TRISA = 0xFF;
    TRISB = 0b00000000; 
    TRISC = 0b00000001;
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
    
    //adc_init(); // configura registradores ADCON
    Lcd_Init();
    Lcd_Cmd(LCD_CURSOR_OFF); 
    PWM1_Init(1000);  // configura frequencia do PWM para 1kHz
    PWM1_Start(); // configura registradores e inicia PWM
    //ei();
    //INTCON = 0b11000000; // enable global and peripheral interrupts
    
    while(1) 
    {
        CLRWDT();        
        
        PWM1_Set_Duty(duty);        
        count = TMR1L;
        count += TMR1H<<8;
        sprintf(str, "%05u",  count);        
        Lcd_Out(1, 0, str);
        __delaywdt_ms(1000);    

    }
    return;
}
