using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class AppBoard
    {
        private SerialPort serialPort;
        private readonly object serialLock = new object();
        private string hexValue;
        private float potValue1;
        private float potValue2;
        private float lightValue;
        private float actualTemp;

        public AppBoard()
        {
            serialPort = new SerialPort();

        }
        public SerialPort GetSerialPort()
        {
            return serialPort;
        }

        public string[] getComPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void setComPort(string portName)
        {
            serialPort.PortName = portName;
        }

        public void setBauderate(Int32 baudRate)
        {
            serialPort.BaudRate = baudRate;
        }
        public void Connect()
        {
            int counter = 0;
            if (counter == 0)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            try
            {
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.Open();
                counter++;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Disconnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void sendData(string data) // Takes a string of data, 
        {
            lock (serialLock)
            {
                serialPort.DiscardOutBuffer(); // clear buffer
                while (serialPort.BytesToWrite > 0); // wait until buffer is clear
                if (serialPort.BytesToWrite == 0)
                {
                    byte[] byteArray = ConvertHexStringToByteArray(data); // convert data to byte array
                    serialPort.Write(byteArray, 0, byteArray.Length); // write byte array to serial port
                }
                serialPort.DiscardOutBuffer();
            }
  
        }

        private byte[] ConvertHexStringToByteArray(string hexString)
        {
            try
            {
                int numberChars = hexString.Length;
                byte[] bytes = new byte[numberChars / 2];
                // Extract each pair of characters from the string and convert to byte
                for (int i = 0; i < numberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
                }
                return bytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting hex string to byte array: {ex.Message}");
                return new byte[0]; // Return empty byte array in case of error
            }
        }

        public void readPINA() // read PINA data (switches)
        {
            try
            {
                string readPinaA = "5301AA";
                serialPort.DiscardInBuffer();
                sendData(readPinaA);
                while (serialPort.BytesToRead == 0);
                if (serialPort.BytesToRead > 0)
                {
                    byte receivedByte = (byte)serialPort.ReadByte();
                    hexValue = receivedByte.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public string getHexValue()
        {
            return hexValue;
        }

        public void readPot_Light(int num)
        {
            lock(serialLock)
            {
                try
                {
                    serialPort.DiscardInBuffer();
                    while (serialPort.BytesToRead > 0);
                    string command = num == 1 ?  "5303AA" : num == 2 ? "5302AA" : "5305AA"; // if pot number == 1 then send 5302AA(Pot1)
                                                                                            // else if == 2 send 5303AA(Pot2) else send 5305AA(Lamp)
                    sendData(command);
                    while(serialPort.BytesToRead == 0);       
                    byte receivedByte = (byte)serialPort.ReadByte();
                    if (num == 1)
                    {
                        potValue1 = receivedByte;
                    }
                    else if (num == 2)
                    {
                        lightValue = receivedByte; // when num == 2 potValue2 should be assigned to the received byte. I had to flip
                        //lightValue and PotValue2 else the data was getting mixed up.unsure why this was the case
                    }
                    else
                    {
                        potValue2 = receivedByte; // when num == 3 lightValue should be assigned to the received byte. I had to flip 
                        //lightValue and PotValue2 else the data was getting mixed up.unsure why this was the case
                    }
                    serialPort.DiscardInBuffer();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            
        }

        private void readTemp() // Read value from the heater
        {
            lock (serialLock)
            {
                try
                {
                    string command = "5304AA";
                    serialPort.DiscardInBuffer();
                    sendData(command);
                    while (serialPort.BytesToRead == 0) ;
                    if (serialPort.BytesToRead > 0)
                    {
                        byte receivedByte = (byte)serialPort.ReadByte();
                        actualTemp = receivedByte;
                    }
                    serialPort.DiscardInBuffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            
        }

        public float getPotValue(int potNumber) // gettter for PotValue1 and potValue2
        {
            return (potNumber == 1 ? potValue1 : potValue2) / 51f; // if pot number == 1 then send return potValue 1 else retrun potValue 2
                                                                    // divide by 51 to convert to a voltage
        }

        public float getLightValue() // getter for light Value
        {
            return lightValue;
        }

        public float getTempValue() // getter for tempValue
        {
            readTemp();
            return (float)Math.Round((actualTemp / 51) * 14, 2); // convert to degrees celcius. two decimal places.
        }
    }
}