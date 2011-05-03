namespace ChaitPresClient
{
    partial class PrivateForm
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
            this.tb_chatHistory = new System.Windows.Forms.TextBox();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_otherVideo = new System.Windows.Forms.PictureBox();
            this.ptb_selfVideo = new System.Windows.Forms.PictureBox();
            this.btn_videoCmd = new System.Windows.Forms.Button();
            this.grb_video = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_otherVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selfVideo)).BeginInit();
            this.grb_video.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_chatHistory
            // 
            this.tb_chatHistory.Location = new System.Drawing.Point(13, 29);
            this.tb_chatHistory.Multiline = true;
            this.tb_chatHistory.Name = "tb_chatHistory";
            this.tb_chatHistory.Size = new System.Drawing.Size(259, 307);
            this.tb_chatHistory.TabIndex = 0;
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(12, 343);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(185, 21);
            this.tb_send.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(202, 342);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(70, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "私聊消息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "对方";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "自己";
            // 
            // ptb_otherVideo
            // 
            this.ptb_otherVideo.Location = new System.Drawing.Point(9, 29);
            this.ptb_otherVideo.Name = "ptb_otherVideo";
            this.ptb_otherVideo.Size = new System.Drawing.Size(166, 143);
            this.ptb_otherVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_otherVideo.TabIndex = 4;
            this.ptb_otherVideo.TabStop = false;
            // 
            // ptb_selfVideo
            // 
            this.ptb_selfVideo.Location = new System.Drawing.Point(9, 195);
            this.ptb_selfVideo.Name = "ptb_selfVideo";
            this.ptb_selfVideo.Size = new System.Drawing.Size(166, 143);
            this.ptb_selfVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_selfVideo.TabIndex = 4;
            this.ptb_selfVideo.TabStop = false;
            // 
            // btn_videoCmd
            // 
            this.btn_videoCmd.Location = new System.Drawing.Point(323, 347);
            this.btn_videoCmd.Name = "btn_videoCmd";
            this.btn_videoCmd.Size = new System.Drawing.Size(100, 23);
            this.btn_videoCmd.TabIndex = 1;
            this.btn_videoCmd.Text = "请求视频聊天";
            this.btn_videoCmd.UseVisualStyleBackColor = true;
            this.btn_videoCmd.Click += new System.EventHandler(this.btn_videoCmd_Click);
            // 
            // grb_video
            // 
            this.grb_video.Controls.Add(this.ptb_otherVideo);
            this.grb_video.Controls.Add(this.ptb_selfVideo);
            this.grb_video.Controls.Add(this.label2);
            this.grb_video.Controls.Add(this.label3);
            this.grb_video.Location = new System.Drawing.Point(278, 3);
            this.grb_video.Name = "grb_video";
            this.grb_video.Size = new System.Drawing.Size(189, 343);
            this.grb_video.TabIndex = 5;
            this.grb_video.TabStop = false;
            this.grb_video.Text = "视频聊天";
            // 
            // PrivateForm
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 383);
            this.Controls.Add(this.grb_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_videoCmd);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.tb_chatHistory);
            this.Name = "PrivateForm";
            this.Text = "SingleChatForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_otherVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selfVideo)).EndInit();
            this.grb_video.ResumeLayout(false);
            this.grb_video.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.TextBox tb_chatHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptb_otherVideo;
        private System.Windows.Forms.Button btn_videoCmd;
        private System.Windows.Forms.GroupBox grb_video;
        public System.Windows.Forms.PictureBox ptb_selfVideo;
    }
}