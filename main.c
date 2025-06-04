/*
 * Embedded_Project.c
 *
 * Created: 6/03/2025 10:36:48 am
 * Author : bkz4176
 */ 

#define F_CPU 8000000UL

#define Pot_1 0b01100010
#define Pot_2 0b01100001
#define read_temp 0b01100011
#define read_light 0b01100000


#include <avr/io.h>
#include <avr/interrupt.h>

void setup(void);

char *byte = 0;
char state = 0;
char instruction = 0;
char LSByte = 0;
char MSByte = 0;
char sixteenbitint = 0;
char messageready = 0;

ISR(USART1_RX_vect)
{
	*byte = UDR1;
	
	switch(state)
	{
		case 0:
			if(*byte == 0x53)
			{
				state = 1;
			}
		break;
		
		case 1:
			instruction = *byte;
			if(instruction > 0x05)
			{
				state = 2;
			}
			else
			{
				state = 4;
			}
		break;
		
		case 2:
			LSByte = *byte;
			state = 3;
		break;
		
		case 3:
			MSByte = *byte;
			sixteenbitint = (MSByte << 8) | LSByte;
			state = 4;
		break;
		
		case 4:
			if(*byte == 0xAA)
			{
				messageready = 1;
			}
			state = 0;
		break;
		
	}
}

int main(void)
{
	setup();
    while (1) 
    {
		
		if(messageready == 1)
		{
			if(instruction == 0x01) // send LED data from MCU to PC
			{
				UDR1 = PINA; // DATA SENT THROUGH UDR1
				messageready = 0;
			}
			if(instruction == 0x02) // send POT1 data to PC
			{
				ADMUX = Pot_1;
				UDR1 = ADCH; // DATA SENT THROUGH UDR1
				messageready = 0;
			}
			if(instruction == 0x03) //send POT2 data to PC
			{
				ADMUX = Pot_2;
				UDR1 = ADCH; // DATA SENT THROUGH UDR1
				messageready = 0;
			}
			if(instruction == 0x04) // send temp data to PC
			{
				ADMUX = read_temp;
				UDR1 = ADCH; // DATA SENT THROUGH UDR1
				messageready = 0;
			}
			if(instruction == 0x05) // send light data to PC
			{
				ADMUX = read_light;
				UDR1 = ADCH; // DATA SENT THROUGH UDR1
				messageready = 0;
			}			
			
			if(instruction == 0x0A) // set LED (WORKING)
			{
				PORTC = LSByte;
				UDR1 = PINA;
				messageready = 0;
			}
			if(instruction == 0x0B) // set heater (WORKING)
			{
				OCR1C = sixteenbitint;
				UDR1 = 0x0B;
				messageready = 0;
			}
			if(instruction == 0x0C) // set light (WORKING)
			{
				OCR1B = sixteenbitint;
				UDR1 = 0x0C;
				messageready = 0;
			}
			if(instruction == 0x0D) // set motor (WORKING)
			{
				OCR1A = sixteenbitint;
				UDR1 = 0x0D;
				messageready = 0;
			}
			messageready = 0;
		}
    }
}

void setup(void)
{
	DDRA = 0x00; // set PinA for input 
	DDRC = 0xFF; // set port C for output
	DDRE = 0x03; // Multiplexer
	PORTE = 0x00;
	PORTC = 0x00;
	DDRB = 0b11100000; // Set bit 5,6 and 7 of PortB to output
	
	cli(); //Clear interrupts
	sei(); //Set interrupts
	UCSR1B = 0b10011000; //Turn on USART Transmitter and receiver, enable receive complete interrupt
	UCSR1C = 0b00000110; // Asynchronous operation, no parity bit, 1 stop bit, 8-bit character size.
	UBRR1L = 12; //Set baud rate to 38400;
	
	ADCSRA = 0b11100111; // Non free running conversion
	
	TCCR1A = 0b10101010; //Fast PWM, CTC
	TCCR1B = 0b00011001; // Fast PWM, 8 pre scaler
	ICR1 = 399; //Top number for 20kHz setting
}

// Real term instructions: set baud rate to match MCU, parity none, data bits = 8, stop bits = 1, port VCPO, click open
