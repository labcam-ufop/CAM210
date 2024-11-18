
# 1 "C:\CAM210\ADC.X\itoa.c"

# 26
void itoa(unsigned int val, char* str )
{
str[0]=(val/10000)+0x30;
str[1]=((val%10000)/1000)+0x30;
str[2]=((val%1000)/100)+0x30;
str[3]=((val%100)/10)+0x30;
str[4]=(val%10)+0x30;
str[5]=0;
}
