#define ADD_MSG_HEAD
using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace SerialCom
{
    public partial class SerialCom : Form
    {
        // usb消息定义
        public const int WM_DEVICE_CHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004;
        public const UInt32 DBT_DEVTYP_PORT = 0x00000003;
        protected struct DEV_BROADCAST_HDR
        {
            public UInt32 dbch_size;
            public UInt32 dbch_devicetype;
            public UInt32 dbch_reserved;
        }

        protected struct DEV_BROADCAST_PORT_Fixed
        {
            public uint dbcp_size;
            public uint dbcp_devicetype;
            public uint dbcp_reserved;
        }

        private delegate void WriteLogDelegate(string msg, Color col);
        SerialPort sp = new SerialPort();
        Log log = new Log(AppDomain.CurrentDomain.BaseDirectory + @"/log/Log.txt");
        bool bConnect = false;
        System.Timers.Timer CheckTimer = new System.Timers.Timer(1000);//实例化Timer类，设置间隔时间为1000毫秒；
        string ConnectCmd = "{\"cmd\":\"connect\"}";
        public SerialCom()
        {
            InitializeComponent();
        }
        void StartCheckConnect()
        {
            bConnect = false;
            SendDataToDeviceByStr(ConnectCmd);
            CheckTimer.Elapsed += new System.Timers.ElapsedEventHandler(CheckConnectTimeOut);//到达时间的时候执行事件；
            CheckTimer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            CheckTimer.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        }

        private void CheckConnectTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            if (bConnect)
            {
                Writelog("connect success", Color.Green);
                CheckTimer.Stop();
            }
            else
            {
                Writelog("connect fail so to reconnect", Color.Red);
                SendDataToDeviceByStr(ConnectCmd);
            }
        }
        private void Writelog(string msg, Color col)
        {
            if (this.richTextRecv.InvokeRequired)
            {
                WriteLogDelegate d = new WriteLogDelegate(Writelog);
                this.richTextRecv.Invoke(d, new object[] { msg, col });
            }
            else
            {
                this.richTextRecv.SelectionColor = col;
                string log = "\n" + DateTime.Now.ToString() + "    " + msg;
                this.richTextRecv.AppendText(log);
                this.richTextRecv.ScrollToCaret();
            }
        }
        private void disabledMaxandMin()
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }
        private int FindCOMIndex(string strCOM)
        {
            int iCount = this.comBoxSerialPort.Items.Count;
            int iIndex = this.comBoxSerialPort.FindString(strCOM);
            if (iIndex.Equals(-1))
            {
                this.comBoxSerialPort.Items.Add(strCOM);
            }
            else
            {
                return iIndex;
            }

            return this.comBoxSerialPort.Items.Count - 1;
        }
        private void setSerialCom()
        {
            for (int i = 0; i < 10; i++)
            {
                this.comBoxSerialPort.Items.Add("COM" + (i + 1).ToString());
            }
            this.comBoxSerialPort.SelectedIndex = 0;
        }
        private void setBaudRate()
        {
            this.comboBoxBaudRate.Items.Add("1200");
            this.comboBoxBaudRate.Items.Add("2400");
            this.comboBoxBaudRate.Items.Add("4800");
            this.comboBoxBaudRate.Items.Add("9600");
            this.comboBoxBaudRate.Items.Add("19200");
            this.comboBoxBaudRate.Items.Add("38400");
            this.comboBoxBaudRate.Items.Add("43000");
            this.comboBoxBaudRate.Items.Add("56000");
            this.comboBoxBaudRate.Items.Add("57600");
            this.comboBoxBaudRate.Items.Add("115200");
            this.comboBoxBaudRate.SelectedIndex = 9;
        }

        private void setStopBit()
        {
            this.comboBoxStopBit.Items.Add("0");
            this.comboBoxStopBit.Items.Add("1");
            this.comboBoxStopBit.Items.Add("1.5");
            this.comboBoxStopBit.Items.Add("2");
            this.comboBoxStopBit.SelectedIndex = 1;
        }

        private void setDataBit()
        {
            this.comboBoxDataBit.Items.Add("8");
            this.comboBoxDataBit.Items.Add("7");
            this.comboBoxDataBit.Items.Add("6");
            this.comboBoxDataBit.Items.Add("5");
            this.comboBoxDataBit.SelectedIndex = 0;
        }

        private void setCheckBit()
        {
            this.comboBoxCheckBit.Items.Add("无");
            this.comboBoxCheckBit.Items.Add("奇检验");
            this.comboBoxCheckBit.Items.Add("偶检验");
            this.comboBoxCheckBit.SelectedIndex = 0;
        }

        private void enableddSendByHex()
        {
            this.radioBtn16.Checked = true;
            this.radioBtnStr.Checked = false;
        }

        private void enabledSendByStr()
        {
            this.radioBtnStr.Checked = true;
            this.radioBtn16.Checked = false;
        }

        private void enabledRecvByHex()
        {
            this.radioBtnRcv16.Checked = true;
            this.radioBtnRcvStr.Checked = false;
        }

        private void enabledRecvByStr()
        {
            this.radioBtnRcv16.Checked = false;
            this.radioBtnRcvStr.Checked = true;
        }

        private void enabledOpenSerialBtn()
        {
            this.btnSwitchOpen.Enabled = true;
        }
        private void disabledOpenSerialBtn()
        {
            this.btnSwitchOpen.Enabled = false;
        }
        private void SerialCom_Load(object sender, EventArgs e)
        {
            disabledMaxandMin();
            setSerialCom();
            setBaudRate();
            setStopBit();
            setDataBit();
            setCheckBit();
            enabledSendByStr();
            enabledRecvByStr();
            enabledOpenSerialBtn();


            Control.CheckForIllegalCrossThreadCalls = false;
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            sp.DtrEnable = true;
            sp.RtsEnable = true;
            sp.ReadTimeout = 1000;
            sp.Close();

            this.radioButton_Common.Checked = true;
        }

        protected override void WndProc(ref Message m)
        {
            if(WM_DEVICE_CHANGE == m.Msg)
            {
                switch (m.WParam.ToInt32())
                {
                    case DBT_DEVICE_REMOVE_COMPLETE:
                        break;
                    case DBT_DEVICEARRIVAL:
                        DEV_BROADCAST_HDR dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                        if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)
                        {
                            string portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT_Fixed))));
                            this.comBoxSerialPort.SelectedIndex = FindCOMIndex(portName);
                        }
                        break;
                }
            }

            base.WndProc(ref m);
        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen)
            {
                if (this.radioBtnStr.Checked)
                {
                    try
                    {
                        System.Threading.Thread.Sleep(100);
                        int readCount = sp.BytesToRead;
                        if (readCount <= 0)
                        {
                            return;
                        }
                        byte[] ReDatas = new byte[readCount];

                        sp.Read(ReDatas, 0, readCount);
                        if (checkBox_RemoveMsgHead.Checked)
                        {
                            if (ReDatas[0] == 0x0a)
                            {
                                byte[] jsonData = new byte[ReDatas.Length - 3];
                                for (int i = 0; i < jsonData.Length; i++)
                                {
                                    jsonData[i] = ReDatas[3 + i];
                                }
                                string strjson = System.Text.Encoding.Default.GetString(jsonData);
                                log.log(strjson);
                                Writelog(strjson, Color.Green);
                            }
                            else
                            {
                                Writelog(System.Text.Encoding.Default.GetString(ReDatas), Color.Green);
                            }
                        }
                        else
                        {
                            Writelog(System.Text.Encoding.Default.GetString(ReDatas), Color.Green);
                        }

                        if (System.Text.Encoding.Default.GetString(ReDatas).Contains("connect"))
                        {
                            Writelog("connect success", Color.Green);
                            CheckTimer.Enabled = false;
                            CheckTimer.Stop();
                            bConnect = true;
                        }
                        sp.DiscardInBuffer();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                    }
                }
                else
                {
                    try
                    {
                        Byte[] receivedData = new Byte[sp.BytesToRead];
                        sp.Read(receivedData, 0, receivedData.Length);
                        sp.DiscardInBuffer();
                        string strRcv = null;
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += receivedData[i].ToString("X2");
                        }
                        Writelog(strRcv, Color.Green);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开一个串口", "错误提示");
            }
        }
        private void btnCleanSendData_Click(object sender, EventArgs e)
        {
            this.textSend.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("请先打开串口!", "错误提示");
                return;
            }

            if (this.radioBtn16.Checked)
            {
                byte[] byteBuffer = strToHexByte(this.textSend.Text);
                sp.Write(byteBuffer, 0, byteBuffer.Length);
            }
            else
            {
                if (radioButton_ConnectDevice.Checked)
                {
                    StartCheckConnect();
                }
                else
                {
                    SendDataToDeviceByStr(ConcatCmd());
                }
            }
        }
        void SendDataToDeviceByStr(string strSendData)
        {
            if (0 == strSendData.Length.CompareTo(0))
            {
                return;
            }
            if (checkBox_addMsgHead.Checked)
            {
                string str = strSendData;
                int ilength = strSendData.Length;
                byte[] sendbuf = new byte[ilength + 3];
                ilength = ilength + 1;
                sendbuf[0] = 0x0a;
                sendbuf[1] = (byte)(ilength >> 8);
                sendbuf[2] = (byte)(ilength & 0xFF);
                for (int i = 0; i < strSendData.Length; i++)
                {
                    sendbuf[3 + i] = (byte)str.ElementAt(i);
                }
                sp.Write(sendbuf, 0, ilength + 2);
            }
            else
            {
                sp.WriteLine(strSendData);
            }
        }
        string ConcatCmd()
        {
            if (radioButton_StartLoraRX.Checked)
            {
                string rfstr = this.textSend.Text.Trim();
                string rf = rfstr.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ElementAt(1);
                return string.Format("{{\"cmd\":\"lora\",\"test\":\"rx_start\",\"para\":{{\"rf\" :{0}}}}}", float.Parse(rf));
            }

            if (radioButton_StopLoraRX.Checked)
            {
                return string.Format("{{\"cmd\":\"lora\",\"test\":\"rx_stop\"}}");
            }
            if (radioButton_StartLoraTX.Checked)
            {
                string str = this.textSend.Text;
                try
                {
                    string tfStr = str.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ElementAt(0);
                    string tpStr = str.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ElementAt(1);

                    string tf = tfStr.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ElementAt(1);
                    string tp = tpStr.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ElementAt(1);
                    return string.Format("{{\"cmd\":\"lora\",\"test\":\"tx_start\",\"para\":{{\"tf\" :{0},\"tp\":{1}}}}}", float.Parse(tf), float.Parse(tp));
                }
                catch (Exception ex)
                {
                    Writelog(ex.Message, Color.Red);
                    return string.Empty;
                }
            }
            if (radioButton_StopLoraTX.Checked)
            {
                return string.Format("{{\"cmd\":\"lora\",\"test\":\"tx_stop\"}}");
            }
            if (radioButton_StartGPS.Checked)
            {
                return string.Format("{{\"cmd\":\"gps\",\"test\":\"start\"}}");
            }

            if (radioButton_StopGPS.Checked)
            {
                return string.Format("{{\"cmd\":\"gps\",\"test\":\"stop\"}}");
            }

            if (radioButton_StartADC.Checked)
            {
                return string.Format("{{\"cmd\":\"adc\",\"test\":\"start\"}}");
            }
            if (radioButton_StopADC.Checked)
            {
                return string.Format("{{\"cmd\":\"adc\",\"test\":\"stop\"}}");
            }

            if (radioButton_StartStep.Checked)
            {
                return string.Format("{{\"cmd\":\"step\",\"test\":\"start\"}}");
            }

            if (radioButton_StopStep.Checked)
            {
                return string.Format("{{\"cmd\":\"step\",\"test\":\"stop\"}}");
            }
            if (radioButton_SN.Checked)
            {
                return ConcatWriteValue("sn", this.textSend.Text.Trim());
            }
            if (radioButton_Deveui.Checked)
            {
                return ConcatWriteValue("deveui", this.textSend.Text.Trim());
            }
            if (radioButton_Joineui.Checked)
            {
                return ConcatWriteValue("joineui", this.textSend.Text.Trim());
            }
            if (radioButton_appKey.Checked)
            {
                return ConcatWriteValue("appkey", this.textSend.Text.Trim());
            }

            if (radioButton_WirelessGpsToOne.Checked)
            {
                return ConcatWriteValue("wireless_gps", 1);
            }
            if (radioButton_WireLessGpsToZero.Checked)
            {
                return ConcatWriteValue("wireless_gps", 0);
            }

            if (radioButton_WirelessLoraToOne.Checked)
            {
                return ConcatWriteValue("wireless_lora", 1);
            }
            if (radioButton_wirelessLoraToZero.Checked)
            {
                return ConcatWriteValue("wireless_lora", 0);
            }

            if (radioButton_GpsToOne.Checked)
            {
                return ConcatWriteValue("gps", 1);
            }
            if (radioButton_GpsToZero.Checked)
            {
                return ConcatWriteValue("gps", 0);
            }

            if (radioButton_LoraToOne.Checked)
            {
                return ConcatWriteValue("lora", 1);
            }
            if (radioButton_LoraToZero.Checked)
            {
                return ConcatWriteValue("lora", 0);
            }

            if (radioButton_AdcToOne.Checked)
            {
                return ConcatWriteValue("adc", 1);
            }
            if (radioButton_adcToZero.Checked)
            {
                return ConcatWriteValue("adc", 0);
            }

            if (radioButton_StepToOne.Checked)
            {
                return ConcatWriteValue("step", 1);
            }
            if (radioButton_StepToZero.Checked)
            {
                return ConcatWriteValue("step", 0);
            }

            if (radioButton_ReadAll.Checked)
            {
                return ConcatReadValue("all");
            }
            if (radioButton_CleanAll.Checked)
            {
                return ConcatCleanValue("all");
            }
            if (radioButton_ConnectDevice.Checked)
            {
                return string.Format("{0}", ConnectCmd);
            }
            if (radioButton_Common.Checked)
            {
                return this.textSend.Text.Trim();
            }
            return string.Empty;
        }

        string ConcatWriteValue(string key, string value)
        {
            return string.Format("{{\"cmd\":\"write\",\"field\":\"{0}\",\"value\":\"{1}\"}}", key, value);
        }
        string ConcatWriteValue(string key, int value)
        {
            return string.Format("{{\"cmd\":\"write\",\"field\":\"{0}\",\"value\":{1}}}", key, value);
        }

        string ConcatReadValue(string key)
        {
            return string.Format("{{\"cmd\":\"read\",\"field\":\"{0}\"}}", key);
        }

        string ConcatCleanValue(string key)
        {
            return string.Format("{{\"cmd\": \"clean\",\"field\": \"{0}\"}}", key);
        }
        private void CloseSerial()
        {
            //状态栏设置
            this.toolStripStatusSerialCom.Text = "串口号：未指定|";
            this.toolStripStatusBaudRate.Text = "波特率：未指定|";
            this.toolStripStatusDataBit.Text = "数据位：未指定|";
            this.toolStripStatusStopBit.Text = "停止位：未指定|";
            this.toolStripStatusParity.Text = "校验位：未指定|";

            //恢复控件功能
            //设置必要控件可用
            this.comBoxSerialPort.Enabled = true;
            this.comboBoxBaudRate.Enabled = true;
            this.comboBoxDataBit.Enabled = true;
            this.comboBoxStopBit.Enabled = true;
            this.comboBoxCheckBit.Enabled = true;

            sp.Close(); //关闭串口
            this.btnSwitchOpen.Text = "打开串口";
        }

        private void OpenSerial()
        {
            try
            {
                sp.PortName = this.comBoxSerialPort.SelectedItem.ToString();
                sp.BaudRate = Convert.ToInt32(this.comboBoxBaudRate.Text);
                sp.DataBits = Convert.ToInt32(this.comboBoxDataBit.Text);

                switch (this.comboBoxStopBit.Text)
                {
                    case "1":
                        sp.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        sp.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        sp.StopBits = StopBits.Two;
                        break;
                    default:
                        MessageBox.Show("Error:参数不正确！", "错误提示");
                        break;
                }

                switch (this.comboBoxCheckBit.Text)
                {
                    case "无":
                        sp.Parity = Parity.None;
                        break;
                    case "奇校验":
                        sp.Parity = Parity.Odd;
                        break;
                    case "偶校验":
                        sp.Parity = Parity.Even;
                        break;
                    default:
                        MessageBox.Show("Error：参数不正确!", "错误提示");
                        break;
                }
                if (sp.IsOpen)
                {
                    sp.Close();
                }

                //状态栏设置
                this.toolStripStatusSerialCom.Text = "串口号：" + sp.PortName + "|";
                this.toolStripStatusBaudRate.Text = "波特率：" + sp.BaudRate + "|";
                this.toolStripStatusDataBit.Text = "数据位：" + sp.DataBits + "|";
                this.toolStripStatusStopBit.Text = "停止位：" + sp.StopBits + "|";
                this.toolStripStatusParity.Text = "校验位：" + sp.Parity + "|";

                //设置必要控件不可用
                this.comBoxSerialPort.Enabled = false;
                this.comboBoxBaudRate.Enabled = false;
                this.comboBoxDataBit.Enabled = false;
                this.comboBoxStopBit.Enabled = false;
                this.comboBoxCheckBit.Enabled = false;

                sp.Open();
                this.btnSwitchOpen.Text = "关闭串口";
                // StartCheckConnect();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "错误提示");
                CloseSerial();
                //this.textSend.Enabled = false;
                return;
            }
        }
        private void btnSwitchOpen_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)//已经打开串，则关闭串口
            {
                CloseSerial();
            }
            else
            {
                OpenSerial();
            }
        }

        private void btnCleanRecvData_Click(object sender, EventArgs e)
        {
            this.richTextRecv.Clear();
        }

        private void radioBtn16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private byte[]strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if((hexString.Length %2 ) != 0)
            {
                hexString += " ";
            }

            byte[] returnBytes = new byte[hexString.Length / 2];
            for(int i=0;i<returnBytes.Length;i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return returnBytes;
        }
        private void SerialCom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            Application.Exit();
        }

        private void SerialCom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            Application.Exit();
        }

        private void radioButton_StartLoraRX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_StartLoraRX.Checked)
            {
                this.textSend.Text = "rf :489.7";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        private void radioButton_StartLoraTX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_StartLoraTX.Checked)
            {
                this.textSend.Text = "tf :480.3,tp :18";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        private void radioButton_SN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_SN.Checked)
            {
                this.textSend.Text = "01234567891234";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        private void radioButton_Joineui_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Joineui.Checked)
            {
                this.textSend.Text = "2c26c50065000001";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        private void radioButton_Deveui_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Deveui.Checked)
            {
                this.textSend.Text = "004a77006501004c";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        private void radioButton_appKey_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_appKey.Checked)
            {
                this.textSend.Text = "9bc2970e5152397ca3aeb7b83544196c";
            }
            else
            {
                this.textSend.Clear();
            }
        }

        /*
public void SaveLog(string s)
{
try
{
string fileFolder = AppDomain.CurrentDomain.BaseDirectory.ToString() + "log";
if (!Directory.Exists(fileFolder))
{
  Directory.CreateDirectory(fileFolder);
}
string filePath = fileFolder + "\\" + GetLogfile();
FileStream fs;
if (!File.Exists(filePath))
{
  fs = File.Create(filePath);
}
else
{
  fs = File.Open(filePath, FileMode.Append);
}
string strToWrite = "\r\n" + System.DateTime.Now.ToString() + "\r\n" + s + "\r\n";
byte[] b = System.Text.Encoding.Default.GetBytes(strToWrite);
fs.Write(b, 0, b.Length);
fs.Close();
}
catch
{ }
}

private string GetSystemName()
{
return this.Name;
}

//获取日志的名称，按天
public string GetLogfile()
{
System.Text.StringBuilder sb = new System.Text.StringBuilder();
sb.Append(GetSystemName());
string date = System.DateTime.Today.ToString("yyyy-MM-dd");
sb.Append(date);
sb.Append(".log");

return sb.ToString();
}
*/
    }
}
