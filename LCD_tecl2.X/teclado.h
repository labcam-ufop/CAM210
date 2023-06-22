#include "flexlcd.h"

# if (BOARD == 0)
// PLACA PICGENIOS

// saídas (colunas), ativadas por 0
#define C1 LATBbits.LB0
#define C2 LATBbits.LB1
#define C3 LATBbits.LB2

// entradas (linhas), com pull-up externo
#define L1 PORTDbits.RD3
#define L2 PORTDbits.RD2
#define L3 PORTDbits.RD1
#define L4 PORTDbits.RD0

#else
// PLACA NEXSTO NE0201

// ENTRADAS (colunas)
#define C1 PORTBbits.RB3
#define C2 PORTBbits.RB2
#define C3 PORTBbits.RB1
#define C4 PORTBbits.RB0

// SAÍDAS (linhas)
#define L1 LATBbits.LB4 // 
#define L2 LATBbits.LB5 // problema
#define L3 LATBbits.LB6
#define L4 LATBbits.LB7

#endif

unsigned char tc_tecla(); /*timeout=0 no time out*/ 
