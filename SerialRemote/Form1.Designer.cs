namespace SerialRemote
{
    partial class Form_SerialRemote
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialRemote));
            this.button_OpenSerial = new System.Windows.Forms.Button();
            this.comboBox_Serial = new System.Windows.Forms.ComboBox();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.button_Unlock = new System.Windows.Forms.Button();
            this.label_Serial = new System.Windows.Forms.Label();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.groupBox_Serial = new System.Windows.Forms.GroupBox();
            this.groupBox_Aux = new System.Windows.Forms.GroupBox();
            this.button_Aux2_High = new System.Windows.Forms.Button();
            this.button_Aux2_Mid = new System.Windows.Forms.Button();
            this.button_Aux1_High = new System.Windows.Forms.Button();
            this.button_Aux2_Low = new System.Windows.Forms.Button();
            this.button_Aux1_Mid = new System.Windows.Forms.Button();
            this.label_Aux2 = new System.Windows.Forms.Label();
            this.button_Aux1_Low = new System.Windows.Forms.Button();
            this.label_Aux1 = new System.Windows.Forms.Label();
            this.button_Lock = new System.Windows.Forms.Button();
            this.groupBox_Message = new System.Windows.Forms.GroupBox();
            this.groupBox_Remote = new System.Windows.Forms.GroupBox();
            this.trackBar_Roll = new System.Windows.Forms.TrackBar();
            this.trackBar_Thro = new System.Windows.Forms.TrackBar();
            this.trackBar_Pitch = new System.Windows.Forms.TrackBar();
            this.trackBar_Yaw = new System.Windows.Forms.TrackBar();
            this.label_Yaw = new System.Windows.Forms.Label();
            this.label_Roll = new System.Windows.Forms.Label();
            this.label_Pitch = new System.Windows.Forms.Label();
            this.textBox_Yaw = new System.Windows.Forms.TextBox();
            this.textBox_Roll = new System.Windows.Forms.TextBox();
            this.textBox_Pitch = new System.Windows.Forms.TextBox();
            this.label_Thro = new System.Windows.Forms.Label();
            this.textBox_Thro = new System.Windows.Forms.TextBox();
            this.groupBox_Serial.SuspendLayout();
            this.groupBox_Aux.SuspendLayout();
            this.groupBox_Message.SuspendLayout();
            this.groupBox_Remote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Thro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OpenSerial
            // 
            this.button_OpenSerial.Location = new System.Drawing.Point(7, 122);
            this.button_OpenSerial.Margin = new System.Windows.Forms.Padding(4);
            this.button_OpenSerial.Name = "button_OpenSerial";
            this.button_OpenSerial.Size = new System.Drawing.Size(232, 38);
            this.button_OpenSerial.TabIndex = 1;
            this.button_OpenSerial.Text = "打开串口";
            this.button_OpenSerial.UseVisualStyleBackColor = true;
            this.button_OpenSerial.Click += new System.EventHandler(this.button_OpenSerial_Click);
            // 
            // comboBox_Serial
            // 
            this.comboBox_Serial.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Serial.FormattingEnabled = true;
            this.comboBox_Serial.Location = new System.Drawing.Point(7, 42);
            this.comboBox_Serial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Serial.Name = "comboBox_Serial";
            this.comboBox_Serial.Size = new System.Drawing.Size(232, 24);
            this.comboBox_Serial.TabIndex = 4;
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.Location = new System.Drawing.Point(7, 21);
            this.richTextBox_Message.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.Size = new System.Drawing.Size(242, 242);
            this.richTextBox_Message.TabIndex = 5;
            this.richTextBox_Message.Text = "";
            // 
            // button_Unlock
            // 
            this.button_Unlock.Location = new System.Drawing.Point(19, 186);
            this.button_Unlock.Margin = new System.Windows.Forms.Padding(4);
            this.button_Unlock.Name = "button_Unlock";
            this.button_Unlock.Size = new System.Drawing.Size(108, 31);
            this.button_Unlock.TabIndex = 6;
            this.button_Unlock.Text = "解锁";
            this.button_Unlock.UseVisualStyleBackColor = true;
            this.button_Unlock.Click += new System.EventHandler(this.button_Unlock_Click);
            // 
            // label_Serial
            // 
            this.label_Serial.AutoSize = true;
            this.label_Serial.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Serial.Location = new System.Drawing.Point(7, 23);
            this.label_Serial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Serial.Name = "label_Serial";
            this.label_Serial.Size = new System.Drawing.Size(64, 16);
            this.label_Serial.TabIndex = 10;
            this.label_Serial.Text = "串  口:";
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_BaudRate.Location = new System.Drawing.Point(7, 71);
            this.label_BaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(64, 16);
            this.label_BaudRate.TabIndex = 11;
            this.label_BaudRate.Text = "波特率:";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(7, 90);
            this.comboBox_BaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(232, 24);
            this.comboBox_BaudRate.TabIndex = 4;
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.Red;
            this.button_Stop.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Location = new System.Drawing.Point(16, 225);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(232, 39);
            this.button_Stop.TabIndex = 12;
            this.button_Stop.Text = "紧急停止";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // groupBox_Serial
            // 
            this.groupBox_Serial.Controls.Add(this.comboBox_Serial);
            this.groupBox_Serial.Controls.Add(this.button_OpenSerial);
            this.groupBox_Serial.Controls.Add(this.label_BaudRate);
            this.groupBox_Serial.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_Serial.Controls.Add(this.label_Serial);
            this.groupBox_Serial.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Serial.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Serial.Name = "groupBox_Serial";
            this.groupBox_Serial.Size = new System.Drawing.Size(256, 167);
            this.groupBox_Serial.TabIndex = 13;
            this.groupBox_Serial.TabStop = false;
            this.groupBox_Serial.Text = "串口";
            // 
            // groupBox_Aux
            // 
            this.groupBox_Aux.Controls.Add(this.button_Aux2_High);
            this.groupBox_Aux.Controls.Add(this.button_Aux2_Mid);
            this.groupBox_Aux.Controls.Add(this.button_Aux1_High);
            this.groupBox_Aux.Controls.Add(this.button_Aux2_Low);
            this.groupBox_Aux.Controls.Add(this.button_Aux1_Mid);
            this.groupBox_Aux.Controls.Add(this.label_Aux2);
            this.groupBox_Aux.Controls.Add(this.button_Aux1_Low);
            this.groupBox_Aux.Controls.Add(this.label_Aux1);
            this.groupBox_Aux.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Aux.Location = new System.Drawing.Point(12, 271);
            this.groupBox_Aux.Name = "groupBox_Aux";
            this.groupBox_Aux.Size = new System.Drawing.Size(256, 127);
            this.groupBox_Aux.TabIndex = 14;
            this.groupBox_Aux.TabStop = false;
            this.groupBox_Aux.Text = "通道";
            // 
            // button_Aux2_High
            // 
            this.button_Aux2_High.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux2_High.Location = new System.Drawing.Point(199, 70);
            this.button_Aux2_High.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux2_High.Name = "button_Aux2_High";
            this.button_Aux2_High.Size = new System.Drawing.Size(36, 36);
            this.button_Aux2_High.TabIndex = 12;
            this.button_Aux2_High.Text = "H";
            this.button_Aux2_High.UseVisualStyleBackColor = true;
            this.button_Aux2_High.Click += new System.EventHandler(this.button_Aux2_High_Click);
            // 
            // button_Aux2_Mid
            // 
            this.button_Aux2_Mid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux2_Mid.Location = new System.Drawing.Point(134, 70);
            this.button_Aux2_Mid.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux2_Mid.Name = "button_Aux2_Mid";
            this.button_Aux2_Mid.Size = new System.Drawing.Size(36, 36);
            this.button_Aux2_Mid.TabIndex = 11;
            this.button_Aux2_Mid.Text = "M";
            this.button_Aux2_Mid.UseVisualStyleBackColor = true;
            this.button_Aux2_Mid.Click += new System.EventHandler(this.button_Aux2_Mid_Click);
            // 
            // button_Aux1_High
            // 
            this.button_Aux1_High.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux1_High.Location = new System.Drawing.Point(199, 26);
            this.button_Aux1_High.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux1_High.Name = "button_Aux1_High";
            this.button_Aux1_High.Size = new System.Drawing.Size(36, 36);
            this.button_Aux1_High.TabIndex = 12;
            this.button_Aux1_High.Text = "H";
            this.button_Aux1_High.UseVisualStyleBackColor = true;
            this.button_Aux1_High.Click += new System.EventHandler(this.button_Aux1_High_Click);
            // 
            // button_Aux2_Low
            // 
            this.button_Aux2_Low.BackColor = System.Drawing.Color.Coral;
            this.button_Aux2_Low.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux2_Low.Location = new System.Drawing.Point(69, 70);
            this.button_Aux2_Low.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux2_Low.Name = "button_Aux2_Low";
            this.button_Aux2_Low.Size = new System.Drawing.Size(36, 36);
            this.button_Aux2_Low.TabIndex = 10;
            this.button_Aux2_Low.Text = "L";
            this.button_Aux2_Low.UseVisualStyleBackColor = false;
            this.button_Aux2_Low.Click += new System.EventHandler(this.button_Aux2_Low_Click);
            // 
            // button_Aux1_Mid
            // 
            this.button_Aux1_Mid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux1_Mid.Location = new System.Drawing.Point(134, 26);
            this.button_Aux1_Mid.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux1_Mid.Name = "button_Aux1_Mid";
            this.button_Aux1_Mid.Size = new System.Drawing.Size(36, 36);
            this.button_Aux1_Mid.TabIndex = 11;
            this.button_Aux1_Mid.Text = "M";
            this.button_Aux1_Mid.UseVisualStyleBackColor = false;
            this.button_Aux1_Mid.Click += new System.EventHandler(this.button_Aux1_Mid_Click);
            // 
            // label_Aux2
            // 
            this.label_Aux2.AutoSize = true;
            this.label_Aux2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Aux2.Location = new System.Drawing.Point(6, 78);
            this.label_Aux2.Name = "label_Aux2";
            this.label_Aux2.Size = new System.Drawing.Size(56, 16);
            this.label_Aux2.TabIndex = 0;
            this.label_Aux2.Text = "通道2:";
            // 
            // button_Aux1_Low
            // 
            this.button_Aux1_Low.BackColor = System.Drawing.Color.Coral;
            this.button_Aux1_Low.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Aux1_Low.Location = new System.Drawing.Point(69, 26);
            this.button_Aux1_Low.Margin = new System.Windows.Forms.Padding(4);
            this.button_Aux1_Low.Name = "button_Aux1_Low";
            this.button_Aux1_Low.Size = new System.Drawing.Size(36, 36);
            this.button_Aux1_Low.TabIndex = 10;
            this.button_Aux1_Low.Text = "L";
            this.button_Aux1_Low.UseVisualStyleBackColor = false;
            this.button_Aux1_Low.Click += new System.EventHandler(this.button_Aux1_Low_Click);
            // 
            // label_Aux1
            // 
            this.label_Aux1.AutoSize = true;
            this.label_Aux1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Aux1.Location = new System.Drawing.Point(6, 34);
            this.label_Aux1.Name = "label_Aux1";
            this.label_Aux1.Size = new System.Drawing.Size(56, 16);
            this.label_Aux1.TabIndex = 0;
            this.label_Aux1.Text = "通道1:";
            // 
            // button_Lock
            // 
            this.button_Lock.Location = new System.Drawing.Point(143, 186);
            this.button_Lock.Margin = new System.Windows.Forms.Padding(4);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(108, 31);
            this.button_Lock.TabIndex = 6;
            this.button_Lock.Text = "锁定";
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.button_Lock_Click);
            // 
            // groupBox_Message
            // 
            this.groupBox_Message.Controls.Add(this.richTextBox_Message);
            this.groupBox_Message.Location = new System.Drawing.Point(12, 404);
            this.groupBox_Message.Name = "groupBox_Message";
            this.groupBox_Message.Size = new System.Drawing.Size(256, 272);
            this.groupBox_Message.TabIndex = 15;
            this.groupBox_Message.TabStop = false;
            this.groupBox_Message.Text = "消息";
            // 
            // groupBox_Remote
            // 
            this.groupBox_Remote.Controls.Add(this.trackBar_Roll);
            this.groupBox_Remote.Controls.Add(this.trackBar_Thro);
            this.groupBox_Remote.Controls.Add(this.trackBar_Pitch);
            this.groupBox_Remote.Controls.Add(this.trackBar_Yaw);
            this.groupBox_Remote.Controls.Add(this.label_Yaw);
            this.groupBox_Remote.Controls.Add(this.label_Roll);
            this.groupBox_Remote.Controls.Add(this.label_Pitch);
            this.groupBox_Remote.Controls.Add(this.textBox_Yaw);
            this.groupBox_Remote.Controls.Add(this.textBox_Roll);
            this.groupBox_Remote.Controls.Add(this.textBox_Pitch);
            this.groupBox_Remote.Controls.Add(this.label_Thro);
            this.groupBox_Remote.Controls.Add(this.textBox_Thro);
            this.groupBox_Remote.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Remote.Location = new System.Drawing.Point(274, 12);
            this.groupBox_Remote.Name = "groupBox_Remote";
            this.groupBox_Remote.Size = new System.Drawing.Size(311, 664);
            this.groupBox_Remote.TabIndex = 16;
            this.groupBox_Remote.TabStop = false;
            this.groupBox_Remote.Text = "遥控";
            // 
            // trackBar_Roll
            // 
            this.trackBar_Roll.Location = new System.Drawing.Point(166, 21);
            this.trackBar_Roll.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Roll.Maximum = 2000;
            this.trackBar_Roll.Minimum = 1000;
            this.trackBar_Roll.Name = "trackBar_Roll";
            this.trackBar_Roll.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Roll.Size = new System.Drawing.Size(45, 582);
            this.trackBar_Roll.TabIndex = 11;
            this.trackBar_Roll.TickFrequency = 10;
            this.trackBar_Roll.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Roll.Value = 1500;
            this.trackBar_Roll.ValueChanged += new System.EventHandler(this.trackBar_Roll_Scroll);
            // 
            // trackBar_Thro
            // 
            this.trackBar_Thro.Location = new System.Drawing.Point(14, 21);
            this.trackBar_Thro.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Thro.Maximum = 2000;
            this.trackBar_Thro.Minimum = 1000;
            this.trackBar_Thro.Name = "trackBar_Thro";
            this.trackBar_Thro.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Thro.Size = new System.Drawing.Size(45, 582);
            this.trackBar_Thro.TabIndex = 10;
            this.trackBar_Thro.TickFrequency = 10;
            this.trackBar_Thro.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Thro.Value = 1000;
            this.trackBar_Thro.ValueChanged += new System.EventHandler(this.trackBar_Thro_Scroll);
            // 
            // trackBar_Pitch
            // 
            this.trackBar_Pitch.Location = new System.Drawing.Point(90, 21);
            this.trackBar_Pitch.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Pitch.Maximum = 2000;
            this.trackBar_Pitch.Minimum = 1000;
            this.trackBar_Pitch.Name = "trackBar_Pitch";
            this.trackBar_Pitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Pitch.Size = new System.Drawing.Size(45, 582);
            this.trackBar_Pitch.TabIndex = 12;
            this.trackBar_Pitch.TickFrequency = 10;
            this.trackBar_Pitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Pitch.Value = 1500;
            this.trackBar_Pitch.ValueChanged += new System.EventHandler(this.trackBar_Pitch_Scroll);
            // 
            // trackBar_Yaw
            // 
            this.trackBar_Yaw.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_Yaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Yaw.Location = new System.Drawing.Point(242, 21);
            this.trackBar_Yaw.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Yaw.Maximum = 2000;
            this.trackBar_Yaw.Minimum = 1000;
            this.trackBar_Yaw.Name = "trackBar_Yaw";
            this.trackBar_Yaw.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Yaw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_Yaw.Size = new System.Drawing.Size(45, 582);
            this.trackBar_Yaw.TabIndex = 13;
            this.trackBar_Yaw.TickFrequency = 10;
            this.trackBar_Yaw.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Yaw.Value = 1500;
            this.trackBar_Yaw.ValueChanged += new System.EventHandler(this.trackBar_Yaw_Scroll);
            // 
            // label_Yaw
            // 
            this.label_Yaw.AutoSize = true;
            this.label_Yaw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Yaw.Location = new System.Drawing.Point(247, 609);
            this.label_Yaw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Yaw.Name = "label_Yaw";
            this.label_Yaw.Size = new System.Drawing.Size(40, 16);
            this.label_Yaw.TabIndex = 9;
            this.label_Yaw.Text = "方向";
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Roll.Location = new System.Drawing.Point(171, 609);
            this.label_Roll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(40, 16);
            this.label_Roll.TabIndex = 9;
            this.label_Roll.Text = "副翼";
            // 
            // label_Pitch
            // 
            this.label_Pitch.AutoSize = true;
            this.label_Pitch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Pitch.Location = new System.Drawing.Point(95, 609);
            this.label_Pitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pitch.Name = "label_Pitch";
            this.label_Pitch.Size = new System.Drawing.Size(40, 16);
            this.label_Pitch.TabIndex = 9;
            this.label_Pitch.Text = "俯仰";
            // 
            // textBox_Yaw
            // 
            this.textBox_Yaw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Yaw.Location = new System.Drawing.Point(238, 629);
            this.textBox_Yaw.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Yaw.Name = "textBox_Yaw";
            this.textBox_Yaw.Size = new System.Drawing.Size(59, 26);
            this.textBox_Yaw.TabIndex = 8;
            this.textBox_Yaw.Text = "1500";
            this.textBox_Yaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Yaw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Yaw_KeyDown);
            // 
            // textBox_Roll
            // 
            this.textBox_Roll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Roll.Location = new System.Drawing.Point(162, 629);
            this.textBox_Roll.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Roll.Name = "textBox_Roll";
            this.textBox_Roll.Size = new System.Drawing.Size(59, 26);
            this.textBox_Roll.TabIndex = 8;
            this.textBox_Roll.Text = "1500";
            this.textBox_Roll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Roll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Roll_KeyDown);
            // 
            // textBox_Pitch
            // 
            this.textBox_Pitch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Pitch.Location = new System.Drawing.Point(86, 629);
            this.textBox_Pitch.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Pitch.Name = "textBox_Pitch";
            this.textBox_Pitch.Size = new System.Drawing.Size(59, 26);
            this.textBox_Pitch.TabIndex = 8;
            this.textBox_Pitch.Text = "1500";
            this.textBox_Pitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Pitch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pitch_KeyDown);
            // 
            // label_Thro
            // 
            this.label_Thro.AutoSize = true;
            this.label_Thro.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Thro.Location = new System.Drawing.Point(19, 609);
            this.label_Thro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Thro.Name = "label_Thro";
            this.label_Thro.Size = new System.Drawing.Size(40, 16);
            this.label_Thro.TabIndex = 6;
            this.label_Thro.Text = "油门";
            // 
            // textBox_Thro
            // 
            this.textBox_Thro.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Thro.Location = new System.Drawing.Point(10, 629);
            this.textBox_Thro.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Thro.Name = "textBox_Thro";
            this.textBox_Thro.Size = new System.Drawing.Size(59, 26);
            this.textBox_Thro.TabIndex = 5;
            this.textBox_Thro.Text = "1000";
            this.textBox_Thro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Thro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Thro_KeyDown);
            // 
            // Form_SerialRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 684);
            this.Controls.Add(this.groupBox_Remote);
            this.Controls.Add(this.groupBox_Message);
            this.Controls.Add(this.groupBox_Aux);
            this.Controls.Add(this.groupBox_Serial);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Lock);
            this.Controls.Add(this.button_Unlock);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_SerialRemote";
            this.Text = "串口遥控";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerialRemote_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerialRemote_Load);
            this.groupBox_Serial.ResumeLayout(false);
            this.groupBox_Serial.PerformLayout();
            this.groupBox_Aux.ResumeLayout(false);
            this.groupBox_Aux.PerformLayout();
            this.groupBox_Message.ResumeLayout(false);
            this.groupBox_Remote.ResumeLayout(false);
            this.groupBox_Remote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Thro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenSerial;
        private System.Windows.Forms.ComboBox comboBox_Serial;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.Button button_Unlock;
        private System.Windows.Forms.Label label_Serial;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.GroupBox groupBox_Serial;
        private System.Windows.Forms.GroupBox groupBox_Aux;
        private System.Windows.Forms.Button button_Aux1_High;
        private System.Windows.Forms.Button button_Aux1_Mid;
        private System.Windows.Forms.Button button_Aux1_Low;
        private System.Windows.Forms.Label label_Aux1;
        private System.Windows.Forms.Button button_Aux2_High;
        private System.Windows.Forms.Button button_Aux2_Mid;
        private System.Windows.Forms.Button button_Aux2_Low;
        private System.Windows.Forms.Label label_Aux2;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.GroupBox groupBox_Message;
        private System.Windows.Forms.GroupBox groupBox_Remote;
        private System.Windows.Forms.Label label_Yaw;
        private System.Windows.Forms.Label label_Roll;
        private System.Windows.Forms.Label label_Pitch;
        private System.Windows.Forms.TextBox textBox_Yaw;
        private System.Windows.Forms.TextBox textBox_Roll;
        private System.Windows.Forms.TextBox textBox_Pitch;
        private System.Windows.Forms.Label label_Thro;
        private System.Windows.Forms.TextBox textBox_Thro;
        private System.Windows.Forms.TrackBar trackBar_Roll;
        private System.Windows.Forms.TrackBar trackBar_Thro;
        private System.Windows.Forms.TrackBar trackBar_Pitch;
        private System.Windows.Forms.TrackBar trackBar_Yaw;
    }
}

