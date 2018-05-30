namespace SerialCom
{
    partial class SerialCom
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialCom));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_addMsgHead = new System.Windows.Forms.CheckBox();
            this.btnCleanSendData = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textSend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBtnRcvStr = new System.Windows.Forms.RadioButton();
            this.radioBtnRcv16 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnStr = new System.Windows.Forms.RadioButton();
            this.radioBtn16 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSwitchOpen = new System.Windows.Forms.Button();
            this.comBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_RemoveMsgHead = new System.Windows.Forms.CheckBox();
            this.richTextRecv = new System.Windows.Forms.RichTextBox();
            this.btnCleanRecvData = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSerialCom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDataBit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusStopBit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButton_StartLoraRX = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton_Common = new System.Windows.Forms.RadioButton();
            this.radioButton_ConnectDevice = new System.Windows.Forms.RadioButton();
            this.radioButton_CleanAll = new System.Windows.Forms.RadioButton();
            this.radioButton_ReadAll = new System.Windows.Forms.RadioButton();
            this.radioButton_wirelessLoraToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_WirelessLoraToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_WireLessGpsToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_WirelessGpsToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_StepToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_StepToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_adcToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_AdcToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_LoraToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_LoraToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_GpsToZero = new System.Windows.Forms.RadioButton();
            this.radioButton_GpsToOne = new System.Windows.Forms.RadioButton();
            this.radioButton_appKey = new System.Windows.Forms.RadioButton();
            this.radioButton_Deveui = new System.Windows.Forms.RadioButton();
            this.radioButton_Joineui = new System.Windows.Forms.RadioButton();
            this.radioButton_SN = new System.Windows.Forms.RadioButton();
            this.radioButton_StopStep = new System.Windows.Forms.RadioButton();
            this.radioButton_StartStep = new System.Windows.Forms.RadioButton();
            this.radioButton_StopADC = new System.Windows.Forms.RadioButton();
            this.radioButton_StartADC = new System.Windows.Forms.RadioButton();
            this.radioButton_StopGPS = new System.Windows.Forms.RadioButton();
            this.radioButton_StartGPS = new System.Windows.Forms.RadioButton();
            this.radioButton_StopLoraTX = new System.Windows.Forms.RadioButton();
            this.radioButton_StartLoraTX = new System.Windows.Forms.RadioButton();
            this.radioButton_StopLoraRX = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_addMsgHead);
            this.groupBox1.Controls.Add(this.btnCleanSendData);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.textSend);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSwitchOpen);
            this.groupBox1.Controls.Add(this.comBoxSerialPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送方";
            // 
            // checkBox_addMsgHead
            // 
            this.checkBox_addMsgHead.AutoSize = true;
            this.checkBox_addMsgHead.Location = new System.Drawing.Point(85, 197);
            this.checkBox_addMsgHead.Name = "checkBox_addMsgHead";
            this.checkBox_addMsgHead.Size = new System.Drawing.Size(84, 16);
            this.checkBox_addMsgHead.TabIndex = 10;
            this.checkBox_addMsgHead.Text = "添加消息头";
            this.checkBox_addMsgHead.UseVisualStyleBackColor = true;
            // 
            // btnCleanSendData
            // 
            this.btnCleanSendData.Location = new System.Drawing.Point(13, 243);
            this.btnCleanSendData.Name = "btnCleanSendData";
            this.btnCleanSendData.Size = new System.Drawing.Size(75, 23);
            this.btnCleanSendData.TabIndex = 4;
            this.btnCleanSendData.Text = "清空发送数据";
            this.btnCleanSendData.UseVisualStyleBackColor = true;
            this.btnCleanSendData.Click += new System.EventHandler(this.btnCleanSendData_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(206, 243);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(13, 216);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(268, 21);
            this.textSend.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "发送数据：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioBtnRcvStr);
            this.groupBox4.Controls.Add(this.radioBtnRcv16);
            this.groupBox4.Location = new System.Drawing.Point(156, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 50);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收数据格式";
            // 
            // radioBtnRcvStr
            // 
            this.radioBtnRcvStr.AutoSize = true;
            this.radioBtnRcvStr.Location = new System.Drawing.Point(69, 20);
            this.radioBtnRcvStr.Name = "radioBtnRcvStr";
            this.radioBtnRcvStr.Size = new System.Drawing.Size(59, 16);
            this.radioBtnRcvStr.TabIndex = 2;
            this.radioBtnRcvStr.TabStop = true;
            this.radioBtnRcvStr.Text = "字符串";
            this.radioBtnRcvStr.UseVisualStyleBackColor = true;
            // 
            // radioBtnRcv16
            // 
            this.radioBtnRcv16.AutoSize = true;
            this.radioBtnRcv16.Location = new System.Drawing.Point(6, 20);
            this.radioBtnRcv16.Name = "radioBtnRcv16";
            this.radioBtnRcv16.Size = new System.Drawing.Size(59, 16);
            this.radioBtnRcv16.TabIndex = 1;
            this.radioBtnRcv16.TabStop = true;
            this.radioBtnRcv16.Text = "16进制";
            this.radioBtnRcv16.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnStr);
            this.groupBox3.Controls.Add(this.radioBtn16);
            this.groupBox3.Location = new System.Drawing.Point(13, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据格式";
            // 
            // radioBtnStr
            // 
            this.radioBtnStr.AutoSize = true;
            this.radioBtnStr.Location = new System.Drawing.Point(71, 21);
            this.radioBtnStr.Name = "radioBtnStr";
            this.radioBtnStr.Size = new System.Drawing.Size(59, 16);
            this.radioBtnStr.TabIndex = 1;
            this.radioBtnStr.TabStop = true;
            this.radioBtnStr.Text = "字符串";
            this.radioBtnStr.UseVisualStyleBackColor = true;
            // 
            // radioBtn16
            // 
            this.radioBtn16.AutoSize = true;
            this.radioBtn16.Location = new System.Drawing.Point(7, 21);
            this.radioBtn16.Name = "radioBtn16";
            this.radioBtn16.Size = new System.Drawing.Size(59, 16);
            this.radioBtn16.TabIndex = 0;
            this.radioBtn16.TabStop = true;
            this.radioBtn16.Text = "16进制";
            this.radioBtn16.UseVisualStyleBackColor = true;
            this.radioBtn16.CheckedChanged += new System.EventHandler(this.radioBtn16_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCheckBit);
            this.groupBox2.Controls.Add(this.comboBoxStopBit);
            this.groupBox2.Controls.Add(this.comboBoxDataBit);
            this.groupBox2.Controls.Add(this.comboBoxBaudRate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口设置";
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Location = new System.Drawing.Point(209, 45);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(62, 20);
            this.comboBoxCheckBit.TabIndex = 7;
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(56, 45);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(64, 20);
            this.comboBoxStopBit.TabIndex = 6;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Location = new System.Drawing.Point(209, 20);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(62, 20);
            this.comboBoxDataBit.TabIndex = 5;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(56, 20);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(62, 20);
            this.comboBoxBaudRate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "校验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "数据位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "停止位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // btnSwitchOpen
            // 
            this.btnSwitchOpen.Location = new System.Drawing.Point(125, 19);
            this.btnSwitchOpen.Name = "btnSwitchOpen";
            this.btnSwitchOpen.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchOpen.TabIndex = 2;
            this.btnSwitchOpen.Text = "打开串口";
            this.btnSwitchOpen.UseVisualStyleBackColor = true;
            this.btnSwitchOpen.Click += new System.EventHandler(this.btnSwitchOpen_Click);
            // 
            // comBoxSerialPort
            // 
            this.comBoxSerialPort.FormattingEnabled = true;
            this.comBoxSerialPort.Location = new System.Drawing.Point(47, 20);
            this.comBoxSerialPort.Name = "comBoxSerialPort";
            this.comBoxSerialPort.Size = new System.Drawing.Size(62, 20);
            this.comBoxSerialPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_RemoveMsgHead);
            this.groupBox5.Controls.Add(this.richTextRecv);
            this.groupBox5.Controls.Add(this.btnCleanRecvData);
            this.groupBox5.Location = new System.Drawing.Point(315, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(546, 278);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收方";
            // 
            // checkBox_RemoveMsgHead
            // 
            this.checkBox_RemoveMsgHead.AutoSize = true;
            this.checkBox_RemoveMsgHead.Location = new System.Drawing.Point(7, 249);
            this.checkBox_RemoveMsgHead.Name = "checkBox_RemoveMsgHead";
            this.checkBox_RemoveMsgHead.Size = new System.Drawing.Size(84, 16);
            this.checkBox_RemoveMsgHead.TabIndex = 5;
            this.checkBox_RemoveMsgHead.Text = "移除消息头";
            this.checkBox_RemoveMsgHead.UseVisualStyleBackColor = true;
            // 
            // richTextRecv
            // 
            this.richTextRecv.Location = new System.Drawing.Point(7, 17);
            this.richTextRecv.Name = "richTextRecv";
            this.richTextRecv.ReadOnly = true;
            this.richTextRecv.ShowSelectionMargin = true;
            this.richTextRecv.Size = new System.Drawing.Size(530, 219);
            this.richTextRecv.TabIndex = 0;
            this.richTextRecv.Text = "";
            // 
            // btnCleanRecvData
            // 
            this.btnCleanRecvData.Location = new System.Drawing.Point(410, 242);
            this.btnCleanRecvData.Name = "btnCleanRecvData";
            this.btnCleanRecvData.Size = new System.Drawing.Size(75, 23);
            this.btnCleanRecvData.TabIndex = 3;
            this.btnCleanRecvData.Text = "清空接收数据";
            this.btnCleanRecvData.UseVisualStyleBackColor = true;
            this.btnCleanRecvData.Click += new System.EventHandler(this.btnCleanRecvData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSerialCom,
            this.toolStripStatusBaudRate,
            this.toolStripStatusDataBit,
            this.toolStripStatusStopBit,
            this.toolStripStatusParity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSerialCom
            // 
            this.toolStripStatusSerialCom.Name = "toolStripStatusSerialCom";
            this.toolStripStatusSerialCom.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusSerialCom.Text = "串口号：未指定|";
            // 
            // toolStripStatusBaudRate
            // 
            this.toolStripStatusBaudRate.Name = "toolStripStatusBaudRate";
            this.toolStripStatusBaudRate.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusBaudRate.Text = "波特率：未指定|";
            // 
            // toolStripStatusDataBit
            // 
            this.toolStripStatusDataBit.Name = "toolStripStatusDataBit";
            this.toolStripStatusDataBit.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusDataBit.Text = "数据位：未指定|";
            // 
            // toolStripStatusStopBit
            // 
            this.toolStripStatusStopBit.Name = "toolStripStatusStopBit";
            this.toolStripStatusStopBit.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusStopBit.Text = "停止位：未指定|";
            // 
            // toolStripStatusParity
            // 
            this.toolStripStatusParity.Name = "toolStripStatusParity";
            this.toolStripStatusParity.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusParity.Text = "校验位：未指定|";
            // 
            // radioButton_StartLoraRX
            // 
            this.radioButton_StartLoraRX.AutoSize = true;
            this.radioButton_StartLoraRX.Location = new System.Drawing.Point(11, 14);
            this.radioButton_StartLoraRX.Name = "radioButton_StartLoraRX";
            this.radioButton_StartLoraRX.Size = new System.Drawing.Size(89, 16);
            this.radioButton_StartLoraRX.TabIndex = 3;
            this.radioButton_StartLoraRX.TabStop = true;
            this.radioButton_StartLoraRX.Text = "StartLoraRX";
            this.radioButton_StartLoraRX.UseVisualStyleBackColor = true;
            this.radioButton_StartLoraRX.CheckedChanged += new System.EventHandler(this.radioButton_StartLoraRX_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton_Common);
            this.groupBox6.Controls.Add(this.radioButton_ConnectDevice);
            this.groupBox6.Controls.Add(this.radioButton_CleanAll);
            this.groupBox6.Controls.Add(this.radioButton_ReadAll);
            this.groupBox6.Controls.Add(this.radioButton_wirelessLoraToZero);
            this.groupBox6.Controls.Add(this.radioButton_WirelessLoraToOne);
            this.groupBox6.Controls.Add(this.radioButton_WireLessGpsToZero);
            this.groupBox6.Controls.Add(this.radioButton_WirelessGpsToOne);
            this.groupBox6.Controls.Add(this.radioButton_StepToZero);
            this.groupBox6.Controls.Add(this.radioButton_StepToOne);
            this.groupBox6.Controls.Add(this.radioButton_adcToZero);
            this.groupBox6.Controls.Add(this.radioButton_AdcToOne);
            this.groupBox6.Controls.Add(this.radioButton_LoraToZero);
            this.groupBox6.Controls.Add(this.radioButton_LoraToOne);
            this.groupBox6.Controls.Add(this.radioButton_GpsToZero);
            this.groupBox6.Controls.Add(this.radioButton_GpsToOne);
            this.groupBox6.Controls.Add(this.radioButton_appKey);
            this.groupBox6.Controls.Add(this.radioButton_Deveui);
            this.groupBox6.Controls.Add(this.radioButton_Joineui);
            this.groupBox6.Controls.Add(this.radioButton_SN);
            this.groupBox6.Controls.Add(this.radioButton_StopStep);
            this.groupBox6.Controls.Add(this.radioButton_StartStep);
            this.groupBox6.Controls.Add(this.radioButton_StopADC);
            this.groupBox6.Controls.Add(this.radioButton_StartADC);
            this.groupBox6.Controls.Add(this.radioButton_StopGPS);
            this.groupBox6.Controls.Add(this.radioButton_StartGPS);
            this.groupBox6.Controls.Add(this.radioButton_StopLoraTX);
            this.groupBox6.Controls.Add(this.radioButton_StartLoraTX);
            this.groupBox6.Controls.Add(this.radioButton_StopLoraRX);
            this.groupBox6.Controls.Add(this.radioButton_StartLoraRX);
            this.groupBox6.Location = new System.Drawing.Point(12, 296);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(849, 82);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // radioButton_Common
            // 
            this.radioButton_Common.AutoSize = true;
            this.radioButton_Common.Location = new System.Drawing.Point(725, 55);
            this.radioButton_Common.Name = "radioButton_Common";
            this.radioButton_Common.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Common.TabIndex = 32;
            this.radioButton_Common.TabStop = true;
            this.radioButton_Common.Text = "通用";
            this.radioButton_Common.UseVisualStyleBackColor = true;
            // 
            // radioButton_ConnectDevice
            // 
            this.radioButton_ConnectDevice.AutoSize = true;
            this.radioButton_ConnectDevice.Location = new System.Drawing.Point(638, 56);
            this.radioButton_ConnectDevice.Name = "radioButton_ConnectDevice";
            this.radioButton_ConnectDevice.Size = new System.Drawing.Size(71, 16);
            this.radioButton_ConnectDevice.TabIndex = 31;
            this.radioButton_ConnectDevice.TabStop = true;
            this.radioButton_ConnectDevice.Text = "连接设备";
            this.radioButton_ConnectDevice.UseVisualStyleBackColor = true;
            // 
            // radioButton_CleanAll
            // 
            this.radioButton_CleanAll.AutoSize = true;
            this.radioButton_CleanAll.Location = new System.Drawing.Point(541, 57);
            this.radioButton_CleanAll.Name = "radioButton_CleanAll";
            this.radioButton_CleanAll.Size = new System.Drawing.Size(71, 16);
            this.radioButton_CleanAll.TabIndex = 30;
            this.radioButton_CleanAll.TabStop = true;
            this.radioButton_CleanAll.Text = "清除所有";
            this.radioButton_CleanAll.UseVisualStyleBackColor = true;
            // 
            // radioButton_ReadAll
            // 
            this.radioButton_ReadAll.AutoSize = true;
            this.radioButton_ReadAll.Location = new System.Drawing.Point(445, 57);
            this.radioButton_ReadAll.Name = "radioButton_ReadAll";
            this.radioButton_ReadAll.Size = new System.Drawing.Size(71, 16);
            this.radioButton_ReadAll.TabIndex = 29;
            this.radioButton_ReadAll.TabStop = true;
            this.radioButton_ReadAll.Text = "读取所有";
            this.radioButton_ReadAll.UseVisualStyleBackColor = true;
            // 
            // radioButton_wirelessLoraToZero
            // 
            this.radioButton_wirelessLoraToZero.AutoSize = true;
            this.radioButton_wirelessLoraToZero.Location = new System.Drawing.Point(541, 36);
            this.radioButton_wirelessLoraToZero.Name = "radioButton_wirelessLoraToZero";
            this.radioButton_wirelessLoraToZero.Size = new System.Drawing.Size(89, 16);
            this.radioButton_wirelessLoraToZero.TabIndex = 28;
            this.radioButton_wirelessLoraToZero.TabStop = true;
            this.radioButton_wirelessLoraToZero.Text = "耦合lora->0";
            this.radioButton_wirelessLoraToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_WirelessLoraToOne
            // 
            this.radioButton_WirelessLoraToOne.AutoSize = true;
            this.radioButton_WirelessLoraToOne.Location = new System.Drawing.Point(445, 35);
            this.radioButton_WirelessLoraToOne.Name = "radioButton_WirelessLoraToOne";
            this.radioButton_WirelessLoraToOne.Size = new System.Drawing.Size(89, 16);
            this.radioButton_WirelessLoraToOne.TabIndex = 27;
            this.radioButton_WirelessLoraToOne.TabStop = true;
            this.radioButton_WirelessLoraToOne.Text = "耦合lora->1";
            this.radioButton_WirelessLoraToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_WireLessGpsToZero
            // 
            this.radioButton_WireLessGpsToZero.AutoSize = true;
            this.radioButton_WireLessGpsToZero.Location = new System.Drawing.Point(344, 35);
            this.radioButton_WireLessGpsToZero.Name = "radioButton_WireLessGpsToZero";
            this.radioButton_WireLessGpsToZero.Size = new System.Drawing.Size(83, 16);
            this.radioButton_WireLessGpsToZero.TabIndex = 26;
            this.radioButton_WireLessGpsToZero.TabStop = true;
            this.radioButton_WireLessGpsToZero.Text = "耦合gps->0";
            this.radioButton_WireLessGpsToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_WirelessGpsToOne
            // 
            this.radioButton_WirelessGpsToOne.AutoSize = true;
            this.radioButton_WirelessGpsToOne.Location = new System.Drawing.Point(255, 36);
            this.radioButton_WirelessGpsToOne.Name = "radioButton_WirelessGpsToOne";
            this.radioButton_WirelessGpsToOne.Size = new System.Drawing.Size(83, 16);
            this.radioButton_WirelessGpsToOne.TabIndex = 25;
            this.radioButton_WirelessGpsToOne.TabStop = true;
            this.radioButton_WirelessGpsToOne.Text = "耦合gps->1";
            this.radioButton_WirelessGpsToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_StepToZero
            // 
            this.radioButton_StepToZero.AutoSize = true;
            this.radioButton_StepToZero.Location = new System.Drawing.Point(362, 57);
            this.radioButton_StepToZero.Name = "radioButton_StepToZero";
            this.radioButton_StepToZero.Size = new System.Drawing.Size(65, 16);
            this.radioButton_StepToZero.TabIndex = 24;
            this.radioButton_StepToZero.TabStop = true;
            this.radioButton_StepToZero.Text = "step->0";
            this.radioButton_StepToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_StepToOne
            // 
            this.radioButton_StepToOne.AutoSize = true;
            this.radioButton_StepToOne.Location = new System.Drawing.Point(287, 57);
            this.radioButton_StepToOne.Name = "radioButton_StepToOne";
            this.radioButton_StepToOne.Size = new System.Drawing.Size(65, 16);
            this.radioButton_StepToOne.TabIndex = 23;
            this.radioButton_StepToOne.TabStop = true;
            this.radioButton_StepToOne.Text = "step->1";
            this.radioButton_StepToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_adcToZero
            // 
            this.radioButton_adcToZero.AutoSize = true;
            this.radioButton_adcToZero.Location = new System.Drawing.Point(222, 57);
            this.radioButton_adcToZero.Name = "radioButton_adcToZero";
            this.radioButton_adcToZero.Size = new System.Drawing.Size(59, 16);
            this.radioButton_adcToZero.TabIndex = 22;
            this.radioButton_adcToZero.TabStop = true;
            this.radioButton_adcToZero.Text = "adc->0";
            this.radioButton_adcToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_AdcToOne
            // 
            this.radioButton_AdcToOne.AutoSize = true;
            this.radioButton_AdcToOne.Location = new System.Drawing.Point(156, 57);
            this.radioButton_AdcToOne.Name = "radioButton_AdcToOne";
            this.radioButton_AdcToOne.Size = new System.Drawing.Size(59, 16);
            this.radioButton_AdcToOne.TabIndex = 21;
            this.radioButton_AdcToOne.TabStop = true;
            this.radioButton_AdcToOne.Text = "adc->1";
            this.radioButton_AdcToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_LoraToZero
            // 
            this.radioButton_LoraToZero.AutoSize = true;
            this.radioButton_LoraToZero.Location = new System.Drawing.Point(85, 57);
            this.radioButton_LoraToZero.Name = "radioButton_LoraToZero";
            this.radioButton_LoraToZero.Size = new System.Drawing.Size(65, 16);
            this.radioButton_LoraToZero.TabIndex = 20;
            this.radioButton_LoraToZero.TabStop = true;
            this.radioButton_LoraToZero.Text = "lora->0";
            this.radioButton_LoraToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_LoraToOne
            // 
            this.radioButton_LoraToOne.AutoSize = true;
            this.radioButton_LoraToOne.Location = new System.Drawing.Point(11, 57);
            this.radioButton_LoraToOne.Name = "radioButton_LoraToOne";
            this.radioButton_LoraToOne.Size = new System.Drawing.Size(65, 16);
            this.radioButton_LoraToOne.TabIndex = 19;
            this.radioButton_LoraToOne.TabStop = true;
            this.radioButton_LoraToOne.Text = "lora->1";
            this.radioButton_LoraToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_GpsToZero
            // 
            this.radioButton_GpsToZero.AutoSize = true;
            this.radioButton_GpsToZero.Location = new System.Drawing.Point(704, 36);
            this.radioButton_GpsToZero.Name = "radioButton_GpsToZero";
            this.radioButton_GpsToZero.Size = new System.Drawing.Size(59, 16);
            this.radioButton_GpsToZero.TabIndex = 18;
            this.radioButton_GpsToZero.TabStop = true;
            this.radioButton_GpsToZero.Text = "gps->0";
            this.radioButton_GpsToZero.UseVisualStyleBackColor = true;
            // 
            // radioButton_GpsToOne
            // 
            this.radioButton_GpsToOne.AutoSize = true;
            this.radioButton_GpsToOne.Location = new System.Drawing.Point(638, 35);
            this.radioButton_GpsToOne.Name = "radioButton_GpsToOne";
            this.radioButton_GpsToOne.Size = new System.Drawing.Size(59, 16);
            this.radioButton_GpsToOne.TabIndex = 17;
            this.radioButton_GpsToOne.TabStop = true;
            this.radioButton_GpsToOne.Text = "gps->1";
            this.radioButton_GpsToOne.UseVisualStyleBackColor = true;
            // 
            // radioButton_appKey
            // 
            this.radioButton_appKey.AutoSize = true;
            this.radioButton_appKey.Location = new System.Drawing.Point(190, 34);
            this.radioButton_appKey.Name = "radioButton_appKey";
            this.radioButton_appKey.Size = new System.Drawing.Size(59, 16);
            this.radioButton_appKey.TabIndex = 16;
            this.radioButton_appKey.TabStop = true;
            this.radioButton_appKey.Text = "Appkey";
            this.radioButton_appKey.UseVisualStyleBackColor = true;
            this.radioButton_appKey.CheckedChanged += new System.EventHandler(this.radioButton_appKey_CheckedChanged);
            // 
            // radioButton_Deveui
            // 
            this.radioButton_Deveui.AutoSize = true;
            this.radioButton_Deveui.Location = new System.Drawing.Point(125, 34);
            this.radioButton_Deveui.Name = "radioButton_Deveui";
            this.radioButton_Deveui.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Deveui.TabIndex = 15;
            this.radioButton_Deveui.TabStop = true;
            this.radioButton_Deveui.Text = "Deveui";
            this.radioButton_Deveui.UseVisualStyleBackColor = true;
            this.radioButton_Deveui.CheckedChanged += new System.EventHandler(this.radioButton_Deveui_CheckedChanged);
            // 
            // radioButton_Joineui
            // 
            this.radioButton_Joineui.AutoSize = true;
            this.radioButton_Joineui.Location = new System.Drawing.Point(53, 35);
            this.radioButton_Joineui.Name = "radioButton_Joineui";
            this.radioButton_Joineui.Size = new System.Drawing.Size(65, 16);
            this.radioButton_Joineui.TabIndex = 14;
            this.radioButton_Joineui.TabStop = true;
            this.radioButton_Joineui.Text = "Joineui";
            this.radioButton_Joineui.UseVisualStyleBackColor = true;
            this.radioButton_Joineui.CheckedChanged += new System.EventHandler(this.radioButton_Joineui_CheckedChanged);
            // 
            // radioButton_SN
            // 
            this.radioButton_SN.AutoSize = true;
            this.radioButton_SN.Location = new System.Drawing.Point(11, 36);
            this.radioButton_SN.Name = "radioButton_SN";
            this.radioButton_SN.Size = new System.Drawing.Size(35, 16);
            this.radioButton_SN.TabIndex = 13;
            this.radioButton_SN.TabStop = true;
            this.radioButton_SN.Text = "SN";
            this.radioButton_SN.UseVisualStyleBackColor = true;
            this.radioButton_SN.CheckedChanged += new System.EventHandler(this.radioButton_SN_CheckedChanged);
            // 
            // radioButton_StopStep
            // 
            this.radioButton_StopStep.AutoSize = true;
            this.radioButton_StopStep.Location = new System.Drawing.Point(769, 14);
            this.radioButton_StopStep.Name = "radioButton_StopStep";
            this.radioButton_StopStep.Size = new System.Drawing.Size(71, 16);
            this.radioButton_StopStep.TabIndex = 12;
            this.radioButton_StopStep.TabStop = true;
            this.radioButton_StopStep.Text = "StopStep";
            this.radioButton_StopStep.UseVisualStyleBackColor = true;
            // 
            // radioButton_StartStep
            // 
            this.radioButton_StartStep.AutoSize = true;
            this.radioButton_StartStep.Location = new System.Drawing.Point(686, 14);
            this.radioButton_StartStep.Name = "radioButton_StartStep";
            this.radioButton_StartStep.Size = new System.Drawing.Size(77, 16);
            this.radioButton_StartStep.TabIndex = 11;
            this.radioButton_StartStep.TabStop = true;
            this.radioButton_StartStep.Text = "StartStep";
            this.radioButton_StartStep.UseVisualStyleBackColor = true;
            // 
            // radioButton_StopADC
            // 
            this.radioButton_StopADC.AutoSize = true;
            this.radioButton_StopADC.Location = new System.Drawing.Point(615, 14);
            this.radioButton_StopADC.Name = "radioButton_StopADC";
            this.radioButton_StopADC.Size = new System.Drawing.Size(65, 16);
            this.radioButton_StopADC.TabIndex = 10;
            this.radioButton_StopADC.TabStop = true;
            this.radioButton_StopADC.Text = "StopADC";
            this.radioButton_StopADC.UseVisualStyleBackColor = true;
            // 
            // radioButton_StartADC
            // 
            this.radioButton_StartADC.AutoSize = true;
            this.radioButton_StartADC.Location = new System.Drawing.Point(538, 14);
            this.radioButton_StartADC.Name = "radioButton_StartADC";
            this.radioButton_StartADC.Size = new System.Drawing.Size(71, 16);
            this.radioButton_StartADC.TabIndex = 9;
            this.radioButton_StartADC.TabStop = true;
            this.radioButton_StartADC.Text = "StartADC";
            this.radioButton_StartADC.UseVisualStyleBackColor = true;
            // 
            // radioButton_StopGPS
            // 
            this.radioButton_StopGPS.AutoSize = true;
            this.radioButton_StopGPS.Location = new System.Drawing.Point(459, 14);
            this.radioButton_StopGPS.Name = "radioButton_StopGPS";
            this.radioButton_StopGPS.Size = new System.Drawing.Size(65, 16);
            this.radioButton_StopGPS.TabIndex = 8;
            this.radioButton_StopGPS.TabStop = true;
            this.radioButton_StopGPS.Text = "StopGPS";
            this.radioButton_StopGPS.UseVisualStyleBackColor = true;
            // 
            // radioButton_StartGPS
            // 
            this.radioButton_StartGPS.AutoSize = true;
            this.radioButton_StartGPS.Location = new System.Drawing.Point(382, 14);
            this.radioButton_StartGPS.Name = "radioButton_StartGPS";
            this.radioButton_StartGPS.Size = new System.Drawing.Size(71, 16);
            this.radioButton_StartGPS.TabIndex = 7;
            this.radioButton_StartGPS.TabStop = true;
            this.radioButton_StartGPS.Text = "StartGPS";
            this.radioButton_StartGPS.UseVisualStyleBackColor = true;
            // 
            // radioButton_StopLoraTX
            // 
            this.radioButton_StopLoraTX.AutoSize = true;
            this.radioButton_StopLoraTX.Location = new System.Drawing.Point(287, 14);
            this.radioButton_StopLoraTX.Name = "radioButton_StopLoraTX";
            this.radioButton_StopLoraTX.Size = new System.Drawing.Size(83, 16);
            this.radioButton_StopLoraTX.TabIndex = 6;
            this.radioButton_StopLoraTX.TabStop = true;
            this.radioButton_StopLoraTX.Text = "StopLoraTX";
            this.radioButton_StopLoraTX.UseVisualStyleBackColor = true;
            // 
            // radioButton_StartLoraTX
            // 
            this.radioButton_StartLoraTX.AutoSize = true;
            this.radioButton_StartLoraTX.Location = new System.Drawing.Point(192, 14);
            this.radioButton_StartLoraTX.Name = "radioButton_StartLoraTX";
            this.radioButton_StartLoraTX.Size = new System.Drawing.Size(89, 16);
            this.radioButton_StartLoraTX.TabIndex = 5;
            this.radioButton_StartLoraTX.TabStop = true;
            this.radioButton_StartLoraTX.Text = "StartLoraTX";
            this.radioButton_StartLoraTX.UseVisualStyleBackColor = true;
            this.radioButton_StartLoraTX.CheckedChanged += new System.EventHandler(this.radioButton_StartLoraTX_CheckedChanged);
            // 
            // radioButton_StopLoraRX
            // 
            this.radioButton_StopLoraRX.AutoSize = true;
            this.radioButton_StopLoraRX.Location = new System.Drawing.Point(105, 14);
            this.radioButton_StopLoraRX.Name = "radioButton_StopLoraRX";
            this.radioButton_StopLoraRX.Size = new System.Drawing.Size(83, 16);
            this.radioButton_StopLoraRX.TabIndex = 4;
            this.radioButton_StopLoraRX.TabStop = true;
            this.radioButton_StopLoraRX.Text = "StopLoraRX";
            this.radioButton_StopLoraRX.UseVisualStyleBackColor = true;
            // 
            // SerialCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 413);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialCom";
            this.Text = "串口通讯";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialCom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialCom_FormClosed);
            this.Load += new System.EventHandler(this.SerialCom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBtnRcvStr;
        private System.Windows.Forms.RadioButton radioBtnRcv16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnStr;
        private System.Windows.Forms.RadioButton radioBtn16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSwitchOpen;
        private System.Windows.Forms.ComboBox comBoxSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextRecv;
        private System.Windows.Forms.Button btnCleanSendData;
        private System.Windows.Forms.Button btnCleanRecvData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSerialCom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDataBit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusStopBit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusParity;
        private System.Windows.Forms.RadioButton radioButton_StartLoraRX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton_StopLoraTX;
        private System.Windows.Forms.RadioButton radioButton_StartLoraTX;
        private System.Windows.Forms.RadioButton radioButton_StopLoraRX;
        private System.Windows.Forms.RadioButton radioButton_StopADC;
        private System.Windows.Forms.RadioButton radioButton_StartADC;
        private System.Windows.Forms.RadioButton radioButton_StopGPS;
        private System.Windows.Forms.RadioButton radioButton_StartGPS;
        private System.Windows.Forms.RadioButton radioButton_GpsToOne;
        private System.Windows.Forms.RadioButton radioButton_appKey;
        private System.Windows.Forms.RadioButton radioButton_Deveui;
        private System.Windows.Forms.RadioButton radioButton_Joineui;
        private System.Windows.Forms.RadioButton radioButton_SN;
        private System.Windows.Forms.RadioButton radioButton_StopStep;
        private System.Windows.Forms.RadioButton radioButton_StartStep;
        private System.Windows.Forms.RadioButton radioButton_LoraToZero;
        private System.Windows.Forms.RadioButton radioButton_LoraToOne;
        private System.Windows.Forms.RadioButton radioButton_GpsToZero;
        private System.Windows.Forms.RadioButton radioButton_wirelessLoraToZero;
        private System.Windows.Forms.RadioButton radioButton_WirelessLoraToOne;
        private System.Windows.Forms.RadioButton radioButton_WireLessGpsToZero;
        private System.Windows.Forms.RadioButton radioButton_WirelessGpsToOne;
        private System.Windows.Forms.RadioButton radioButton_StepToZero;
        private System.Windows.Forms.RadioButton radioButton_StepToOne;
        private System.Windows.Forms.RadioButton radioButton_adcToZero;
        private System.Windows.Forms.RadioButton radioButton_AdcToOne;
        private System.Windows.Forms.RadioButton radioButton_CleanAll;
        private System.Windows.Forms.RadioButton radioButton_ReadAll;
        private System.Windows.Forms.RadioButton radioButton_ConnectDevice;
        private System.Windows.Forms.CheckBox checkBox_addMsgHead;
        private System.Windows.Forms.CheckBox checkBox_RemoveMsgHead;
        private System.Windows.Forms.RadioButton radioButton_Common;
    }
}

