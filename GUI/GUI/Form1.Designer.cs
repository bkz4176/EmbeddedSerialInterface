using System.Windows.Forms;
using System;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SetupConnect = new System.Windows.Forms.Button();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.appTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.dataBaseDisconnect = new System.Windows.Forms.Button();
            this.dataBaseConnect = new System.Windows.Forms.Button();
            this.dataBaseLED = new Bulb.LedBulb();
            this.databaseText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.serverNameBox = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.ledBulbSetup = new Bulb.LedBulb();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ledBulb1 = new Bulb.LedBulb();
            this.ledBulb2 = new Bulb.LedBulb();
            this.ledBulb3 = new Bulb.LedBulb();
            this.ledBulb4 = new Bulb.LedBulb();
            this.ledBulb5 = new Bulb.LedBulb();
            this.ledBulb6 = new Bulb.LedBulb();
            this.ledBulb7 = new Bulb.LedBulb();
            this.ledBulb0 = new Bulb.LedBulb();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.sevenSegmentMSB = new DmitryBrant.CustomControls.SevenSegment();
            this.sevenSegmentLSB = new DmitryBrant.CustomControls.SevenSegment();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LightGauge = new AquaControls.AquaGauge();
            this.Light_Percent = new System.Windows.Forms.TextBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.Pot1 = new AquaControls.AquaGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.Pot2 = new AquaControls.AquaGauge();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.enableDataLog = new System.Windows.Forms.Button();
            this.stopDataLog = new System.Windows.Forms.Button();
            this.AutoDataStatus = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.manualDataLog = new System.Windows.Forms.Button();
            this.mannualLogText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SetTemp = new System.Windows.Forms.NumericUpDown();
            this.KiBox = new System.Windows.Forms.NumericUpDown();
            this.KpBox = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MotorSpeed = new System.Windows.Forms.TextBox();
            this.ActualTemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.appTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SetupConnect
            // 
            this.SetupConnect.Location = new System.Drawing.Point(14, 122);
            this.SetupConnect.Name = "SetupConnect";
            this.SetupConnect.Size = new System.Drawing.Size(121, 23);
            this.SetupConnect.TabIndex = 0;
            this.SetupConnect.Text = "Connect";
            this.SetupConnect.UseVisualStyleBackColor = true;
            this.SetupConnect.Click += new System.EventHandler(this.ConnectCLick);
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(97, 49);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCom.TabIndex = 1;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DisplayMember = "(none)";
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(97, 79);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaud.TabIndex = 2;
            this.comboBoxBaud.Text = "38400";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "COM Port";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 13);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Baudrate";
            // 
            // appTabs
            // 
            this.appTabs.Controls.Add(this.tabPage1);
            this.appTabs.Controls.Add(this.tabPage2);
            this.appTabs.Controls.Add(this.tabPage3);
            this.appTabs.Controls.Add(this.tabPage4);
            this.appTabs.Location = new System.Drawing.Point(3, 1);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(501, 566);
            this.appTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.dataBaseDisconnect);
            this.panel2.Controls.Add(this.dataBaseConnect);
            this.panel2.Controls.Add(this.dataBaseLED);
            this.panel2.Controls.Add(this.databaseText);
            this.panel2.Controls.Add(this.passwordText);
            this.panel2.Controls.Add(this.userNameText);
            this.panel2.Controls.Add(this.serverNameBox);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(53, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 243);
            this.panel2.TabIndex = 7;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(9, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(169, 13);
            this.textBox20.TabIndex = 13;
            this.textBox20.Text = "Database Server Connection";
            // 
            // dataBaseDisconnect
            // 
            this.dataBaseDisconnect.Location = new System.Drawing.Point(195, 161);
            this.dataBaseDisconnect.Name = "dataBaseDisconnect";
            this.dataBaseDisconnect.Size = new System.Drawing.Size(121, 23);
            this.dataBaseDisconnect.TabIndex = 12;
            this.dataBaseDisconnect.Text = "DataBase Disconnect";
            this.dataBaseDisconnect.UseVisualStyleBackColor = true;
            this.dataBaseDisconnect.Click += new System.EventHandler(this.dataBaseDisconnect_Click);
            // 
            // dataBaseConnect
            // 
            this.dataBaseConnect.Location = new System.Drawing.Point(14, 161);
            this.dataBaseConnect.Name = "dataBaseConnect";
            this.dataBaseConnect.Size = new System.Drawing.Size(121, 23);
            this.dataBaseConnect.TabIndex = 11;
            this.dataBaseConnect.Text = "DataBase Connect";
            this.dataBaseConnect.UseVisualStyleBackColor = true;
            this.dataBaseConnect.Click += new System.EventHandler(this.dataBaseConnect_Click);
            // 
            // dataBaseLED
            // 
            this.dataBaseLED.Color = System.Drawing.Color.Red;
            this.dataBaseLED.Location = new System.Drawing.Point(227, 200);
            this.dataBaseLED.Name = "dataBaseLED";
            this.dataBaseLED.On = true;
            this.dataBaseLED.Size = new System.Drawing.Size(75, 23);
            this.dataBaseLED.TabIndex = 10;
            this.dataBaseLED.Text = "ledBulb8";
            // 
            // databaseText
            // 
            this.databaseText.Location = new System.Drawing.Point(120, 118);
            this.databaseText.Name = "databaseText";
            this.databaseText.Size = new System.Drawing.Size(120, 20);
            this.databaseText.TabIndex = 9;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(120, 92);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(120, 20);
            this.passwordText.TabIndex = 8;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(119, 66);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(120, 20);
            this.userNameText.TabIndex = 7;
            // 
            // serverNameBox
            // 
            this.serverNameBox.FormattingEnabled = true;
            this.serverNameBox.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.serverNameBox.Location = new System.Drawing.Point(119, 41);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(121, 21);
            this.serverNameBox.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(9, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 13);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "UserName";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(9, 92);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 13);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "Password";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(9, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 13);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "Database";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(14, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 13);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Database Server Connection Status";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(9, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Server Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.Disconnect);
            this.panel1.Controls.Add(this.ledBulbSetup);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.comboBoxCom);
            this.panel1.Controls.Add(this.SetupConnect);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBoxBaud);
            this.panel1.Location = new System.Drawing.Point(53, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 208);
            this.panel1.TabIndex = 6;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(9, 3);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(141, 13);
            this.textBox19.TabIndex = 8;
            this.textBox19.Text = "Serial Port Connection";
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(195, 122);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(121, 23);
            this.Disconnect.TabIndex = 7;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // ledBulbSetup
            // 
            this.ledBulbSetup.Color = System.Drawing.Color.Red;
            this.ledBulbSetup.Location = new System.Drawing.Point(227, 162);
            this.ledBulbSetup.Name = "ledBulbSetup";
            this.ledBulbSetup.On = true;
            this.ledBulbSetup.Size = new System.Drawing.Size(75, 23);
            this.ledBulbSetup.TabIndex = 6;
            this.ledBulbSetup.Text = "ledBulbSetup";
            this.ledBulbSetup.Click += new System.EventHandler(this.ledConnect);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(14, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Serial Port Status";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital I/O";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.textBox18);
            this.panel3.Controls.Add(this.textBox17);
            this.panel3.Controls.Add(this.textBox16);
            this.panel3.Controls.Add(this.textBox15);
            this.panel3.Controls.Add(this.textBox14);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.ledBulb1);
            this.panel3.Controls.Add(this.ledBulb2);
            this.panel3.Controls.Add(this.ledBulb3);
            this.panel3.Controls.Add(this.ledBulb4);
            this.panel3.Controls.Add(this.ledBulb5);
            this.panel3.Controls.Add(this.ledBulb6);
            this.panel3.Controls.Add(this.ledBulb7);
            this.panel3.Controls.Add(this.ledBulb0);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.sevenSegmentMSB);
            this.panel3.Controls.Add(this.sevenSegmentLSB);
            this.panel3.Location = new System.Drawing.Point(42, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 426);
            this.panel3.TabIndex = 2;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(191, 341);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(46, 17);
            this.checkBox8.TabIndex = 27;
            this.checkBox8.Text = "PC7";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(191, 311);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(46, 17);
            this.checkBox7.TabIndex = 26;
            this.checkBox7.Text = "PC6";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(191, 282);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(46, 17);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "PC5";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(191, 253);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(46, 17);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "PC4";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(191, 227);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(46, 17);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "PC3";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(191, 198);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "PC2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(191, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "PC1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "PC0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(95, 143);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(41, 13);
            this.textBox18.TabIndex = 19;
            this.textBox18.Text = "PA0";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(95, 173);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(41, 13);
            this.textBox17.TabIndex = 18;
            this.textBox17.Text = "PA1";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(95, 199);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(41, 13);
            this.textBox16.TabIndex = 17;
            this.textBox16.Text = "PA2";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(95, 341);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(41, 13);
            this.textBox15.TabIndex = 16;
            this.textBox15.Text = "PA7";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(95, 315);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(41, 13);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "PA6";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(95, 283);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(41, 13);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "PA5";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(95, 254);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(41, 13);
            this.textBox12.TabIndex = 13;
            this.textBox12.Text = "PA4";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(95, 228);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(41, 13);
            this.textBox11.TabIndex = 12;
            this.textBox11.Text = "PA3";
            // 
            // ledBulb1
            // 
            this.ledBulb1.Color = System.Drawing.Color.Red;
            this.ledBulb1.Location = new System.Drawing.Point(61, 163);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(75, 23);
            this.ledBulb1.TabIndex = 11;
            this.ledBulb1.Text = "ledBulb9";
            // 
            // ledBulb2
            // 
            this.ledBulb2.Color = System.Drawing.Color.Red;
            this.ledBulb2.Location = new System.Drawing.Point(61, 189);
            this.ledBulb2.Name = "ledBulb2";
            this.ledBulb2.On = true;
            this.ledBulb2.Size = new System.Drawing.Size(75, 23);
            this.ledBulb2.TabIndex = 10;
            this.ledBulb2.Text = "ledBulb8";
            // 
            // ledBulb3
            // 
            this.ledBulb3.Color = System.Drawing.Color.Red;
            this.ledBulb3.Location = new System.Drawing.Point(61, 218);
            this.ledBulb3.Name = "ledBulb3";
            this.ledBulb3.On = true;
            this.ledBulb3.Size = new System.Drawing.Size(75, 23);
            this.ledBulb3.TabIndex = 9;
            this.ledBulb3.Text = "ledBulb7";
            // 
            // ledBulb4
            // 
            this.ledBulb4.Color = System.Drawing.Color.Red;
            this.ledBulb4.Location = new System.Drawing.Point(61, 247);
            this.ledBulb4.Name = "ledBulb4";
            this.ledBulb4.On = true;
            this.ledBulb4.Size = new System.Drawing.Size(75, 23);
            this.ledBulb4.TabIndex = 8;
            this.ledBulb4.Text = "ledBulb6";
            // 
            // ledBulb5
            // 
            this.ledBulb5.Color = System.Drawing.Color.Red;
            this.ledBulb5.Location = new System.Drawing.Point(61, 276);
            this.ledBulb5.Name = "ledBulb5";
            this.ledBulb5.On = true;
            this.ledBulb5.Size = new System.Drawing.Size(75, 23);
            this.ledBulb5.TabIndex = 7;
            this.ledBulb5.Text = "ledBulb5";
            // 
            // ledBulb6
            // 
            this.ledBulb6.Color = System.Drawing.Color.Red;
            this.ledBulb6.Location = new System.Drawing.Point(61, 305);
            this.ledBulb6.Name = "ledBulb6";
            this.ledBulb6.On = true;
            this.ledBulb6.Size = new System.Drawing.Size(75, 23);
            this.ledBulb6.TabIndex = 6;
            this.ledBulb6.Text = "ledBulb4";
            // 
            // ledBulb7
            // 
            this.ledBulb7.Color = System.Drawing.Color.Red;
            this.ledBulb7.Location = new System.Drawing.Point(61, 334);
            this.ledBulb7.Name = "ledBulb7";
            this.ledBulb7.On = true;
            this.ledBulb7.Size = new System.Drawing.Size(75, 23);
            this.ledBulb7.TabIndex = 5;
            this.ledBulb7.Text = "ledBulb3";
            // 
            // ledBulb0
            // 
            this.ledBulb0.Color = System.Drawing.Color.Red;
            this.ledBulb0.Location = new System.Drawing.Point(61, 134);
            this.ledBulb0.Name = "ledBulb0";
            this.ledBulb0.On = true;
            this.ledBulb0.Size = new System.Drawing.Size(75, 23);
            this.ledBulb0.TabIndex = 4;
            this.ledBulb0.Text = "ledBulb2";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(61, 97);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(51, 13);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "PINA";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(191, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 13);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "PORTC";
            // 
            // sevenSegmentMSB
            // 
            this.sevenSegmentMSB.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentMSB.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentMSB.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentMSB.CustomPattern = 0;
            this.sevenSegmentMSB.DecimalOn = false;
            this.sevenSegmentMSB.DecimalShow = true;
            this.sevenSegmentMSB.ElementWidth = 10;
            this.sevenSegmentMSB.ItalicFactor = 0F;
            this.sevenSegmentMSB.Location = new System.Drawing.Point(291, 143);
            this.sevenSegmentMSB.Name = "sevenSegmentMSB";
            this.sevenSegmentMSB.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentMSB.Size = new System.Drawing.Size(32, 64);
            this.sevenSegmentMSB.TabIndex = 0;
            this.sevenSegmentMSB.TabStop = false;
            this.sevenSegmentMSB.Value = null;
            // 
            // sevenSegmentLSB
            // 
            this.sevenSegmentLSB.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentLSB.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentLSB.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentLSB.CustomPattern = 0;
            this.sevenSegmentLSB.DecimalOn = false;
            this.sevenSegmentLSB.DecimalShow = true;
            this.sevenSegmentLSB.ElementWidth = 10;
            this.sevenSegmentLSB.ItalicFactor = 0F;
            this.sevenSegmentLSB.Location = new System.Drawing.Point(329, 143);
            this.sevenSegmentLSB.Name = "sevenSegmentLSB";
            this.sevenSegmentLSB.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentLSB.Size = new System.Drawing.Size(32, 64);
            this.sevenSegmentLSB.TabIndex = 1;
            this.sevenSegmentLSB.TabStop = false;
            this.sevenSegmentLSB.Value = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(493, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pots-Lights";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.LightGauge);
            this.panel5.Controls.Add(this.Light_Percent);
            this.panel5.Controls.Add(this.vScrollBar);
            this.panel5.Location = new System.Drawing.Point(23, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 225);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Light";
            // 
            // LightGauge
            // 
            this.LightGauge.BackColor = System.Drawing.Color.Transparent;
            this.LightGauge.DialColor = System.Drawing.Color.Lavender;
            this.LightGauge.DialText = "Measured";
            this.LightGauge.Glossiness = 11.36364F;
            this.LightGauge.Location = new System.Drawing.Point(192, 40);
            this.LightGauge.MaxValue = 255F;
            this.LightGauge.MinValue = 0F;
            this.LightGauge.Name = "LightGauge";
            this.LightGauge.NoOfDivisions = 5;
            this.LightGauge.RecommendedValue = 0F;
            this.LightGauge.Size = new System.Drawing.Size(150, 150);
            this.LightGauge.TabIndex = 2;
            this.LightGauge.ThresholdPercent = 0F;
            this.LightGauge.Value = 0F;
            // 
            // Light_Percent
            // 
            this.Light_Percent.Location = new System.Drawing.Point(66, 181);
            this.Light_Percent.Name = "Light_Percent";
            this.Light_Percent.Size = new System.Drawing.Size(42, 20);
            this.Light_Percent.TabIndex = 6;
            // 
            // vScrollBar
            // 
            this.vScrollBar.LargeChange = 1;
            this.vScrollBar.Location = new System.Drawing.Point(13, 59);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(25, 142);
            this.vScrollBar.TabIndex = 3;
            this.vScrollBar.Value = 100;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox23);
            this.panel4.Controls.Add(this.textBox22);
            this.panel4.Controls.Add(this.Pot1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Pot2);
            this.panel4.Location = new System.Drawing.Point(20, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 225);
            this.panel4.TabIndex = 11;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(275, 39);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(100, 13);
            this.textBox23.TabIndex = 12;
            this.textBox23.Text = "Pot2 Voltage";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(46, 39);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 13);
            this.textBox22.TabIndex = 11;
            this.textBox22.Text = "Pot1 Voltage";
            // 
            // Pot1
            // 
            this.Pot1.BackColor = System.Drawing.Color.Transparent;
            this.Pot1.DialColor = System.Drawing.Color.Lavender;
            this.Pot1.DialText = "Potentiometer 1";
            this.Pot1.Glossiness = 11.36364F;
            this.Pot1.Location = new System.Drawing.Point(16, 58);
            this.Pot1.MaxValue = 5F;
            this.Pot1.MinValue = 0F;
            this.Pot1.Name = "Pot1";
            this.Pot1.RecommendedValue = 0F;
            this.Pot1.Size = new System.Drawing.Size(150, 150);
            this.Pot1.TabIndex = 0;
            this.Pot1.ThresholdPercent = 0F;
            this.Pot1.Value = 0F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pots";
            // 
            // Pot2
            // 
            this.Pot2.BackColor = System.Drawing.Color.Transparent;
            this.Pot2.DialColor = System.Drawing.Color.Lavender;
            this.Pot2.DialText = "Potentiometer 2";
            this.Pot2.Glossiness = 11.36364F;
            this.Pot2.Location = new System.Drawing.Point(238, 58);
            this.Pot2.MaxValue = 5F;
            this.Pot2.MinValue = 0F;
            this.Pot2.Name = "Pot2";
            this.Pot2.RecommendedValue = 0F;
            this.Pot2.Size = new System.Drawing.Size(150, 150);
            this.Pot2.TabIndex = 1;
            this.Pot2.ThresholdPercent = 0F;
            this.Pot2.Value = 0F;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.SetTemp);
            this.tabPage4.Controls.Add(this.KiBox);
            this.tabPage4.Controls.Add(this.KpBox);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.MotorSpeed);
            this.tabPage4.Controls.Add(this.ActualTemp);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(493, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temp Control";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(34, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 156);
            this.panel6.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.enableDataLog);
            this.panel8.Controls.Add(this.stopDataLog);
            this.panel8.Controls.Add(this.AutoDataStatus);
            this.panel8.Location = new System.Drawing.Point(194, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 123);
            this.panel8.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "Auto Data Logging";
            // 
            // enableDataLog
            // 
            this.enableDataLog.Location = new System.Drawing.Point(19, 26);
            this.enableDataLog.Name = "enableDataLog";
            this.enableDataLog.Size = new System.Drawing.Size(120, 23);
            this.enableDataLog.TabIndex = 23;
            this.enableDataLog.Text = "Enable Data Logging";
            this.enableDataLog.UseVisualStyleBackColor = true;
            this.enableDataLog.Click += new System.EventHandler(this.enableDataLog_Click);
            // 
            // stopDataLog
            // 
            this.stopDataLog.Location = new System.Drawing.Point(19, 84);
            this.stopDataLog.Name = "stopDataLog";
            this.stopDataLog.Size = new System.Drawing.Size(120, 23);
            this.stopDataLog.TabIndex = 25;
            this.stopDataLog.Text = "Stop Data Logging";
            this.stopDataLog.UseVisualStyleBackColor = true;
            this.stopDataLog.Click += new System.EventHandler(this.stopDataLog_Click);
            // 
            // AutoDataStatus
            // 
            this.AutoDataStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoDataStatus.Location = new System.Drawing.Point(19, 55);
            this.AutoDataStatus.Name = "AutoDataStatus";
            this.AutoDataStatus.Size = new System.Drawing.Size(104, 13);
            this.AutoDataStatus.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.manualDataLog);
            this.panel7.Controls.Add(this.mannualLogText);
            this.panel7.Location = new System.Drawing.Point(9, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 123);
            this.panel7.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Manual Data Logging";
            // 
            // manualDataLog
            // 
            this.manualDataLog.Location = new System.Drawing.Point(8, 84);
            this.manualDataLog.Name = "manualDataLog";
            this.manualDataLog.Size = new System.Drawing.Size(120, 23);
            this.manualDataLog.TabIndex = 21;
            this.manualDataLog.Text = "Insert Data to Table";
            this.manualDataLog.UseVisualStyleBackColor = true;
            this.manualDataLog.Click += new System.EventHandler(this.manualDataLog_Click);
            // 
            // mannualLogText
            // 
            this.mannualLogText.Location = new System.Drawing.Point(8, 34);
            this.mannualLogText.Name = "mannualLogText";
            this.mannualLogText.Size = new System.Drawing.Size(100, 20);
            this.mannualLogText.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = " Cloud Data Logging";
            // 
            // SetTemp
            // 
            this.SetTemp.Location = new System.Drawing.Point(34, 74);
            this.SetTemp.Name = "SetTemp";
            this.SetTemp.Size = new System.Drawing.Size(59, 20);
            this.SetTemp.TabIndex = 34;
            this.SetTemp.Value = new decimal(new int[] {
            300,
            0,
            0,
            65536});
            // 
            // KiBox
            // 
            this.KiBox.Location = new System.Drawing.Point(34, 156);
            this.KiBox.Name = "KiBox";
            this.KiBox.Size = new System.Drawing.Size(59, 20);
            this.KiBox.TabIndex = 33;
            this.KiBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // KpBox
            // 
            this.KpBox.Location = new System.Drawing.Point(34, 182);
            this.KpBox.Name = "KpBox";
            this.KpBox.Size = new System.Drawing.Size(59, 20);
            this.KpBox.TabIndex = 32;
            this.KpBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea2.AxisY.Title = "Temp [C]";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(140, 46);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Setpoint_Temp";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(345, 300);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // MotorSpeed
            // 
            this.MotorSpeed.Location = new System.Drawing.Point(25, 320);
            this.MotorSpeed.Name = "MotorSpeed";
            this.MotorSpeed.Size = new System.Drawing.Size(100, 20);
            this.MotorSpeed.TabIndex = 17;
            // 
            // ActualTemp
            // 
            this.ActualTemp.Location = new System.Drawing.Point(25, 268);
            this.ActualTemp.Name = "ActualTemp";
            this.ActualTemp.Size = new System.Drawing.Size(100, 20);
            this.ActualTemp.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Motor Speed [%]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Actual Temp [C]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Setpoint Temp [C]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PI Tuning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 568);
            this.Controls.Add(this.appTabs);
            this.Name = "Form1";
            this.Text = "AUT Application Board Control";
            this.appTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetupConnect;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Disconnect;
        private Bulb.LedBulb ledBulbSetup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private DmitryBrant.CustomControls.SevenSegment sevenSegmentLSB;
        private DmitryBrant.CustomControls.SevenSegment sevenSegmentMSB;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private Bulb.LedBulb ledBulb1;
        private Bulb.LedBulb ledBulb2;
        private Bulb.LedBulb ledBulb3;
        private Bulb.LedBulb ledBulb4;
        private Bulb.LedBulb ledBulb5;
        private Bulb.LedBulb ledBulb6;
        private Bulb.LedBulb ledBulb7;
        private Bulb.LedBulb ledBulb0;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel3;
        private AquaControls.AquaGauge Pot2;
        private AquaControls.AquaGauge Pot1;
        private AquaControls.AquaGauge LightGauge;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.TextBox Light_Percent;
        private System.Windows.Forms.Timer appTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MotorSpeed;
        private System.Windows.Forms.TextBox ActualTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AutoDataStatus;
        private System.Windows.Forms.Button enableDataLog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button manualDataLog;
        private System.Windows.Forms.TextBox mannualLogText;
        private System.Windows.Forms.Button stopDataLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown SetTemp;
        private System.Windows.Forms.NumericUpDown KiBox;
        private System.Windows.Forms.NumericUpDown KpBox;
        private Bulb.LedBulb dataBaseLED;
        private TextBox databaseText;
        private TextBox passwordText;
        private TextBox userNameText;
        private ComboBox serverNameBox;
        private Button dataBaseDisconnect;
        private Button dataBaseConnect;
        private TextBox textBox19;
        private TextBox textBox20;
        private Panel panel5;
        private Panel panel4;
        private TextBox textBox23;
        private TextBox textBox22;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
    }
}

