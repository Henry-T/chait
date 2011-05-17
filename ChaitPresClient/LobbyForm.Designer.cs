namespace ChaitPresClient
{
    partial class LobbyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_neckName = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_chatHistory = new System.Windows.Forms.TextBox();
            this.lsb_friends = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.btn_sendFile = new System.Windows.Forms.Button();
            this.sts_fileReceive = new System.Windows.Forms.StatusStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_serverPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_serverIP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_localIP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sendPause = new System.Windows.Forms.Button();
            this.btn_sendStop = new System.Windows.Forms.Button();
            this.sts_fileSend = new System.Windows.Forms.StatusStrip();
            this.btn_receiveStop = new System.Windows.Forms.Button();
            this.btn_receivePause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_groupName = new System.Windows.Forms.TextBox();
            this.btn_joinGroup = new System.Windows.Forms.Button();
            this.lsb_groups = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_capHolder = new System.Windows.Forms.PictureBox();
            this.ptb_myFace = new System.Windows.Forms.PictureBox();
            this.tmr_testVideo = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.tb_portBase = new System.Windows.Forms.TextBox();
            this.btn_changePortBase = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_myFace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称";
            // 
            // tb_neckName
            // 
            this.tb_neckName.Location = new System.Drawing.Point(803, 134);
            this.tb_neckName.Name = "tb_neckName";
            this.tb_neckName.Size = new System.Drawing.Size(108, 21);
            this.tb_neckName.TabIndex = 1;
            this.tb_neckName.Text = "FF14";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(925, 132);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_chatHistory
            // 
            this.tb_chatHistory.Location = new System.Drawing.Point(6, 30);
            this.tb_chatHistory.Multiline = true;
            this.tb_chatHistory.Name = "tb_chatHistory";
            this.tb_chatHistory.Size = new System.Drawing.Size(297, 241);
            this.tb_chatHistory.TabIndex = 3;
            // 
            // lsb_friends
            // 
            this.lsb_friends.FormattingEnabled = true;
            this.lsb_friends.ItemHeight = 12;
            this.lsb_friends.Location = new System.Drawing.Point(309, 30);
            this.lsb_friends.Name = "lsb_friends";
            this.lsb_friends.Size = new System.Drawing.Size(132, 268);
            this.lsb_friends.TabIndex = 4;
            this.lsb_friends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsb_friends_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "朋友 [双击私聊]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "大厅聊天";
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(6, 279);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(215, 21);
            this.tb_send.TabIndex = 1;
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.Enabled = false;
            this.btn_sendMsg.Location = new System.Drawing.Point(227, 277);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendMsg.TabIndex = 2;
            this.btn_sendMsg.Text = "大厅消息";
            this.btn_sendMsg.UseVisualStyleBackColor = true;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // btn_sendFile
            // 
            this.btn_sendFile.Enabled = false;
            this.btn_sendFile.Location = new System.Drawing.Point(88, 19);
            this.btn_sendFile.Name = "btn_sendFile";
            this.btn_sendFile.Size = new System.Drawing.Size(37, 23);
            this.btn_sendFile.TabIndex = 2;
            this.btn_sendFile.Text = "请求";
            this.btn_sendFile.UseVisualStyleBackColor = true;
            this.btn_sendFile.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // sts_fileReceive
            // 
            this.sts_fileReceive.Location = new System.Drawing.Point(0, 588);
            this.sts_fileReceive.Name = "sts_fileReceive";
            this.sts_fileReceive.Size = new System.Drawing.Size(1008, 22);
            this.sts_fileReceive.TabIndex = 5;
            this.sts_fileReceive.Text = "sts_receive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "端口";
            // 
            // tb_serverPort
            // 
            this.tb_serverPort.Location = new System.Drawing.Point(203, 12);
            this.tb_serverPort.Name = "tb_serverPort";
            this.tb_serverPort.Size = new System.Drawing.Size(38, 21);
            this.tb_serverPort.TabIndex = 1;
            this.tb_serverPort.Text = "1048";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_serverIP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_serverPort);
            this.groupBox1.Location = new System.Drawing.Point(751, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "聊天服务器";
            // 
            // cbb_serverIP
            // 
            this.cbb_serverIP.FormattingEnabled = true;
            this.cbb_serverIP.Location = new System.Drawing.Point(54, 13);
            this.cbb_serverIP.Name = "cbb_serverIP";
            this.cbb_serverIP.Size = new System.Drawing.Size(108, 20);
            this.cbb_serverIP.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_localIP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(751, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 39);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件传递";
            // 
            // cbb_localIP
            // 
            this.cbb_localIP.FormattingEnabled = true;
            this.cbb_localIP.Location = new System.Drawing.Point(51, 13);
            this.cbb_localIP.Name = "cbb_localIP";
            this.cbb_localIP.Size = new System.Drawing.Size(108, 20);
            this.cbb_localIP.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "本地IP";
            // 
            // btn_sendPause
            // 
            this.btn_sendPause.Enabled = false;
            this.btn_sendPause.Location = new System.Drawing.Point(131, 19);
            this.btn_sendPause.Name = "btn_sendPause";
            this.btn_sendPause.Size = new System.Drawing.Size(37, 23);
            this.btn_sendPause.TabIndex = 2;
            this.btn_sendPause.Text = "暂停";
            this.btn_sendPause.UseVisualStyleBackColor = true;
            this.btn_sendPause.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // btn_sendStop
            // 
            this.btn_sendStop.Enabled = false;
            this.btn_sendStop.Location = new System.Drawing.Point(174, 19);
            this.btn_sendStop.Name = "btn_sendStop";
            this.btn_sendStop.Size = new System.Drawing.Size(37, 23);
            this.btn_sendStop.TabIndex = 2;
            this.btn_sendStop.Text = "停止";
            this.btn_sendStop.UseVisualStyleBackColor = true;
            this.btn_sendStop.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // sts_fileSend
            // 
            this.sts_fileSend.Location = new System.Drawing.Point(0, 566);
            this.sts_fileSend.Name = "sts_fileSend";
            this.sts_fileSend.Size = new System.Drawing.Size(1008, 22);
            this.sts_fileSend.TabIndex = 7;
            this.sts_fileSend.Text = "sts_send";
            // 
            // btn_receiveStop
            // 
            this.btn_receiveStop.Enabled = false;
            this.btn_receiveStop.Location = new System.Drawing.Point(131, 45);
            this.btn_receiveStop.Name = "btn_receiveStop";
            this.btn_receiveStop.Size = new System.Drawing.Size(37, 23);
            this.btn_receiveStop.TabIndex = 2;
            this.btn_receiveStop.Text = "停止";
            this.btn_receiveStop.UseVisualStyleBackColor = true;
            this.btn_receiveStop.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // btn_receivePause
            // 
            this.btn_receivePause.Enabled = false;
            this.btn_receivePause.Location = new System.Drawing.Point(88, 45);
            this.btn_receivePause.Name = "btn_receivePause";
            this.btn_receivePause.Size = new System.Drawing.Size(37, 23);
            this.btn_receivePause.TabIndex = 2;
            this.btn_receivePause.Text = "暂停";
            this.btn_receivePause.UseVisualStyleBackColor = true;
            this.btn_receivePause.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "文件发送";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "文件接收";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tb_groupName);
            this.groupBox3.Controls.Add(this.btn_joinGroup);
            this.groupBox3.Controls.Add(this.tb_chatHistory);
            this.groupBox3.Controls.Add(this.lsb_groups);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lsb_friends);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_send);
            this.groupBox3.Controls.Add(this.btn_sendMsg);
            this.groupBox3.Location = new System.Drawing.Point(110, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 456);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "聊天";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "名称";
            // 
            // tb_groupName
            // 
            this.tb_groupName.Location = new System.Drawing.Point(484, 29);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.Size = new System.Drawing.Size(90, 21);
            this.tb_groupName.TabIndex = 6;
            // 
            // btn_joinGroup
            // 
            this.btn_joinGroup.Enabled = false;
            this.btn_joinGroup.Location = new System.Drawing.Point(447, 52);
            this.btn_joinGroup.Name = "btn_joinGroup";
            this.btn_joinGroup.Size = new System.Drawing.Size(128, 23);
            this.btn_joinGroup.TabIndex = 5;
            this.btn_joinGroup.Text = "创建/加入";
            this.btn_joinGroup.UseVisualStyleBackColor = true;
            this.btn_joinGroup.Click += new System.EventHandler(this.btn_joinGroup_Click);
            // 
            // lsb_groups
            // 
            this.lsb_groups.FormattingEnabled = true;
            this.lsb_groups.ItemHeight = 12;
            this.lsb_groups.Location = new System.Drawing.Point(447, 77);
            this.lsb_groups.Name = "lsb_groups";
            this.lsb_groups.Size = new System.Drawing.Size(129, 220);
            this.lsb_groups.TabIndex = 4;
            this.lsb_groups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsb_groups_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "群组 [双击加入]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_sendFile);
            this.groupBox4.Controls.Add(this.btn_sendPause);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_sendStop);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btn_receiveStop);
            this.groupBox4.Controls.Add(this.btn_receivePause);
            this.groupBox4.Location = new System.Drawing.Point(751, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 72);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文件传递";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_capHolder
            // 
            this.ptb_capHolder.Location = new System.Drawing.Point(761, 200);
            this.ptb_capHolder.Name = "ptb_capHolder";
            this.ptb_capHolder.Size = new System.Drawing.Size(91, 79);
            this.ptb_capHolder.TabIndex = 12;
            this.ptb_capHolder.TabStop = false;
            // 
            // ptb_myFace
            // 
            this.ptb_myFace.Location = new System.Drawing.Point(881, 200);
            this.ptb_myFace.Name = "ptb_myFace";
            this.ptb_myFace.Size = new System.Drawing.Size(91, 79);
            this.ptb_myFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_myFace.TabIndex = 13;
            this.ptb_myFace.TabStop = false;
            // 
            // tmr_testVideo
            // 
            this.tmr_testVideo.Enabled = true;
            this.tmr_testVideo.Interval = 50;
            this.tmr_testVideo.Tick += new System.EventHandler(this.tmr_testVideo_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(759, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "视频端口基数";
            // 
            // tb_portBase
            // 
            this.tb_portBase.Location = new System.Drawing.Point(840, 56);
            this.tb_portBase.Name = "tb_portBase";
            this.tb_portBase.Size = new System.Drawing.Size(71, 21);
            this.tb_portBase.TabIndex = 15;
            this.tb_portBase.Text = "4000";
            // 
            // btn_changePortBase
            // 
            this.btn_changePortBase.Location = new System.Drawing.Point(926, 56);
            this.btn_changePortBase.Name = "btn_changePortBase";
            this.btn_changePortBase.Size = new System.Drawing.Size(75, 23);
            this.btn_changePortBase.TabIndex = 16;
            this.btn_changePortBase.Text = "修改";
            this.btn_changePortBase.UseVisualStyleBackColor = true;
            this.btn_changePortBase.Click += new System.EventHandler(this.btn_changePortBase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(759, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "视频测试";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(843, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "Chait游戏平台";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(872, 543);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "by Tankid";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(3, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 207);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "热门游戏";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(3, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(548, 338);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "最新游戏";
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 610);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_changePortBase);
            this.Controls.Add(this.tb_portBase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ptb_myFace);
            this.Controls.Add(this.tb_neckName);
            this.Controls.Add(this.ptb_capHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.sts_fileSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sts_fileReceive);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "LobbyForm";
            this.Text = "ChaitPlatform - 聊天大厅";
            this.Load += new System.EventHandler(this.LobbyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_myFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_neckName;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_chatHistory;
        private System.Windows.Forms.ListBox lsb_friends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.Button btn_sendFile;
        private System.Windows.Forms.StatusStrip sts_fileReceive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_serverPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sendPause;
        private System.Windows.Forms.Button btn_sendStop;
        private System.Windows.Forms.StatusStrip sts_fileSend;
        private System.Windows.Forms.Button btn_receiveStop;
        private System.Windows.Forms.Button btn_receivePause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsb_groups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_groupName;
        private System.Windows.Forms.Button btn_joinGroup;
        private System.Windows.Forms.ComboBox cbb_serverIP;
        private System.Windows.Forms.PictureBox ptb_capHolder;
        private System.Windows.Forms.PictureBox ptb_myFace;
        private System.Windows.Forms.Timer tmr_testVideo;
        private System.Windows.Forms.ComboBox cbb_localIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_portBase;
        private System.Windows.Forms.Button btn_changePortBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

