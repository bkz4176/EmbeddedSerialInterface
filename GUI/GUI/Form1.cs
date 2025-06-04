using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Management;

namespace GUI
{
    public partial class Form1 : Form
    {
        
        private AppBoard appbBoard;
        private EventHandler ev;
        double int_error = 0;
        MySqlConnection conn;
        string connString;
        private bool dataLog = false;

        public Form1()
        {
            InitializeComponent();
            appbBoard = new AppBoard();
            initComPorts();
            appTabs.SelectedIndexChanged += new EventHandler(AppTabs_SelectedIndexChanged);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            passwordText.PasswordChar = '*';
            AutoDataStatus.ReadOnly = true;
        }

        private void initComPorts()
        {
            comboBoxCom.Items.AddRange(appbBoard.getComPorts());
        }

        private void ConnectCLick(object sender, EventArgs e)
        {

            try
            {
                appbBoard.setComPort(comboBoxCom.Text);
                appbBoard.setBauderate(Convert.ToInt32(comboBoxBaud.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            appbBoard.Connect();

            if (appbBoard.GetSerialPort().IsOpen)
            {
                ledConnect(this, EventArgs.Empty);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            appbBoard.Disconnect();

            if (!appbBoard.GetSerialPort().IsOpen)
            {
                ledConnect(this, EventArgs.Empty);
            }
        }

        private void ledConnect(object sender, EventArgs e)
        {
            if (appbBoard.GetSerialPort().IsOpen)
            {
                ledBulbSetup.Color = Color.FromArgb(0, 255, 0); // green
            }
            else
            {
                ledBulbSetup.Color = Color.FromArgb(255, 0, 0); // red
            }
        }

        private void AppTabs_SelectedIndexChanged(object sender, EventArgs e) // send corresponding instruction byte for open tab
        {
            switch (appTabs.SelectedIndex)
            {
                case 0:
                    appTimer.Stop();
                    if (appbBoard.GetSerialPort().IsOpen)
                    {
                        HeaterOff();
                        lampOff();
                        ledOff();
                    }
                        break;
                case 1:
                    if (appbBoard.GetSerialPort().IsOpen)
                    {
                        UpdateTimerEvent(DigIO_Tick);
                    }
                    else;            
                     break;
                case 2:
                    if (appbBoard.GetSerialPort().IsOpen)
                    {
                        UpdateTimerEvent(Pot_Lamp_Tick);
                    }
                    else;       
                    break;
                case 3:
                    if (appbBoard.GetSerialPort().IsOpen)
                    {
                        UpdateTimerEvent(Temp_Tick);
                    }
                    else;
                    break;
            }
        }

        private void DigIO_Tick(object sender, EventArgs e)
        { 
            readCheckBox();
            lampOff();
            HeaterOff();
        }

        private void Pot_Lamp_Tick(object sender, EventArgs e)
        {
            HeaterOff();
            ledOff();
            UpdatePots_Light();
            Pot1.Value = appbBoard.getPotValue(1); 
            LightGauge.Value = appbBoard.getLightValue();
            Pot2.Value = appbBoard.getPotValue(2);

        }

        private void Temp_Tick(object sender, EventArgs e)
        {
            lampOff();
            ledOff();
            TempControl();
        }

        private void UpdateTimerEvent(EventHandler newev)
        {
            appTimer.Stop();
            if(ev!=null)
            {
                appTimer.Tick -= ev;
              
            }
            appTimer.Tick += newev;
            ev = newev;
            appTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(appTimer!=null)
            {
                appTimer.Stop();
            }

            if(appbBoard.GetSerialPort().IsOpen)
            {
                HeaterOff();
                lampOff();
                ledOff();
                appbBoard.Disconnect();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }// resets all MCU peripherals

        private void readCheckBox()
        {
            string dataOut;
            appbBoard.readPINA(); 
            UpdateLED();
            int binaryValue = 0;
            foreach (Control control in panel3.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        int index = int.Parse(checkBox.Name.Substring(8)) - 1;
                        binaryValue |= (1 << index);
                    }
                }
            }
            dataOut = Convert.ToString(binaryValue, 16).ToUpper(); // convert to hex number
            if (dataOut.Length % 2 != 0)
            {
                dataOut = "0" + dataOut;
            }
            update7segment(dataOut);
            appbBoard.sendData("530A" + dataOut + "00AA");

        }

        private void update7segment(string hex) // update the 7 segemnet display with the data found in read checkboxes
        {
            char msb = hex[0];
            char lsb = hex[1];
            sevenSegmentMSB.Value = msb.ToString();
            sevenSegmentLSB.Value = lsb.ToString();

        }

        private void UpdateLED() // updates the GUI lEDs based on the state of switches
        {
            int intValue;
            int.TryParse(appbBoard.getHexValue(), out intValue);

            string binaryValue = Convert.ToString(intValue, 2).PadLeft(8, '0');

            var ledBulbs = new[] { ledBulb7, ledBulb6, ledBulb5, ledBulb4, ledBulb3, ledBulb2, ledBulb1, ledBulb0 };

            for (int i = 0; i < 8; i++)
            {
                ledBulbs[i].Color = (binaryValue[i] == '1') ? Color.FromArgb(0, 255, 0) : Color.FromArgb(255, 0, 0);
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e) // takes the value of the scroll bar and dispays the value in text box
        {
            int value = vScrollBar.Maximum - vScrollBar.Value;
            Light_Percent.ReadOnly = true;
            Light_Percent.Text = value.ToString() + "%";
        }

        private void UpdatePots_Light() // Updates sends data to MCU to read the potieometers and lamp
        {
            double value = vScrollBar.Maximum - vScrollBar.Value;
            value = value * 2.55; 
            int outputValue = (int)Math.Ceiling(value);
            string hex = outputValue.ToString("X4"); // Always 4 digits
            string msb = hex.Substring(0, 2);
            string lsb = hex.Substring(2, 2);

            appbBoard.sendData("530C" + lsb + msb + "AA");
            Thread.Sleep(15);
            appbBoard.readPot_Light(1);
            appbBoard.readPot_Light(3);
            appbBoard.readPot_Light(2);

        }

        private void TempControl()
        {
            double dt = 0.05;
            appbBoard.sendData("530BFFFFAA");
            Thread.Sleep(20); // allow some time for data to be sent
            double tempValue = appbBoard.getTempValue();
            double setTemp = Convert.ToDouble(SetTemp.Text);
            double Ki = Convert.ToDouble(KiBox.Value);
            double Kp = Convert.ToDouble(KpBox.Value);
            ActualTemp.Text = tempValue.ToString("F2");
            chart1.Series[1].Points.AddXY(0, setTemp);
            chart1.Series[0].Points.AddXY(0, appbBoard.getTempValue());

            double error = tempValue - setTemp;
            int_error += error * dt;
            double controllerOutput = ((Ki) * int_error + (Kp) * error); // increase kp first then ki slowly if its not converging qucik enough

            if (controllerOutput > 100)
            {
                controllerOutput = 100;
            }
            else if (controllerOutput < 0)
            {
                controllerOutput = 0;  
            }
            controllerOutput = controllerOutput * (255.0/100.0); // Scale controller output (0-100%) 
            int outputValue = Math.Min(255, Math.Max(0, (int)Math.Round(controllerOutput)));

            string hex = outputValue.ToString("X4"); // Always 4 digits
            string msb = hex.Substring(0, 2);
            string lsb = hex.Substring(2, 2);
            appbBoard.sendData("530D" + lsb + msb + "AA");
            MotorSpeed.Text = (((double)outputValue / 255) * 100).ToString("F2") + "%";

            if(dataLog)
            {
                insertData();
            }
        }

        private void HeaterOff()
        {
            appbBoard.sendData("530B0000AA"); // command to turn heater off
            appbBoard.sendData("530D0000AA"); // command to turn motor off
            dataLog = false;
            int_error = 0;
        }

        private void lampOff()
        {
            appbBoard.sendData("530C0000AA");// command to turn lamp off
        }

        private void ledOff()
        {
            appbBoard.sendData("530A0000AA");// command to turn off all LEDs
        }
        private void dataBaseConnect_Click(object sender, EventArgs e)
        {
            //Password = Pasword1234 Username = ST123456 database = temperature_record
            
            connString = "Server=" + serverNameBox.Text + ";PORT=3306;Database=" + databaseText.Text + ";UID=" + userNameText.Text + ";Password=" + passwordText.Text + ";";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    dataBaseLED.Color = Color.FromArgb(0, 255, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataBaseDisconnect_Click(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        dataBaseLED.Color = Color.FromArgb(255, 0, 0); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void insertData()
        {
            string query;
            if (dataLog)
            {
                query = "INSERT INTO `temperature` (`timeStamp`, `temperature`, `remark`) VALUES ('" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                ActualTemp.Text + "', 'ST123456')";
            }
            else
            {
                query = "INSERT INTO `temperature` (`timeStamp`, `temperature`, `remark`) VALUES ('" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                mannualLogText.Text + "', 'ST123456')";
            }
                

            try
            {
                if(this.conn != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void manualDataLog_Click(object sender, EventArgs e)
        {
            if(this.conn!= null)
            {
                insertData();
                mannualLogText.Clear();
            }
            
        }

        private void enableDataLog_Click(object sender, EventArgs e)
        {
            if(this.conn!= null)
            {
                dataLog = true;
                AutoDataStatus.Text = "data logging in process...";
            }
        
        }

        private void stopDataLog_Click(object sender, EventArgs e)
        {
            if(this.conn!= null)
            {
                dataLog = false;
                AutoDataStatus.Text = "data logging stopped";
            }
           
        }
    }
}
