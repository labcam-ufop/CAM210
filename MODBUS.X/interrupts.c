/******************************************************************************/
/*Files to Include                                                            */
/******************************************************************************/

#include <p18cxxx.h>    /* C18 General Include File */
#include "user.h"
#include "modbus.h"
#include "system.h"

/******************************************************************************/
/* Global Variables                                                           */
/******************************************************************************/

/******************************************************************************/
/* Interrupt Routines                                                         */
/******************************************************************************/

//// start ISR code
//#pragma code isr = 0x08 // store the below code at address 0x08
//#pragma interrupt isr   // let the compiler know that the function isr() is int


//#pragma code // return to the default code section
