namespace ModbusForInventor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BAUD_RATE = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TIME_OUT = new System.Windows.Forms.TextBox();
            this.STOP_BITS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PARITY = new System.Windows.Forms.ComboBox();
            this.PORTS_NAMES = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_OPEN_CLOSE_PORT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBF = new System.Windows.Forms.CheckBox();
            this.KNN = new System.Windows.Forms.CheckBox();
            this.NONE = new System.Windows.Forms.CheckBox();
            this.RESTORE = new System.Windows.Forms.CheckBox();
            this.SAVE = new System.Windows.Forms.CheckBox();
            this.RECO = new System.Windows.Forms.CheckBox();
            this.LEARN = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.STRING = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NEURONS = new System.Windows.Forms.TextBox();
            this.CATEGORY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AIF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.S1 = new System.Windows.Forms.TextBox();
            this.S2 = new System.Windows.Forms.TextBox();
            this.S3 = new System.Windows.Forms.TextBox();
            this.S4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DATA_TIME_BTN = new System.Windows.Forms.Button();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BAUD_RATE
            // 
            this.BAUD_RATE.FormattingEnabled = true;
            this.BAUD_RATE.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BAUD_RATE.Location = new System.Drawing.Point(122, 19);
            this.BAUD_RATE.Name = "BAUD_RATE";
            this.BAUD_RATE.Size = new System.Drawing.Size(59, 21);
            this.BAUD_RATE.TabIndex = 0;
            this.BAUD_RATE.Text = "9600";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "ЗАКРЫТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TIME_OUT);
            this.groupBox1.Controls.Add(this.STOP_BITS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PARITY);
            this.groupBox1.Controls.Add(this.PORTS_NAMES);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BUTTON_OPEN_CLOSE_PORT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BAUD_RATE);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка COM-порта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Time Out";
            // 
            // TIME_OUT
            // 
            this.TIME_OUT.Location = new System.Drawing.Point(122, 124);
            this.TIME_OUT.Name = "TIME_OUT";
            this.TIME_OUT.Size = new System.Drawing.Size(59, 20);
            this.TIME_OUT.TabIndex = 38;
            this.TIME_OUT.Text = "500";
            this.TIME_OUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STOP_BITS
            // 
            this.STOP_BITS.FormattingEnabled = true;
            this.STOP_BITS.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.STOP_BITS.Location = new System.Drawing.Point(122, 97);
            this.STOP_BITS.Name = "STOP_BITS";
            this.STOP_BITS.Size = new System.Drawing.Size(59, 21);
            this.STOP_BITS.TabIndex = 14;
            this.STOP_BITS.Text = "Two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Стоп-бит";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Контроль четности";
            // 
            // PARITY
            // 
            this.PARITY.FormattingEnabled = true;
            this.PARITY.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.PARITY.Location = new System.Drawing.Point(122, 73);
            this.PARITY.Name = "PARITY";
            this.PARITY.Size = new System.Drawing.Size(59, 21);
            this.PARITY.TabIndex = 13;
            this.PARITY.Text = "None";
            // 
            // PORTS_NAMES
            // 
            this.PORTS_NAMES.FormattingEnabled = true;
            this.PORTS_NAMES.Location = new System.Drawing.Point(122, 46);
            this.PORTS_NAMES.Name = "PORTS_NAMES";
            this.PORTS_NAMES.Size = new System.Drawing.Size(59, 21);
            this.PORTS_NAMES.TabIndex = 3;
            this.PORTS_NAMES.Text = "NO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "GET PORTS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "СОМ-порт";
            // 
            // BUTTON_OPEN_CLOSE_PORT
            // 
            this.BUTTON_OPEN_CLOSE_PORT.Location = new System.Drawing.Point(9, 220);
            this.BUTTON_OPEN_CLOSE_PORT.Name = "BUTTON_OPEN_CLOSE_PORT";
            this.BUTTON_OPEN_CLOSE_PORT.Size = new System.Drawing.Size(175, 23);
            this.BUTTON_OPEN_CLOSE_PORT.TabIndex = 3;
            this.BUTTON_OPEN_CLOSE_PORT.Text = "OPEN PORT";
            this.BUTTON_OPEN_CLOSE_PORT.UseVisualStyleBackColor = true;
            this.BUTTON_OPEN_CLOSE_PORT.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скорость обмена";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBF);
            this.groupBox2.Controls.Add(this.KNN);
            this.groupBox2.Controls.Add(this.NONE);
            this.groupBox2.Controls.Add(this.RESTORE);
            this.groupBox2.Controls.Add(this.SAVE);
            this.groupBox2.Controls.Add(this.RECO);
            this.groupBox2.Controls.Add(this.LEARN);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(225, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // RBF
            // 
            this.RBF.AutoSize = true;
            this.RBF.Location = new System.Drawing.Point(65, 64);
            this.RBF.Name = "RBF";
            this.RBF.Size = new System.Drawing.Size(47, 17);
            this.RBF.TabIndex = 7;
            this.RBF.Text = "RBF";
            this.RBF.UseVisualStyleBackColor = true;
            this.RBF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RBF_MouseClick);
            // 
            // KNN
            // 
            this.KNN.AutoSize = true;
            this.KNN.Checked = true;
            this.KNN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KNN.Location = new System.Drawing.Point(7, 64);
            this.KNN.Name = "KNN";
            this.KNN.Size = new System.Drawing.Size(49, 17);
            this.KNN.TabIndex = 6;
            this.KNN.Text = "KNN";
            this.KNN.UseVisualStyleBackColor = true;
            this.KNN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KNN_MouseClick);
            // 
            // NONE
            // 
            this.NONE.AutoSize = true;
            this.NONE.Checked = true;
            this.NONE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NONE.Location = new System.Drawing.Point(274, 29);
            this.NONE.Name = "NONE";
            this.NONE.Size = new System.Drawing.Size(52, 17);
            this.NONE.TabIndex = 5;
            this.NONE.Text = "None";
            this.NONE.UseVisualStyleBackColor = true;
            this.NONE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NONE_MouseClick);
            // 
            // RESTORE
            // 
            this.RESTORE.AutoSize = true;
            this.RESTORE.Location = new System.Drawing.Point(205, 29);
            this.RESTORE.Name = "RESTORE";
            this.RESTORE.Size = new System.Drawing.Size(63, 17);
            this.RESTORE.TabIndex = 4;
            this.RESTORE.Text = "Restore";
            this.RESTORE.UseVisualStyleBackColor = true;
            this.RESTORE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RESTORE_MouseClick);
            // 
            // SAVE
            // 
            this.SAVE.AutoSize = true;
            this.SAVE.Location = new System.Drawing.Point(148, 29);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(51, 17);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SAVE_MouseClick);
            // 
            // RECO
            // 
            this.RECO.AutoSize = true;
            this.RECO.Location = new System.Drawing.Point(65, 29);
            this.RECO.Name = "RECO";
            this.RECO.Size = new System.Drawing.Size(77, 17);
            this.RECO.TabIndex = 2;
            this.RECO.Text = "Recognize";
            this.RECO.UseVisualStyleBackColor = true;
            this.RECO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RECO_MouseClick);
            // 
            // LEARN
            // 
            this.LEARN.AutoSize = true;
            this.LEARN.Location = new System.Drawing.Point(6, 29);
            this.LEARN.Name = "LEARN";
            this.LEARN.Size = new System.Drawing.Size(53, 17);
            this.LEARN.TabIndex = 1;
            this.LEARN.Text = "Learn";
            this.LEARN.UseVisualStyleBackColor = true;
            this.LEARN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LEARN_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "СТАРТ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // STRING
            // 
            this.STRING.Location = new System.Drawing.Point(232, 117);
            this.STRING.Name = "STRING";
            this.STRING.Size = new System.Drawing.Size(682, 20);
            this.STRING.TabIndex = 13;
            this.STRING.Text = "String";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "LOOK FOR...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "SubString";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.comboBox1.Location = new System.Drawing.Point(244, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "32";
            // 
            // NEURONS
            // 
            this.NEURONS.ForeColor = System.Drawing.Color.Red;
            this.NEURONS.Location = new System.Drawing.Point(35, 70);
            this.NEURONS.Name = "NEURONS";
            this.NEURONS.ReadOnly = true;
            this.NEURONS.Size = new System.Drawing.Size(56, 20);
            this.NEURONS.TabIndex = 18;
            this.NEURONS.Text = "None";
            this.NEURONS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CATEGORY
            // 
            this.CATEGORY.Location = new System.Drawing.Point(113, 70);
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.Size = new System.Drawing.Size(46, 20);
            this.CATEGORY.TabIndex = 19;
            this.CATEGORY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Committed \r\nNeurons";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AIF
            // 
            this.AIF.Location = new System.Drawing.Point(181, 70);
            this.AIF.Name = "AIF";
            this.AIF.Size = new System.Drawing.Size(36, 20);
            this.AIF.TabIndex = 21;
            this.AIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = " AIF ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Chars \r\nper neuron";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "Using\r\nneurons";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(7, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 48);
            this.button6.TabIndex = 26;
            this.button6.Text = "LEARN";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(225, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 77);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Learn box";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 29;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Char in \r\nstring";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.AIF);
            this.groupBox4.Controls.Add(this.NEURONS);
            this.groupBox4.Controls.Add(this.CATEGORY);
            this.groupBox4.Location = new System.Drawing.Point(225, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 96);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Look for box";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(234, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 26);
            this.label11.TabIndex = 31;
            this.label11.Text = "Char in \r\nsubstring";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(234, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 24);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // S1
            // 
            this.S1.Location = new System.Drawing.Point(567, 156);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(348, 20);
            this.S1.TabIndex = 30;
            // 
            // S2
            // 
            this.S2.Location = new System.Drawing.Point(567, 182);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(348, 20);
            this.S2.TabIndex = 31;
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(567, 208);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(348, 20);
            this.S3.TabIndex = 32;
            // 
            // S4
            // 
            this.S4.Location = new System.Drawing.Point(566, 234);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(349, 20);
            this.S4.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "What we send to neurons";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DATA_TIME_BTN
            // 
            this.DATA_TIME_BTN.Location = new System.Drawing.Point(21, 280);
            this.DATA_TIME_BTN.Name = "DATA_TIME_BTN";
            this.DATA_TIME_BTN.Size = new System.Drawing.Size(172, 36);
            this.DATA_TIME_BTN.TabIndex = 35;
            this.DATA_TIME_BTN.Text = "Синхронизировать \r\nвремя";
            this.DATA_TIME_BTN.UseVisualStyleBackColor = true;
            this.DATA_TIME_BTN.Click += new System.EventHandler(this.DATA_TIME_BTN_Click);
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CLEAR_BTN.Location = new System.Drawing.Point(6, 23);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(75, 40);
            this.CLEAR_BTN.TabIndex = 36;
            this.CLEAR_BTN.Text = "Clear \r\nneurons";
            this.CLEAR_BTN.UseVisualStyleBackColor = false;
            this.CLEAR_BTN.Click += new System.EventHandler(this.CLEAR_BTN_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.CLEAR_BTN);
            this.groupBox5.Location = new System.Drawing.Point(567, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 87);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 38;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 37;
            this.button8.Text = "Committed \r\nneurons";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 19);
            this.toolStripStatusLabel3.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(926, 388);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DATA_TIME_BTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.STRING);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "ECO System - Data Mining test form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox BAUD_RATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUTTON_OPEN_CLOSE_PORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox PORTS_NAMES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PARITY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox STOP_BITS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox STRING;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox RESTORE;
        private System.Windows.Forms.CheckBox SAVE;
        private System.Windows.Forms.CheckBox RECO;
        private System.Windows.Forms.CheckBox LEARN;
        private System.Windows.Forms.CheckBox NONE;
        private System.Windows.Forms.CheckBox RBF;
        private System.Windows.Forms.CheckBox KNN;
        private System.Windows.Forms.TextBox NEURONS;
        private System.Windows.Forms.TextBox CATEGORY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AIF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox S1;
        private System.Windows.Forms.TextBox S2;
        private System.Windows.Forms.TextBox S3;
        private System.Windows.Forms.TextBox S4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DATA_TIME_BTN;
        private System.Windows.Forms.Button CLEAR_BTN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TIME_OUT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

