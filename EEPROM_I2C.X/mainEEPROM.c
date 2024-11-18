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
#include <stdio.h>
#include "i2c.h"
#include "rtc.h"
#include "eeprom.h"
#include "eeprom_ext.h"


//Variables
unsigned int duty = 100, count = 0; // 0 a 255
unsigned char str[5];
// sa�das (colunas), ativadas por 0
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
    TRISD = 0b00000000; 
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

    i2c_init();
    i2c_start();
    
    //day, mth, year, dow, hr, min, sec)
    rtc_w(02, 12, 20, 4, 10, 40, 15);
    __delaywdt_ms(200);
    
    
    
    //ei();
    //INTCON = 0b11000000; // enable global and peripheral interrupts
    e2prom_w(0, 33); // interna
    e2pext_w(0, 47); // externa
    
    while(1) 
    {
        CLRWDT();        
        
        rtc_r(); // ler valores date e time
        __delaywdt_ms(50);
            
        Lcd_Out(1, 0, date);
        Lcd_Out(2, 0, time);
        if(e2prom_r(0) == 33)
        {
            LATBbits.LB0 = 1;
        }
        if(e2pext_r(0) == 47)
        {
            LATBbits.LB1 = 1;
        }
        __delaywdt_ms(2000);
    }
    return;
}
