
# 1 "display7s.c"

# 35
unsigned char display7s(unsigned char v)
{
switch(v)
{
case 0:
return 0x3F;
case 1:
return 0x06;
case 2:
return 0x5B;
case 3:
return 0x4F;
case 4:
return 0x66;
case 5:
return 0x6D;
case 6:
return 0x7D;
case 7:
return 0x07;
case 8:
return 0x7F;
case 9:
return 0x6F;
case 10:
return 0x77;
case 11:
return 0x7c;
case 12:
return 0x58;
case 13:
return 0x5E;
case 14:
return 0x79;
case 15:
return 0x71;
default:
return 0;
}
}

