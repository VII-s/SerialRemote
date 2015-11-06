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


 

namespace SerialRemote
{
    public partial class Form_SerialRemote : Form
    {
        //命令码定义
        const byte THRO = 0x00;
        const byte PITCH = 0x01;
        const byte ROLL = 0x02;
        const byte YAW = 0x03;
        const byte AUX1 = 0x04;
        const byte AUX2 = 0x05;
        const byte UNLOCK = 0xaa;
        const byte LOCK = 0xbb;
        const byte STOP = 0xcc;

        public SerialPort serialPort;

        public Form_SerialRemote()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗口加载事件，串口及波特率加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_SerialRemote_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            string[] baudrate = { "4800", "9600", "19200", "38400", "115200" };
            Array.Sort(ports);
            comboBox_Serial.Items.AddRange(ports);
            comboBox_BaudRate.Items.AddRange(baudrate);
            comboBox_BaudRate.SelectedIndex = 4;

        }
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenSerial_Click(object sender, EventArgs e)
        {
            if (comboBox_Serial.Text == "")
            {
                richTextBox_Message.AppendText("没有找到串口！\n");
                return;
            }
            if (button_OpenSerial.Text == "打开串口")
            {
                serialPort.PortName = comboBox_Serial.Text;
                serialPort.BaudRate = int.Parse(comboBox_BaudRate.Text);
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                try
                {
                    serialPort.Open();
                }
                catch (Exception Ex)
                {
                    richTextBox_Message.AppendText(Ex.ToString());
                }
                if (serialPort.IsOpen)
                {
                    richTextBox_Message.AppendText("串口打开成功\n");
                    button_OpenSerial.Text = "关闭串口";
                }
            }
            else
            {
                serialPort.Close();
                button_OpenSerial.Text = "打开串口";
                richTextBox_Message.AppendText("串口关闭\n");
            }
        }

        /// <summary>
        /// 串口发送数据
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="data"></param>
        private void senddata(byte cmd, int data)
        {
            byte[] remote = { 0xdb, 0xbd, 0x00, 0x00, 0x00, 0x00, 0x55, 0xaa };
            byte[] buff = BitConverter.GetBytes(data);
            remote[3] = cmd;
            remote[4] = buff[0];
            remote[5] = buff[1];
            System.Threading.Thread.Sleep(10);
            serialPort.Write(remote, 0, remote.Length);
        }

        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Unlock_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(UNLOCK, 0);
                senddata(THRO, 1000);
                senddata(PITCH, 1500);
                senddata(ROLL, 1500);
                senddata(YAW, 1500);
                trackBar_Thro.Value = 1000;
                trackBar_Pitch.Value = 1500;
                trackBar_Roll.Value = 1500;
                trackBar_Yaw.Value = 1500;
                button_Aux1_Low.BackColor = Control.DefaultBackColor;
                button_Aux1_Mid.BackColor = Control.DefaultBackColor;
                button_Aux1_High.BackColor = Color.Coral;
            }
        }

        /// <summary>
        /// 锁定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Lock_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(LOCK, 0);
                button_Aux1_Low.BackColor = Color.Coral;
                button_Aux1_Mid.BackColor = Control.DefaultBackColor;
                button_Aux1_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 紧急停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                trackBar_Thro.Value = 1000;
                senddata(STOP, 0);
                button_Aux1_Low.BackColor = Color.Coral;
                button_Aux1_Mid.BackColor = Control.DefaultBackColor;
                button_Aux1_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 通道1置低
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux1_Low_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX1, 1000);
                button_Aux1_Low.BackColor = Color.Coral;
                button_Aux1_Mid.BackColor = Control.DefaultBackColor;
                button_Aux1_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 通道1置中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux1_Mid_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX1, 1500);
                button_Aux1_Low.BackColor = Control.DefaultBackColor;
                button_Aux1_Mid.BackColor = Color.Coral;
                button_Aux1_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 通道1置高
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux1_High_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX1, 2000);
                button_Aux1_Low.BackColor = Control.DefaultBackColor;
                button_Aux1_Mid.BackColor = Control.DefaultBackColor;
                button_Aux1_High.BackColor = Color.Coral;
            }
        }

        /// <summary>
        /// 通道2置低
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux2_Low_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX2, 1000);
                button_Aux2_Low.BackColor = Color.Coral;
                button_Aux2_Mid.BackColor = Control.DefaultBackColor;
                button_Aux2_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 通道2置中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux2_Mid_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX2, 1500);
                button_Aux2_Low.BackColor = Control.DefaultBackColor;
                button_Aux2_Mid.BackColor = Color.Coral;
                button_Aux2_High.BackColor = Control.DefaultBackColor;
            }
        }

        /// <summary>
        /// 通道2置高
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aux2_High_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(AUX2, 2000);
                button_Aux2_Low.BackColor = Control.DefaultBackColor;
                button_Aux2_Mid.BackColor = Control.DefaultBackColor;
                button_Aux2_High.BackColor = Color.Coral;
            }
        }

        /// <summary>
        /// 油门改变时发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Thro_Scroll(object sender, EventArgs e)
        {
            textBox_Thro.Text = trackBar_Thro.Value.ToString();
            if (serialPort.IsOpen)
            {
                senddata(THRO, trackBar_Thro.Value);
            }
        }

        /// <summary>
        /// 油门框改变时赋值滑动条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Thro_KeyDown(object sender, KeyEventArgs e)
        {
            int thro;
            if (e.KeyCode == Keys.Enter)
            {
                thro = constrain(textBox_Thro.Text);
                if (thro != 0)
                {
                    trackBar_Thro.Value = thro;
                }
            }            
        }

        private int constrain(string stringValue)
        {
            int remoteValue;
            try
            {
                remoteValue = int.Parse(stringValue);
            }
            catch (Exception)
            {
                return 0;
            }
            if (remoteValue < 1000)
            {
                return 1000;
            }
            else if (remoteValue > 2000)
            {
                return 0;
            }
            else
            {
                return remoteValue;
            }
        }

        private void trackBar_Pitch_Scroll(object sender, EventArgs e)
        {
            textBox_Pitch.Text = trackBar_Pitch.Value.ToString();
            if (serialPort.IsOpen)
            {
                senddata(PITCH, trackBar_Pitch.Value);
            }
        }

        private void trackBar_Roll_Scroll(object sender, EventArgs e)
        {
            textBox_Roll.Text = trackBar_Roll.Value.ToString();
            if (serialPort.IsOpen)
            {
                senddata(ROLL, trackBar_Roll.Value);
            }
        }

        private void trackBar_Yaw_Scroll(object sender, EventArgs e)
        {
            textBox_Yaw.Text = trackBar_Yaw.Value.ToString();
            if (serialPort.IsOpen)
            {
                senddata(YAW, trackBar_Yaw.Value);
            }
        }

        private void textBox_Pitch_KeyDown(object sender, KeyEventArgs e)
        {
            int pitch;
            if (e.KeyCode == Keys.Enter)
            {
                pitch = constrain(textBox_Pitch.Text);
                if (pitch != 0)
                {
                    trackBar_Pitch.Value = pitch;
                }
            } 
        }

        private void textBox_Roll_KeyDown(object sender, KeyEventArgs e)
        {
            int roll;
            if (e.KeyCode == Keys.Enter)
            {
                roll = constrain(textBox_Roll.Text);
                if (roll != 0)
                {
                    trackBar_Roll.Value = roll;
                }
            }
        }

        private void textBox_Yaw_KeyDown(object sender, KeyEventArgs e)
        {
            int yaw;
            if (e.KeyCode == Keys.Enter)
            {
                yaw = constrain(textBox_Yaw.Text);
                if (yaw != 0)
                {
                    trackBar_Yaw.Value = yaw;
                }
            }
        }

        private void Form_SerialRemote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                senddata(STOP, 0);
                serialPort.Close();
            }
        }

    }
}
