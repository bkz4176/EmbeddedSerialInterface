This project involves the development of a Windows Forms application in C# designed to establish serial communication with the AT90USB1287 microcontroller.
The application provides a graphical user interface (GUI) that allows users to interact with and control a variety of peripherals connected to the microcontroller via the AUT AT90USB applications board.
The system enables real-time monitoring and control of the following hardware components:

•	Switches connected to PORTA (used for input sensing)
•	LEDs connected to PORTC (used for visual output indication)
•	Two potentiometers (analog inputs for variable voltage readings)
•	A lamp, motor, and heater (actuators controlled via digital or PWM signals)

Data is exchanged between the Windows Forms application and the AT90USB1287 via USART (Universal Synchronous and Asynchronous Receiver-Transmitter),
routed through a USB-to-serial bridge. The application communicates using a structured protocol to send commands and receive sensor or status data from the microcontroller.
This project effectively bridges PC-based software with embedded hardware, demonstrating practical applications of serial communication, embedded system integration,
and real-time control using C# and AVR microcontrollers.
