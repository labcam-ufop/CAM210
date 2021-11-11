/******************************************************************************/
/* System Level #define Macros                                                */
/******************************************************************************/

/* TODO Change all these values for your project */

/* Microcontroller MIPs (FCY) */
#define p18f4520         //either write p18f4520 or p18f8722 or your own if added.
#define SYS_FREQ         10000000L  //ONLY 10MHz confirmed working.. have a go
#define FCY              SYS_FREQ/4
#define Timer0High       0xF5 // 4MHz:0xFB, 8MHz:0xF7, 10MHz:0xF5
#define Timer0Low        0xD7 // 4MHz:0xEF, 8MHz:0xDF, 10MHz:0xD7
#define BAUD_RATE        9600
#define SlaveAddress     1 // Change this to whatever you want..
#define writeEnable      LATBbits.LATB7        //this is RO/RE
#define writeEnConf      TRISBbits.TRISB7       //to config RO/RE as output

  #define busyUsart        BusyUSART() //For 18F8722 this is Busy1USART()
  #define TransmitBuffer   TXREG //For 18F8722 this is TXREG1
  #define ReceiveBuffer    RCREG //For 18F8722 this is RXREG1


void ConfigInterrupts(void);
void ClsUSART(void);
void OpnUSART(void);
void OpenTmr0(void);

