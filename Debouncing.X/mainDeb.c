/*
 * File:   mainDeb.c
 * Author: Alan Kardek
 *
 * Created on 12 de Novembro de 2020, 12:13
 */
// Funciona na Placa Exto NEO201 e na PicGenios
// alterar flexlcd.h para o LCD funcionar em cada uma das placas

#include "configbits.h"
#define _XTAL_FREQ 8000000
#include <xc.h>
//Variables
#define t_filtro 10;
__bit bt_press = 0;
int filtro0 = t_filtro;

//identifiers
#define bt_up PORTBbits.RB0
#define led1 LATDbits.LD0
#define bt_up2 PORTBbits.RB1
#define led2 LATDbits.LD1

void main(void) 
{
    //ADCON0 = 0b00000000;
    //ADCON1 = 6; //configura todos os pinos AD como I/O
    //ADCON2 = 0b00000000;
    //INTCON = 0b00000000;
    //INTCON2 = 0b00000000;
    INTCON2bits.RBPU = 1; // habilita pull up porta b
    TRISB = 0b00000011; 
    TRISD = 0x00; 
    PORTB = 0; 
    LATB = 0;  
    PORTD = 0; 
    LATD = 0;
    while(1) 
    {
        CLRWDT();
        if (bt_up==0)            // O bot�o UP est� pressionado ?
        {               // sim,
            if (!(bt_press))      // O bot�o UP j� foi tratado ?
            {            // n�o.
                if (filtro0 > 0)   // Fim do filtro do bot�o UP ?
                {
                    filtro0--;   // N�o, ent�o decrementa o filtro
                }
                else 
                {         // Sim, Faz a a��o do bot�o
                    bt_press = 1;   // Marca que o bot�o est� pressionado
                    led1 = ~led1;
                }
            }
        }
        else
        {               // bot�o liberado
            filtro0 = t_filtro; // inicia o filtro do bot�o 
            bt_press = 0;   // marca que o bot�o foi liberado
        }     
        if (bt_up2 == 0)
        {
            led2 = ~led2;
            __delaywdt_ms(200);
        }
    }
    return;
}
