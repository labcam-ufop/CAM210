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
#include "serial.h"


//Variables
unsigned int segundos = 0, duty = 127, infrav = 0, count = 0, result = 0; // 0 a 255
char str[5], buffer_tx[20], buffer_rx[20];

// saídas (colunas), ativadas por 0
#define C1 LATBbits.LB0
#define C2 LATBbits.LB1
#define C3 LATBbits.LB2

// entradas (linhas), com pull-up externo
#define L1 PORTDbits.RD3
#define L2 PORTDbits.RD2
#define L3 PORTDbits.RD1
#define L4 PORTDbits.RD0

// resistência de aquecimento RC5
#define aquec PORTCbits.RC5

void main(void) 
{
    ADCON0 = 0b00000000; // Configura todos pinos para digital
    ADCON1 = 0x00; // habilita todas as portas analógicas
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
    TRISC = 0b10000001;
    TRISD = 0b00000000; 
    TRISE = 0b00000001;
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
    
    PWM1_Init(1000);  // configura frequencia do PWM para 1kHz  
    PWM1_Start(); // configura registradores e inicia PWM
  
    serial_init();
    adc_init(); // configura registradores ADCON
    Lcd_Init();
    Lcd_Cmd(LCD_CURSOR_OFF); 
    
    //Timer 0 config
    INTCONbits.TMR0IF = 0; // TMR0 register has overflowed (must be cleared in software)
    INTCONbits.TMR0IE = 1; //1 = Enables the TMR0 overflow interrupt
    T0CON = 0b11000101; //  8bit and 1:64 Prescale
    TMR0 = 131;  
    INTCON = 0b11100000; // enable gobal and peripheric interrupts,
    // aquecedor ligado
    aquec = 1;
    while(1) 
    {
        CLRWDT();         
        serial_rx_str_until(buffer_rx,20,'\n');  
        Lcd_Out(2, 0, buffer_rx);
    }
    return;
}
void interrupt isr(void)
{
    if (INTCONbits.TMR0IF == 1)
    {
        INTCONbits.TMR0IF = 0; // Clear interrupt flag
        TMR0 = 131;
        count ++;
        if (count == 250)
        {
            count = 0;
            segundos++;
            LATDbits.LATD1 = ~LATDbits.LATD1; // Toggle led  
            PWM1_Set_Duty(duty); 
            infrav = TMR1L;
            infrav += TMR1H<<8;
            sprintf(str, "%05u",  infrav);        
            Lcd_Out(1, 0, str);
            result = adc_amostra(1); // sensor de temperatura LM35 canal 1, 
            sprintf(buffer_tx, "/*%04d/\n", result); 
            serial_tx_str(buffer_tx);   
            if (segundos>160)
            {
                duty = 178; //+20% fundo de escala (255)
            }
        }        
    }
}
