
//******************************************
//  Libreria para control de LCD           *
//  Modo Control 4 bits                    * 
//  Hector Ramos
//******************************************

#define BOARD 0
//0 para PICGenios
//1 para Exsto NEO

//comandos disponibles
#define      LCD_FIRST_ROW           128
#define      LCD_SECOND_ROW          192
#define      LCD_THIRD_ROW           148
#define      LCD_FOURTH_ROW          212
#define      LCD_CLEAR               1
#define      LCD_RETURN_HOME         2
#define      LCD_CURSOR_OFF          12
#define      LCD_UNDERLINE_ON        14
#define      LCD_BLINK_CURSOR_ON     15
#define      LCD_MOVE_CURSOR_LEFT    16
#define      LCD_MOVE_CURSOR_RIGHT   20
#define      LCD_TURN_OFF            0
#define      LCD_TURN_ON             8
#define      LCD_SHIFT_LEFT          24
#define      LCD_SHIFT_RIGHT         28

// PLACA PICGENIOS
# if (BOARD == 0)
   
    #define LCD_RD7     PORTDbits.RD7       // D7
    #define TRISRD7     TRISDbits.TRISD7

    #define LCD_RD6     PORTDbits.RD6       // D6
    #define TRISRD6     TRISDbits.TRISD6

    #define LCD_RD5     PORTDbits.RD5       // D5
    #define TRISRD5     TRISDbits.TRISD5

    #define LCD_RD4     PORTDbits.RD4       // D4
    #define TRISRD4     TRISDbits.TRISD4

    #define LCD_EN      PORTEbits.RE1       // EN
    #define TRISEN      TRISEbits.TRISE2

    #define LCD_RS      PORTEbits.RE2       // RS
    #define TRISRS      TRISEbits.TRISE1

    #define LCD_RW      PORTEbits.RE0       // RW
    #define TRISRW      TRISEbits.TRISE0

# else

    // PLACA NEXSTO NEO201
    #define LCD_RD7     PORTDbits.RD7       // D7
    #define TRISRD7     TRISDbits.TRISD7

    #define LCD_RD6     PORTDbits.RD6       // D6
    #define TRISRD6     TRISDbits.TRISD6

    #define LCD_RD5     PORTDbits.RD5       // D5
    #define TRISRD5     TRISDbits.TRISD5

    #define LCD_RD4     PORTDbits.RD4       // D4
    #define TRISRD4     TRISDbits.TRISD4

    #define LCD_RW      PORTEbits.RE2       // RW
    #define TRISRW      TRISEbits.TRISE2

    #define LCD_EN      PORTEbits.RE1       // EN
    #define TRISEN      TRISEbits.TRISE1

    #define LCD_RS      PORTEbits.RE0       // RS
    #define TRISRS      TRISEbits.TRISE0

#endif




void Lcd_Init(void);
void Lcd_Out(unsigned char y, unsigned char x, const char *buffer);
void Lcd_Out2(unsigned char y, unsigned char x, char *buffer);
void Lcd_Chr_CP(char data);
void Lcd_Cmd(unsigned char data);

