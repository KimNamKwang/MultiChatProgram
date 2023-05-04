namespace MultiChatProgram2
{
    partial class MultiChat2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSendBox = new System.Windows.Forms.GroupBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.groupBoxForProgress = new System.Windows.Forms.GroupBox();
            this.progressBarForFile = new System.Windows.Forms.ProgressBar();
            this.labelForCountFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.richTextBoxForReceiveFile = new System.Windows.Forms.RichTextBox();
            this.labelForReceiveFile = new System.Windows.Forms.Label();
            this.richTextBoxForSendFile = new System.Windows.Forms.RichTextBox();
            this.labelForSendFile = new System.Windows.Forms.Label();
            this.dataSendBox = new System.Windows.Forms.GroupBox();
            this.labelForPORT = new System.Windows.Forms.Label();
            this.boxForPort = new System.Windows.Forms.TextBox();
            this.btnClearChat = new System.Windows.Forms.Button();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.textBoxForSendChat = new System.Windows.Forms.RichTextBox();
            this.textBoxForChatView = new System.Windows.Forms.RichTextBox();
            this.labelForConnectedPC = new System.Windows.Forms.Label();
            this.labelForIPAddr = new System.Windows.Forms.Label();
            this.btnSameIP = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.boxForIPAddr = new System.Windows.Forms.TextBox();
            this.modeSelectBox = new System.Windows.Forms.GroupBox();
            this.multiToMultiBtn = new System.Windows.Forms.RadioButton();
            this.oneToOneBtn = new System.Windows.Forms.RadioButton();
            this.positionSelectBox = new System.Windows.Forms.GroupBox();
            this.clientBtn = new System.Windows.Forms.RadioButton();
            this.serverBtn = new System.Windows.Forms.RadioButton();
            this.fileSendBox.SuspendLayout();
            this.groupBoxForProgress.SuspendLayout();
            this.dataSendBox.SuspendLayout();
            this.modeSelectBox.SuspendLayout();
            this.positionSelectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSendBox
            // 
            this.fileSendBox.Controls.Add(this.btnSendFile);
            this.fileSendBox.Controls.Add(this.groupBoxForProgress);
            this.fileSendBox.Controls.Add(this.labelForCountFile);
            this.fileSendBox.Controls.Add(this.label5);
            this.fileSendBox.Controls.Add(this.btnSelectFile);
            this.fileSendBox.Controls.Add(this.richTextBoxForReceiveFile);
            this.fileSendBox.Controls.Add(this.labelForReceiveFile);
            this.fileSendBox.Controls.Add(this.richTextBoxForSendFile);
            this.fileSendBox.Controls.Add(this.labelForSendFile);
            this.fileSendBox.Location = new System.Drawing.Point(13, 287);
            this.fileSendBox.Name = "fileSendBox";
            this.fileSendBox.Size = new System.Drawing.Size(537, 312);
            this.fileSendBox.TabIndex = 9;
            this.fileSendBox.TabStop = false;
            this.fileSendBox.Text = "파일전송";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(445, 253);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(86, 46);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "전송";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxForProgress
            // 
            this.groupBoxForProgress.Controls.Add(this.progressBarForFile);
            this.groupBoxForProgress.Location = new System.Drawing.Point(188, 247);
            this.groupBoxForProgress.Name = "groupBoxForProgress";
            this.groupBoxForProgress.Size = new System.Drawing.Size(251, 59);
            this.groupBoxForProgress.TabIndex = 7;
            this.groupBoxForProgress.TabStop = false;
            this.groupBoxForProgress.Text = "진행상태";
            // 
            // progressBarForFile
            // 
            this.progressBarForFile.Location = new System.Drawing.Point(6, 20);
            this.progressBarForFile.Name = "progressBarForFile";
            this.progressBarForFile.Size = new System.Drawing.Size(239, 31);
            this.progressBarForFile.TabIndex = 0;
            // 
            // labelForCountFile
            // 
            this.labelForCountFile.AutoSize = true;
            this.labelForCountFile.Location = new System.Drawing.Point(136, 280);
            this.labelForCountFile.Name = "labelForCountFile";
            this.labelForCountFile.Size = new System.Drawing.Size(23, 12);
            this.labelForCountFile.TabIndex = 6;
            this.labelForCountFile.Text = "0/0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "총 파일 수량";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(10, 253);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(89, 46);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "파일선택";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // richTextBoxForReceiveFile
            // 
            this.richTextBoxForReceiveFile.Location = new System.Drawing.Point(8, 153);
            this.richTextBoxForReceiveFile.Name = "richTextBoxForReceiveFile";
            this.richTextBoxForReceiveFile.Size = new System.Drawing.Size(522, 88);
            this.richTextBoxForReceiveFile.TabIndex = 3;
            this.richTextBoxForReceiveFile.Text = "";
            // 
            // labelForReceiveFile
            // 
            this.labelForReceiveFile.AutoSize = true;
            this.labelForReceiveFile.Location = new System.Drawing.Point(19, 134);
            this.labelForReceiveFile.Name = "labelForReceiveFile";
            this.labelForReceiveFile.Size = new System.Drawing.Size(108, 12);
            this.labelForReceiveFile.TabIndex = 2;
            this.labelForReceiveFile.Text = "받기(Receive) File";
            // 
            // richTextBoxForSendFile
            // 
            this.richTextBoxForSendFile.Location = new System.Drawing.Point(8, 39);
            this.richTextBoxForSendFile.Name = "richTextBoxForSendFile";
            this.richTextBoxForSendFile.Size = new System.Drawing.Size(522, 88);
            this.richTextBoxForSendFile.TabIndex = 1;
            this.richTextBoxForSendFile.Text = "";
            // 
            // labelForSendFile
            // 
            this.labelForSendFile.AutoSize = true;
            this.labelForSendFile.Location = new System.Drawing.Point(20, 21);
            this.labelForSendFile.Name = "labelForSendFile";
            this.labelForSendFile.Size = new System.Drawing.Size(104, 12);
            this.labelForSendFile.TabIndex = 0;
            this.labelForSendFile.Text = "보내기(Send) File";
            // 
            // dataSendBox
            // 
            this.dataSendBox.Controls.Add(this.labelForPORT);
            this.dataSendBox.Controls.Add(this.boxForPort);
            this.dataSendBox.Controls.Add(this.btnClearChat);
            this.dataSendBox.Controls.Add(this.btnSendChat);
            this.dataSendBox.Controls.Add(this.textBoxForSendChat);
            this.dataSendBox.Controls.Add(this.textBoxForChatView);
            this.dataSendBox.Controls.Add(this.labelForConnectedPC);
            this.dataSendBox.Controls.Add(this.labelForIPAddr);
            this.dataSendBox.Controls.Add(this.btnSameIP);
            this.dataSendBox.Controls.Add(this.btnOpen);
            this.dataSendBox.Controls.Add(this.boxForIPAddr);
            this.dataSendBox.Controls.Add(this.modeSelectBox);
            this.dataSendBox.Controls.Add(this.positionSelectBox);
            this.dataSendBox.Location = new System.Drawing.Point(13, 10);
            this.dataSendBox.Name = "dataSendBox";
            this.dataSendBox.Size = new System.Drawing.Size(537, 271);
            this.dataSendBox.TabIndex = 8;
            this.dataSendBox.TabStop = false;
            this.dataSendBox.Text = "데이터/전송";
            // 
            // labelForPORT
            // 
            this.labelForPORT.AutoSize = true;
            this.labelForPORT.Location = new System.Drawing.Point(239, 48);
            this.labelForPORT.Name = "labelForPORT";
            this.labelForPORT.Size = new System.Drawing.Size(50, 12);
            this.labelForPORT.TabIndex = 12;
            this.labelForPORT.Text = "PORT : ";
            // 
            // boxForPort
            // 
            this.boxForPort.Enabled = false;
            this.boxForPort.Location = new System.Drawing.Point(295, 45);
            this.boxForPort.Name = "boxForPort";
            this.boxForPort.Size = new System.Drawing.Size(123, 21);
            this.boxForPort.TabIndex = 11;
            this.boxForPort.Text = "8080";
            this.boxForPort.TextChanged += new System.EventHandler(this.boxForPort_TextChanged);
            // 
            // btnClearChat
            // 
            this.btnClearChat.Location = new System.Drawing.Point(424, 235);
            this.btnClearChat.Name = "btnClearChat";
            this.btnClearChat.Size = new System.Drawing.Size(88, 24);
            this.btnClearChat.TabIndex = 10;
            this.btnClearChat.Text = "Clear";
            this.btnClearChat.UseVisualStyleBackColor = true;
            this.btnClearChat.Click += new System.EventHandler(this.btnClearChat_Click);
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(253, 234);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(88, 25);
            this.btnSendChat.TabIndex = 9;
            this.btnSendChat.Text = "SEND";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // textBoxForSendChat
            // 
            this.textBoxForSendChat.Location = new System.Drawing.Point(10, 234);
            this.textBoxForSendChat.Name = "textBoxForSendChat";
            this.textBoxForSendChat.Size = new System.Drawing.Size(237, 25);
            this.textBoxForSendChat.TabIndex = 8;
            this.textBoxForSendChat.Text = "";
            this.textBoxForSendChat.TextChanged += new System.EventHandler(this.textBoxForSendChat_TextChanged);
            // 
            // textBoxForChatView
            // 
            this.textBoxForChatView.Location = new System.Drawing.Point(10, 99);
            this.textBoxForChatView.Name = "textBoxForChatView";
            this.textBoxForChatView.Size = new System.Drawing.Size(502, 129);
            this.textBoxForChatView.TabIndex = 7;
            this.textBoxForChatView.Text = "";
            this.textBoxForChatView.TextChanged += new System.EventHandler(this.textBoxForChatView_TextChanged);
            // 
            // labelForConnectedPC
            // 
            this.labelForConnectedPC.AutoSize = true;
            this.labelForConnectedPC.Location = new System.Drawing.Point(254, 71);
            this.labelForConnectedPC.Name = "labelForConnectedPC";
            this.labelForConnectedPC.Size = new System.Drawing.Size(0, 12);
            this.labelForConnectedPC.TabIndex = 6;
            // 
            // labelForIPAddr
            // 
            this.labelForIPAddr.AutoSize = true;
            this.labelForIPAddr.Location = new System.Drawing.Point(239, 25);
            this.labelForIPAddr.Name = "labelForIPAddr";
            this.labelForIPAddr.Size = new System.Drawing.Size(28, 12);
            this.labelForIPAddr.TabIndex = 5;
            this.labelForIPAddr.Text = "IP : ";
            // 
            // btnSameIP
            // 
            this.btnSameIP.Location = new System.Drawing.Point(430, 57);
            this.btnSameIP.Name = "btnSameIP";
            this.btnSameIP.Size = new System.Drawing.Size(101, 26);
            this.btnSameIP.TabIndex = 4;
            this.btnSameIP.Text = "동일 컴퓨터IP";
            this.btnSameIP.UseVisualStyleBackColor = true;
            this.btnSameIP.Click += new System.EventHandler(this.btnSameIP_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(430, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 26);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // boxForIPAddr
            // 
            this.boxForIPAddr.Enabled = false;
            this.boxForIPAddr.Location = new System.Drawing.Point(295, 22);
            this.boxForIPAddr.Name = "boxForIPAddr";
            this.boxForIPAddr.Size = new System.Drawing.Size(123, 21);
            this.boxForIPAddr.TabIndex = 2;
            this.boxForIPAddr.TextChanged += new System.EventHandler(this.boxForIPAddr_TextChanged);
            // 
            // modeSelectBox
            // 
            this.modeSelectBox.Controls.Add(this.multiToMultiBtn);
            this.modeSelectBox.Controls.Add(this.oneToOneBtn);
            this.modeSelectBox.Location = new System.Drawing.Point(123, 20);
            this.modeSelectBox.Name = "modeSelectBox";
            this.modeSelectBox.Size = new System.Drawing.Size(105, 68);
            this.modeSelectBox.TabIndex = 1;
            this.modeSelectBox.TabStop = false;
            this.modeSelectBox.Text = "Mode";
            // 
            // multiToMultiBtn
            // 
            this.multiToMultiBtn.AutoSize = true;
            this.multiToMultiBtn.Location = new System.Drawing.Point(6, 42);
            this.multiToMultiBtn.Name = "multiToMultiBtn";
            this.multiToMultiBtn.Size = new System.Drawing.Size(95, 16);
            this.multiToMultiBtn.TabIndex = 3;
            this.multiToMultiBtn.TabStop = true;
            this.multiToMultiBtn.Text = "Multi to Multi";
            this.multiToMultiBtn.UseVisualStyleBackColor = true;
            this.multiToMultiBtn.CheckedChanged += new System.EventHandler(this.multiToMultiBtn_CheckedChanged);
            // 
            // oneToOneBtn
            // 
            this.oneToOneBtn.AutoSize = true;
            this.oneToOneBtn.Checked = true;
            this.oneToOneBtn.Location = new System.Drawing.Point(6, 20);
            this.oneToOneBtn.Name = "oneToOneBtn";
            this.oneToOneBtn.Size = new System.Drawing.Size(87, 16);
            this.oneToOneBtn.TabIndex = 2;
            this.oneToOneBtn.TabStop = true;
            this.oneToOneBtn.Text = "One to One";
            this.oneToOneBtn.UseVisualStyleBackColor = true;
            this.oneToOneBtn.CheckedChanged += new System.EventHandler(this.oneToOneBtn_CheckedChanged);
            // 
            // positionSelectBox
            // 
            this.positionSelectBox.Controls.Add(this.clientBtn);
            this.positionSelectBox.Controls.Add(this.serverBtn);
            this.positionSelectBox.Location = new System.Drawing.Point(8, 20);
            this.positionSelectBox.Name = "positionSelectBox";
            this.positionSelectBox.Size = new System.Drawing.Size(105, 68);
            this.positionSelectBox.TabIndex = 0;
            this.positionSelectBox.TabStop = false;
            this.positionSelectBox.Text = "Server/Client";
            // 
            // clientBtn
            // 
            this.clientBtn.AutoSize = true;
            this.clientBtn.Location = new System.Drawing.Point(7, 42);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(55, 16);
            this.clientBtn.TabIndex = 1;
            this.clientBtn.TabStop = true;
            this.clientBtn.Text = "Client";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.CheckedChanged += new System.EventHandler(this.clientBtn_CheckedChanged);
            // 
            // serverBtn
            // 
            this.serverBtn.AutoSize = true;
            this.serverBtn.Location = new System.Drawing.Point(7, 20);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(59, 16);
            this.serverBtn.TabIndex = 0;
            this.serverBtn.TabStop = true;
            this.serverBtn.Text = "Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.CheckedChanged += new System.EventHandler(this.serverBtn_CheckedChanged);
            // 
            // MultiChat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 609);
            this.Controls.Add(this.fileSendBox);
            this.Controls.Add(this.dataSendBox);
            this.Name = "MultiChat2";
            this.Text = "NO.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fileSendBox.ResumeLayout(false);
            this.fileSendBox.PerformLayout();
            this.groupBoxForProgress.ResumeLayout(false);
            this.dataSendBox.ResumeLayout(false);
            this.dataSendBox.PerformLayout();
            this.modeSelectBox.ResumeLayout(false);
            this.modeSelectBox.PerformLayout();
            this.positionSelectBox.ResumeLayout(false);
            this.positionSelectBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fileSendBox;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.GroupBox groupBoxForProgress;
        private System.Windows.Forms.ProgressBar progressBarForFile;
        private System.Windows.Forms.Label labelForCountFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RichTextBox richTextBoxForReceiveFile;
        private System.Windows.Forms.Label labelForReceiveFile;
        private System.Windows.Forms.RichTextBox richTextBoxForSendFile;
        private System.Windows.Forms.Label labelForSendFile;
        private System.Windows.Forms.GroupBox dataSendBox;
        private System.Windows.Forms.Label labelForPORT;
        private System.Windows.Forms.TextBox boxForPort;
        private System.Windows.Forms.Button btnClearChat;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.RichTextBox textBoxForSendChat;
        private System.Windows.Forms.RichTextBox textBoxForChatView;
        private System.Windows.Forms.Label labelForConnectedPC;
        private System.Windows.Forms.Label labelForIPAddr;
        private System.Windows.Forms.Button btnSameIP;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox boxForIPAddr;
        private System.Windows.Forms.GroupBox modeSelectBox;
        private System.Windows.Forms.RadioButton multiToMultiBtn;
        private System.Windows.Forms.RadioButton oneToOneBtn;
        private System.Windows.Forms.GroupBox positionSelectBox;
        private System.Windows.Forms.RadioButton clientBtn;
        private System.Windows.Forms.RadioButton serverBtn;
    }
}

