/* ########################################################################

   PICsim - PIC simulator http://sourceforge.net/projects/picsim/

   ########################################################################

   Copyright (c) : 2015  Luis Claudio Gambôa Lopes

   This program is free software; you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation; either version 2, or (at your option)
   any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program; if not, write to the Free Software
   Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

   For e-mail suggestions :  lcgamboa@yahoo.com
   ######################################################################## */

// PLACA NEXSTO NE0201


// ENTRADAS (colunas)
#define C1 PORTBbits.RB3
#define C2 PORTBbits.RB2
#define C3 PORTBbits.RB1
#define C4 PORTBbits.RB0

// SAÍDAS (linhas)
#define L1 PORTBbits.RB4 // 
#define L2 PORTBbits.RB5
#define L3 PORTBbits.RB6
#define L4 PORTBbits.RB7

unsigned char tc_tecla(); /*timeout=0 no time out*/ 
