#ifndef __flex_lcd_H
#define __flex_lcd_H

#include "flexlcd.h"

#include <xc.h>
#define _XTAL_FREQ 8000000

void Lcd_Init(void){
unsigned char data;
TRISRD7 = 0;
TRISRD6 = 0;
TRISRD5 = 0;
TRISRD4 = 0;
TRISEN = 0;
TRISRS = 0;
TRISRW = 0;
LCD_RW = 0;
LCD_RD7 = 0;
LCD_RD6 = 0;
LCD_RD5 = 0;
LCD_RD4 = 0;
LCD_EN = 0;
LCD_RS = 0;
__delay_us(5500);
__delay_us(5500);
__delay_us(5500);
__delay_us(5500);
__delay_us(5500);
__delay_us(5500);
for(data = 1; data < 4; data ++)
{
    LCD_RD7 = 0;    LCD_RD6 = 0;    LCD_RD5 = 1;    LCD_RD4 = 1;    LCD_EN = 0;
    LCD_RS = 0;    LCD_RD7 = 0;    LCD_RD6 = 0;    LCD_RD5 = 1;    LCD_RD4 = 1;
    LCD_EN = 1;    LCD_RS = 0;
    __delay_us(5);
    LCD_RD7 = 0;    LCD_RD6 = 0;    LCD_RD5 = 1;    LCD_RD4 = 1;    LCD_EN = 0;
    LCD_RS = 0;
    __delay_us(5500);
}
LCD_RD7 = 0; LCD_RD6 = 0; LCD_RD5 = 1; LCD_RD4 = 0; LCD_EN = 0; LCD_RS = 0;
LCD_RD7 = 0; LCD_RD6 = 0; LCD_RD5 = 1; LCD_RD4 = 0; LCD_EN = 1; LCD_RS = 0;
__delay_us(5);
LCD_RD7 = 0; LCD_RD6 = 0; LCD_RD5 = 1; LCD_RD4 = 0; LCD_EN = 0; LCD_RS = 0;
__delay_us(5500);
data = 40; Lcd_Cmd(data);
data = 16; Lcd_Cmd(data);
data = 1;  Lcd_Cmd(data);
data = 15; Lcd_Cmd(data);
}


void Lcd_Out(unsigned char y, unsigned char x, const char *buffer)
{

unsigned char data;
switch (y)
{   
    case 1: data = 128 + x; break;
    case 2: data = 192 + x; break;
    case 3: data = 148 + x; break;
    case 4: data = 212 + x; break;
    default: break;
}
Lcd_Cmd(data);
while(*buffer)              // Write data to LCD up to null
{                
    Lcd_Chr_CP(*buffer);
    buffer++;               // Increment buffer
}
return;
}


void Lcd_Out2(unsigned char y, unsigned char x, char *buffer)
{

unsigned char data;
switch (y)
{
    case 1: data = 128 + x; break;
    case 2: data = 192 + x; break;
    case 3: data = 148 + x; break;
    case 4: data = 212 + x; break;
    default: break;
}
Lcd_Cmd(data);
while(*buffer)              // Write data to LCD up to null
{                
    Lcd_Chr_CP(*buffer);
    buffer++;               // Increment buffer
}
return;
}


void Lcd_Chr_CP(char data){

LCD_EN = 0; LCD_RS = 1;
LCD_RD7 = (data & 0b10000000)>>7; LCD_RD6 = (data & 0b01000000)>>6;
LCD_RD5 = (data & 0b00100000)>>5; LCD_RD4 = (data & 0b00010000)>>4;
_delay(10);
LCD_EN = 1; __delay_us(5); LCD_EN = 0;
LCD_RD7 = (data & 0b00001000)>>3; LCD_RD6 = (data & 0b00000100)>>2;
LCD_RD5 = (data & 0b00000010)>>1; LCD_RD4 = (data & 0b00000001);
_delay(10);
LCD_EN = 1; __delay_us(5); LCD_EN = 0;
__delay_us(5); __delay_us(5500);
}


void Lcd_Cmd(unsigned char data){

LCD_EN = 0; LCD_RS = 0;
LCD_RD7 = (data & 0b10000000)>>7; LCD_RD6 = (data & 0b01000000)>>6;
LCD_RD5 = (data & 0b00100000)>>5; LCD_RD4 = (data & 0b00010000)>>4;
_delay(10);
LCD_EN = 1; __delay_us(5); LCD_EN = 0;
LCD_RD7 = (data & 0b00001000)>>3; LCD_RD6 = (data & 0b00000100)>>2;
LCD_RD5 = (data & 0b00000010)>>1; LCD_RD4 = (data & 0b00000001);
_delay(10);
LCD_EN = 1; __delay_us(5); LCD_EN = 0;
__delay_us(5500);//Delay_5us();
}

#endif