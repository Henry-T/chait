using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChaitAppClient;

namespace ChaitPresClient
{
    public partial class PrivateForm : Form
    {
        public PrivateForm()
        {
            InitializeComponent();
        }

        // 安全访问控件
        private delegate void delUpdateChatContent(String str);
        private void updateChatContent(String str)
        {
            tb_chatHistory.AppendText(str + "\n");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            ChaitAppClient.ChaitClient.Instance.Chat(this.Text, tb_send.Text);
            tb_chatHistory.AppendText(ChaitClient.Instance.Neckname + "：" + tb_send.Text + "\n");
        }

        public void ShowChatMsg(String msg)
        {
            Invoke(new delUpdateChatContent(updateChatContent), msg);
        }

        private void btn_videoCmd_Click(object sender, EventArgs e)
        {
            if (btn_videoCmd.Text == "请求视频聊天")
            {
                ChaitClient.Instance.VideoRequest(this.Text, this.OnFrameReceivedHandler);
            }
            else if (btn_videoCmd.Text == "结束视频聊天")
            {
                ChaitClient.Instance.StopVideo(this.Text);
                btn_videoCmd.Text = "请求视频聊天";
            }
        }

        // 视频/非视频模式切换
        public void ToggleVideoMove(bool hasVideo)
        {
            if (hasVideo)
            {
                grb_video.Enabled = true;
                btn_videoCmd.Text = "结束视频聊天";
            }
            else
            {
                grb_video.Enabled = false;
                btn_videoCmd.Text = "请求视频聊天";
            }
        }

        // 显示接收到的视频
        public void OnFrameReceivedHandler(Bitmap frame)
        {
            Invoke(new DelUpdateOtherFrame(delUpdateOtherFrame), frame);
        }
        public delegate void DelUpdateOtherFrame(Bitmap frame);
        public void delUpdateOtherFrame(Bitmap frame)
        {
            ptb_otherVideo.Image = frame;
        }
    }
}
