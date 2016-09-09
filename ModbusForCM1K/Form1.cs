using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace ModbusForInventor
{
    /*struct TimeBuffer
    {
        public byte addr;
        public byte kop;
        public byte first_reg;
        public byte amount_reg;
        public byte minute;
        public byte hour;
        public byte date;
        public byte month;
        public byte crc_low;
        public byte crc_high;
    } */
        
    public partial class Form1 : Form
    {
        uint PortOpenFlag = 0, StartModeFlag = 0;
        static byte[] RxBuffer = new byte[Modbus.SIZE_RX_BUFFER];
        static byte[] TxBuffer = new byte[Modbus.SIZE_TX_BUFFER];
        static byte[] Vector = new byte[256];
        string WhatLookFor = " ";
        int LengthSubString = 0;
        string StringOut = " ";
        int LengthString = 0;
        //TimeBuffer tbuffer;

    private void Wait(double seconds)
    {
        int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
        while (System.Environment.TickCount < ticks)
        {
          Application.DoEvents();
        }
    }
        public Form1()
        {
            InitializeComponent();
        }

        // Делегат используется для записи в UI control из потока не-UI
        //private delegate void SetTextDeleg(string text);

        /*void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            string data = serialPort1.ReadLine();
            // Привлечение делегата на потоке UI, и отправка данных, которые
            // были приняты привлеченным методом.
            // ---- Метод "si_DataReceived" будет выполнен в потоке UI,
            // который позволит заполнить текстовое поле TextBox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived),
                             new object[] { data });
        }
        */
        private void si_DataReceived(string data)
        {
            STRING.Text = data.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Если порт закрыт - открываем
            if (PortOpenFlag == 0)
            {
                serialPort1.BaudRate = Convert.ToInt32(BAUD_RATE.Text);
                serialPort1.PortName = PORTS_NAMES.Text;
                // Для приема данных создаем обработчик события EventHandler для "SerialDataReceivedEventHandler"
                // "sp_DataReceived" является вручную созданным методом (подпрограммой)
                //serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                switch(PARITY.Text)
                {
                    case "Mark":
                        serialPort1.Parity = Parity.Mark;
                        break;
                    case "Space":
                        serialPort1.Parity = Parity.Space;
                        break;
                    case "Even":
                        serialPort1.Parity = Parity.Even;
                    break;
                    case "Odd":
                        serialPort1.Parity = Parity.Odd;
                    break;
                    default:
                        serialPort1.Parity = Parity.None;
                    break;             
                }
                switch (STOP_BITS.Text)
                {
                    case "None":
                        serialPort1.StopBits = StopBits.None;
                    break;
                    case "One":
                        serialPort1.StopBits = StopBits.One;
                    break;
                    case "Two":
                        serialPort1.StopBits = StopBits.Two;
                    break;
                    case "OmePointFive":
                        serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                    default:
                    serialPort1.StopBits = StopBits.Two;
                    break;
                }
                if (PORTS_NAMES.Text == "NO")
                {
                    MessageBox.Show("Не найдено ни одного COM-порта !", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen == true)
                    {
                        PortOpenFlag = 1;
                        BUTTON_OPEN_CLOSE_PORT.Text = "CLOSE_PORT";
                    }
                }
                catch //(Exception ex)
                {
                    MessageBox.Show("Не могу открыть COM-порт !", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Если порт открыт - закрываем
            else
            {
                serialPort1.Close();
                PortOpenFlag = 0;
                StartModeFlag = 0;
                button2.Text = "СТАРТ";
                BUTTON_OPEN_CLOSE_PORT.Text = "OPEN_PORT";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uint ports_number = 0;
            // Get a list of serial port names.
            //string[] ports = SerialPort.GetPortNames();
            PORTS_NAMES.Items.Clear();
            //Выполняем проход по массиву имен последовательных портов для текущего компьютера
            //которые возвращает функция SerialPort.GetPortNames()
            foreach (string port in SerialPort.GetPortNames()) 
            { 
                //Если порт существует, то добавляем его в ComboBox
                PORTS_NAMES.Items.Add(port);
                ports_number++;
            }
            if (ports_number > 0)
            {
                PORTS_NAMES.Text = PORTS_NAMES.Items[0].ToString();//"YES";
            }
            else
            {
                PORTS_NAMES.Text = "NO";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (StartModeFlag == 0)
            {
                if (PortOpenFlag == 0)
                {
                    MessageBox.Show("Нет открытого COM-порта !", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StartModeFlag = 1;
                button2.Text = "СТОП";
                timer1.Enabled = true;
            }
            else
            {
                StartModeFlag = 0;
                button2.Text = "СТАРТ";
                timer1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*uint temp = 0;

            TxBuffer[0] = Convert.ToByte(TX_BYTE0.Text,16);
            TxBuffer[1] = Convert.ToByte(TX_BYTE1.Text, 16);
            TxBuffer[2] = Convert.ToByte(TX_BYTE2.Text, 16);
            TxBuffer[3] = Convert.ToByte(TX_BYTE3.Text, 16);
            TxBuffer[4] = Convert.ToByte(TX_BYTE4.Text, 16);
            TxBuffer[5] = Convert.ToByte(TX_BYTE5.Text, 16);
            temp = Modbus.CRC16(TxBuffer, Modbus.SIZE_TX_FRAME);
            TxBuffer[6] = (byte)(temp >> 8);
            TxBuffer[7] = (byte)(temp);
            TX_BYTE6.Text = Convert.ToString(TxBuffer[6],16);
            TX_BYTE7.Text = Convert.ToString(TxBuffer[7], 16);*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*if (StartModeFlag == 1)
            {
                TxBuffer[0] = 1;
                TxBuffer[1] = 6;

                serialPort1.Write(TxBuffer, 0, 8);
            }*/
            WhatLookFor = " ";
            WhatLookFor = textBox1.Text;
            LengthSubString = WhatLookFor.Length;
            textBox3.Text = LengthSubString.ToString();

        }

        private void LEARN_MouseClick(object sender, MouseEventArgs e)
        {
            LEARN.Checked = true;
            RECO.Checked = false;
            SAVE.Checked = false;
            RESTORE.Checked = false;
            NONE.Checked = false;
            NEURONS.Text = "None";
            NEURONS.Enabled = false;
        }

        private void RECO_MouseClick(object sender, MouseEventArgs e)
        {
            LEARN.Checked = false;
            RECO.Checked = true;
            SAVE.Checked = false;
            RESTORE.Checked = false;
            NONE.Checked = false;
            NEURONS.Text = "None";
            NEURONS.Enabled = true;
        }

        private void SAVE_MouseClick(object sender, MouseEventArgs e)
        {
            LEARN.Checked = false;
            RECO.Checked = false;
            SAVE.Checked = true;
            RESTORE.Checked = false;
            NONE.Checked = false;
            NEURONS.Enabled = false;
        }

        private void RESTORE_MouseClick(object sender, MouseEventArgs e)
        {
            LEARN.Checked = false;
            RECO.Checked = false;
            SAVE.Checked = false;
            RESTORE.Checked = true;
            NONE.Checked = false;
            NEURONS.Enabled = false;
        }

        private void KNN_MouseClick(object sender, MouseEventArgs e)
        {
            KNN.Checked = true;
            RBF.Checked = false;
        }

        private void RBF_MouseClick(object sender, MouseEventArgs e)
        {
            KNN.Checked = false;
            RBF.Checked = true;
        }

        private void NONE_MouseClick(object sender, MouseEventArgs e)
        {
            LEARN.Checked = false;
            RECO.Checked = false;
            SAVE.Checked = false;
            RESTORE.Checked = false;
            NONE.Checked = true;
            NEURONS.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Lime;//.FromName("Lime");
            int x = 0;
            int TempLength = 0, n_neurons = 0;

            for (x = 0; x < Modbus.SIZE_TX_BUFFER; x++)
            {
                TxBuffer[x] = 0;
            }
            S1.Text = ""; S2.Text = ""; S3.Text = ""; S4.Text = "";
            STRING.Text = "I study how work with Cognimem CM1K. I need to do this work as fast as possible. We will do it!";
            StringOut = STRING.Text;
            LengthString = StringOut.Length;// Определяем длину тестовой строки
            textBox2.Text = "";
            textBox4.Text = LengthString.ToString();
            LengthSubString = Convert.ToInt16(comboBox1.Text);
            
            // Передаем перключить в режим SR
            // Передаем RESETCHAIN
            while (StringOut.Length != 0)
            {
                //
                if (StringOut.Length <= LengthSubString)
                {
                    TempLength = StringOut.Length;
                }
                else
                {
                    for (x = LengthSubString; x > 0; x--)
                    {
                        string temp = StringOut.Substring(x, 1);
                        if (temp == " ") 
                            break;
                    }
                    TempLength = x;
                }
                // Переносим в массив значащие символы
                for (x = 0; x < TempLength; x++)
                {
                    string xx = StringOut.Substring(x, 1);
                    byte Sumbol = (byte) xx[0];
                    Vector[x] = Convert.ToByte(Sumbol);
                }
                // Обнуляем "лишние" элементы массива
                for (x = TempLength; x < LengthSubString; x++)
                    Vector[x] = 0x00;
                // Обучение
                // Передача компонентов вектора
                n_neurons++;
                
                if (n_neurons == 1)
                {
                   string tempstring = Encoding.ASCII.GetString(Vector);
                   S1.Text = tempstring;//
                }
                 else if (n_neurons == 2)
                    S2.Text = Encoding.ASCII.GetString(Vector);//
                else if (n_neurons == 3)
                    S3.Text = Encoding.ASCII.GetString(Vector);// 
                else if (n_neurons == 4)
                    S4.Text = Encoding.ASCII.GetString(Vector);//

                int templength = StringOut.Length - TempLength - 1;
                if (templength > 0)
                {
                    StringOut = StringOut.Substring(TempLength + 1, templength);
                }
                else
                {
                    StringOut = "";
                }
                x = 0;
            }   // End while
            textBox2.Text = n_neurons.ToString();
            Wait(3.0);
            button6.BackColor = Color.FromName("AppWorkspace");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = DateTime.Today.ToLongDateString();
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd-MM-yy");
            //DateTime.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void DATA_TIME_BTN_Click(object sender, EventArgs e)
        {
            byte[] Buffer = new byte[19];
            // Готовим пакет с текущим временем
            Buffer[0] = Modbus.NODE_ADDRESS;
            Buffer[1] = Modbus.WRITE_REGISTERS;
            // Адрес первого регистра
            Buffer[2] = Modbus.CLOCK_REGISTER_MASK;
            Buffer[3] = 0x00;
            // Количество регистров для записи
            Buffer[4] = 0x06;
            // Регистр секунд
            Buffer[5] = 0x00;
            Buffer[6] = (byte)DateTime.Now.Second;
            Buffer[7] = 0x00;
            Buffer[8] = (byte)DateTime.Now.Minute;
            Buffer[9] = 0x00;
            Buffer[10] = (byte)DateTime.Now.Hour;
            Buffer[11] = 0x00;
            Buffer[12] = (byte)DateTime.Now.Day;
            Buffer[13] = 0x00;
            Buffer[14] = (byte)DateTime.Now.Month;
            Buffer[15] = 0x00;
            Buffer[16] = (byte)(DateTime.Now.Year - ((DateTime.Now.Year / 1000) * 1000));
            // Вычисляем контрольную сумму
            uint crc = Modbus.CRC16(Buffer, (uint)Buffer.Length);
            Buffer[17] = (byte)(crc);
            Buffer[18] = (byte)(crc >> 8);
            // Пытаемся отправить пакет    
            try
            {
               serialPort1.Write(Buffer, 0, Buffer.Length);
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                MessageBox.Show("Error writing to serial port - " + ex.Message, "Error!");
                return;
            }
            for (byte x = 0; x < Buffer.Length; x++)
            {
                Buffer[x] = 0;
            }
            serialPort1.ReadTimeout = Convert.ToInt32(TIME_OUT.Text);
            Wait(10);
            // Проверяем, есть ли пакет
            try
            {
                int sss = serialPort1.Read(Buffer, 0, Buffer.Length);
                if (Buffer[0] == 0)
                    toolStripStatusLabel3.Text = "Time no updated!";
                else
                    toolStripStatusLabel3.Text = "Time updated!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to serial port - " + ex.Message, "Error!");
                return;
            }
            
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            CLEAR_BTN.BackColor = Color.FromName("Orange");
            CM1K rrr = new CM1K();
            rrr.TextChanger = this.ChangeText;
            rrr.ClearNeurons();
            Wait(3.0);
            CLEAR_BTN.BackColor = Color.FromName("AppWorkspace");
        }

        public void ChangeText(string text)
        {
            this.textBox5.Text = text;
        }
    }
}
