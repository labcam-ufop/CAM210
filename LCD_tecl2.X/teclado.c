
#include <xc.h>
#include "teclado.h"
#include "flexlcd.h"
#define _XTAL_FREQ 8000000
#define delay_teclas 5

# if (BOARD == 0)
// PLACA PICGENIOS

unsigned char tc_tecla()
{
  unsigned char key = 0;

    C1 = 0; C2 = 1; C3 = 1;  //habilita primeira coluna
    if(!L1)   {__delay_ms(delay_teclas); if (!L1){key = '1'; return key; }}
    if(!L2)   {__delay_ms(delay_teclas); if (!L2){key = '4'; return key; }}
    if(!L3)   {__delay_ms(delay_teclas); if (!L3){key = '7'; return key; }}
    if(!L4)   {__delay_ms(delay_teclas); if (!L4){key = 'x'; return key; }}

    C1 = 1;
    C2 = 0;

    if(!L1)   {__delay_ms(delay_teclas); if (!L1){key = '2'; return key; }}
    if(!L2)   {__delay_ms(delay_teclas); if (!L2){key = '5'; return key; }}
    if(!L3)   {__delay_ms(delay_teclas); if (!L3){key = '8'; return key; }}
    if(!L4)   {__delay_ms(delay_teclas); if (!L4){key = '0'; return key; }}

    C2 = 1;
    C3 = 0;

    if(!L1)   {__delay_ms(delay_teclas); if (!L1){key = '3'; return key; }}
    if(!L2)   {__delay_ms(delay_teclas); if (!L2){key = '6'; return key; }}
    if(!L3)   {__delay_ms(delay_teclas); if (!L3){key = '9'; return key; }}
    if(!L4)   {__delay_ms(delay_teclas); if (!L4){key = '-'; return key; }}
    
    __delay_ms(1);  
    
   return 0;

}

#else

unsigned char tc_tecla()
{
    
    unsigned char key;

    L1 = 1; L2 = 1; L3 = 1; L4 = 1;
    L1 = 0; //habilita primeira coluna
    if(!C1)        {__delay_ms(delay_teclas); if (!C1){key = '1';  }}
    else if(!C2)   {__delay_ms(delay_teclas); if (!C2){key = '2';  }}
    else if(!C3)   {__delay_ms(delay_teclas); if (!C3){key = '3';  }}
    else if(!C4)   {__delay_ms(delay_teclas); if (!C4){key = 'A';  }}

    L1 = 1;
    L2 = 0;

    if(!C1)        {__delay_ms(delay_teclas); if (!C1){key = '4';  }}
    else if(!C2)   {__delay_ms(delay_teclas); if (!C2){key = '5';  }}
    else if(!C3)   {__delay_ms(delay_teclas); if (!C3){key = '6';  }}
    else if(!C4)   {__delay_ms(delay_teclas); if (!C4){key = 'B';  }}

    L2 = 1;
    L3 = 0;

    if(!C1)        {__delay_ms(delay_teclas); if (!C1){key = '7';  }}
    else if(!C2)   {__delay_ms(delay_teclas); if (!C2){key = '8';  }}
    else if(!C3)   {__delay_ms(delay_teclas); if (!C3){key = '9';  }}
    else if(!C4)   {__delay_ms(delay_teclas); if (!C4){key = 'C';  }}

    L3 = 1;
    L4 = 0;

    if(!C1)        {__delay_ms(delay_teclas); if (!C1){key = 'x';  }}
    else if(!C2)   {__delay_ms(delay_teclas); if (!C2){key = '0';  }}
    else if(!C3)   {__delay_ms(delay_teclas); if (!C3){key = 'F';  }}
    else if(!C4)   {__delay_ms(delay_teclas); if (!C4){key = 'D';  }}

    L4 = 1;

    __delay_ms(5);



  return key;

}

#endif