/******************************************************************************/
/* Modbus Global Variable Declaration                                         */
/******************************************************************************/
volatile char endOfMessage,newMessage = 1;
volatile char timerCount,messageLength,modbusMessage,z = 0;
volatile unsigned char response[125]; //Enough to return all holding-r's
volatile unsigned char received[125]; //Enough to write all holding-r's 
volatile unsigned int  holdingReg[50] = {0};
volatile unsigned char coils[50]= {0};

/******************************************************************************/
/* User Level #define Macros                                                  */
/******************************************************************************/

/******************************************************************************/
/* User Function Prototypes                                                   */
/******************************************************************************/
unsigned char checkCRC(void);
void clearResponse(void);
void readReg(void);         /* I/O and Peripheral Initialization */
void readInputReg(void);
void writeReg(void);
void readCoil(void);
void readInputCoil(void);
void writeCoil(void);
void modbusDelay(void);              /* Writes to Timer0 for 1.04ms delay*/
void decodeIt(void);
unsigned int generateCRC(unsigned char);
