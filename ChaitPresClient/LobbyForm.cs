using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using ChaitAppClient;
using ChaitAppClient.Video;

namespace ChaitPresClient
{
    public partial class LobbyForm : Form
    {
        Dictionary<String, PrivateForm> privateChatForms = new Dictionary<string, PrivateForm>();
        Dictionary<String, GroupForm> groupChatForms = new Dictionary<string, GroupForm>();

        public LobbyForm()
        {
            InitializeComponent();

            IPAddress[] ips = Dns.GetHostAddresses(Environment.MachineName);
            for (int i = 0; i < ips.Length; i++)
            {
                if (ips[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    cbb_serverIP.Items.Add(ips[i]);
                }
            }
            if (cbb_serverIP.Items.Count != 0)
            {
                cbb_serverIP.SelectedIndex = 0;
            }

            // 初始化视频聊天模块
            ChaitClient.Instance.InitVideo(ptb_capHolder.Handle);
        }
        
        // UI事件处理
        private void btn_connect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "连接")
            {
                IPAddress serverIP;
                if (!IPAddress.TryParse(cbb_serverIP.Text.Trim(), out serverIP))
                {
                    MessageBox.Show("请输入一个合法的服务器IP地址");
                    return;
                }
                int serverPort;
                if (!int.TryParse(tb_serverPort.Text.Trim(), out serverPort))
                {
                    MessageBox.Show("请输入一个合法的服务器端口");
                    return;
                }
                IPAddress localIP;
                if (!IPAddress.TryParse(tb_localIP.Text.Trim(), out localIP))
                {
                    MessageBox.Show("请输入一个合法的本地IP");
                    return;
                }
                String neckName = tb_neckName.Text.Trim();
                if (neckName == "")
                {
                    MessageBox.Show("请输入昵称");
                    return;
                }
                try
                {
                    ChaitClient.Instance.Join(serverIP, serverPort, neckName, localIP);
                    ChaitClient.Instance.OnServerStopEvent += onServerStopHandler;
                    ChaitClient.Instance.OnKickEvent += onKickHandler;
                    ChaitClient.Instance.OnNeckExistEvent += onNeckExistHandler;
                    ChaitClient.Instance.OnDisconnectEvent += onDisconnectHandler;
                    ChaitClient.Instance.OnJoinEvent += onJoinHandler;
                    ChaitClient.Instance.OnQuitEvent += onQuitHandler;
                    ChaitClient.Instance.OnNeckListEvent += onNeckListHandler;
                    ChaitClient.Instance.OnLobbyChatEvent += onLobbyChatHandler;
                    ChaitClient.Instance.OnChatEvent += onChatHandler;
                    ChaitClient.Instance.OnJoinGroupEvent += onJoinGroupHandler;
                    ChaitClient.Instance.OnQuitGroupEvent += onQuitGroupHandler;
                    ChaitClient.Instance.OnGroupListEvent += onGroupListHandler;
                    ChaitClient.Instance.OnYellEvent += onYellHandler;
                    ChaitClient.Instance.OnFileRequestEvent += onFileRequestHandler;
                    ChaitClient.Instance.OnVideoRequestEvent += onVideoRequest;
                    ChaitClient.Instance.OnVideoAcceptEvent += onVideoAccepted;
                    ChaitClient.Instance.OnVideoRefuseEvent += onVideoRefused;
                    ChaitClient.Instance.OnVideoStopEvent += onVideoStop;
                    ChaitClient.Instance.OnErrorEvent += onChatErrorHandler;

                    ChaitClient.Instance.fileSender.OnFSSendingEvent += onFSSendingHandler;
                    ChaitClient.Instance.fileSender.OnFSSendDoneEvent += onFSSendDoneHandler;
                    ChaitClient.Instance.fileSender.OnFSErrorEvent += onFSErrorHandler;
                    ChaitClient.Instance.fileReciever.OnFRReceivingEvent += onFRReceivingHandler;
                    ChaitClient.Instance.fileSender.OnFSSendDoneEvent += onFSSendDoneHandler;
                    ChaitClient.Instance.fileReciever.OnFRErrorEvent += onFRErrorHandler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                // 获取在线好友列表
                // ChaitClient.Instance.NeckList(); // TODO 问题：无法同时获取两个列表，后一条请求信息丢失
                // 获取群组列表
                // ChaitClient.Instance.GroupList();

                btn.Text = "断开";
                btn_sendFile.Enabled = true;
                btn_sendMsg.Enabled = true;
            }
            else
            {
                try
                {
                    ChaitClient.Instance.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                btn.Text = "连接";
                btn_sendFile.Enabled = false;
                btn_sendMsg.Enabled = false;

            }
        }
        private void btn_sendMsg_Click(object sender, EventArgs e)
        {
            if (tb_send.Text.Trim() == "")
            {
                MessageBox.Show("请输入聊天内容");
                return;
            }
            ChaitClient.Instance.LobbyChat(tb_send.Text);
        }
        private void btn_sendFile_Click(object sender, EventArgs e)
        {
            if (lsb_friends.SelectedItem == null)
            {
                MessageBox.Show("请选择一个发送对象");
                return;
            }
            String fileReceiverNeck = System.Convert.ToString(lsb_friends.SelectedItem);

            OpenFileDialog sendFileDlg = new OpenFileDialog();
            if (sendFileDlg.ShowDialog() == DialogResult.OK)
            {
                String safeFileName = sendFileDlg.SafeFileName;
                String sendFilePath = sendFileDlg.FileName;
                ChaitClient.Instance.FileRequest(fileReceiverNeck, safeFileName, sendFilePath);
            }
        }
        private void lsb_friends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lsb_friends.SelectedItem == null ||
                lsb_friends.SelectedItem.ToString() == null)
            {
                return;
            }
            String chatNeck = lsb_friends.SelectedItem.ToString();

            if (privateChatForms.Keys.Contains(chatNeck))
            {
                privateChatForms[chatNeck].BringToFront();
            }
            else
            {
                PrivateForm pf = new PrivateForm();
                pf.Text = chatNeck;
                privateChatForms.Add(chatNeck, pf);
                pf.Show();
            }
        }

        private void btn_joinGroup_Click(object sender, EventArgs e)
        {
            // TODO 完善用户权限
        }

        private void lsb_groups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsb_groups.SelectedItem == null ||
                lsb_groups.SelectedItem.ToString() == null)
            {
                return;
            }
            String groupName = lsb_groups.SelectedItem.ToString();
            ChaitClient.Instance.JoinGroup(groupName);

            if (groupChatForms.Keys.Contains(groupName))
            {
                groupChatForms[groupName].BringToFront();
            }
            else
            {
                GroupForm gcf = new GroupForm();
                gcf.Text = groupName;
                groupChatForms.Add(groupName, gcf);
                gcf.Show();
            }
        }

        // 安全访问控件委托
        private delegate void delUpdateLobbyChatContent(String str);
        private void updateLobbyChatContent(String str)
        {
            tb_chatHistory.AppendText(str + "\n");
        }
        private delegate PrivateForm delCreatePrivateForm(String neckname);
        private PrivateForm createPrivateForm(String neckname)
        {
            PrivateForm pf = new PrivateForm();
            pf.Text = neckname;
            privateChatForms.Add(neckname, pf);
            pf.Show();
            return pf;
        }

        private delegate void delUpdatePrivateForm(String neckname, String chatString);
        private void updatePrivateForm(String neckname, String chatString)
        {
            privateChatForms[neckname].ShowChatMsg(neckname + "：" + chatString + "\n");
        }

        private delegate void delCreateGroupForm(String groupName);
        private void createGroupForm(String groupName)
        {
        }

        private delegate void delUpdateGroupForm(String groupName, String chatStr);
        private void updateGroupForm(String groupName, String chatStr)
        {
            groupChatForms[groupName].ShowChatMsg(chatStr);
        }

        private delegate void delSwitchMemberListItem(String groupName, String neckname);
        private void switchMemberListItem(String groupName, String neckname)
        {
            groupChatForms[groupName].SwitchMember(neckname);
        }

        private delegate void delUpdateStatusStrip(StatusStrip statusStrip, String str);
        private void updateStatusStrip(StatusStrip statusStrip, String str)
        {
            statusStrip.Text = str;
        }

        private delegate void delShowError(String errorStr);
        private void showError(String errorStr)
        {
            MessageBox.Show(errorStr, "错误");
        }

        private delegate void delSwitchNameListItem(String neckname);
        private void switchNameListItem(String neckname)
        {
            if (lsb_friends.Items.Contains(neckname))
            {
                lsb_friends.Items.Remove(neckname);
            }
            else
            {
                lsb_friends.Items.Add(neckname);
            }
        }

        private delegate void delUpdateNeckList(List<String> neckList);
        private void updateNeckList(List<String> neckList)
        {
            lsb_friends.Items.Clear();
            foreach (String neckname in neckList)
            {
                if(neckname != ChaitClient.Instance.Neckname)
                    lsb_friends.Items.Add(neckname);
            }
        }

        private delegate void delUpdateGroupList(List<String> groupList);
        private void updateGroupList(List<String> groupList)
        {
            lsb_groups.Items.Clear();
            foreach (String groupName in groupList)
            {
                lsb_groups.Items.Add(groupName);
            }
        }

        private delegate void delShowMessageBox(ref DialogResult dr, String text, String caption, MessageBoxButtons messageBoxButtons);
        private void showMessageBox(ref DialogResult dr, String text, String caption, MessageBoxButtons messageBoxButtons)
        {
            dr = MessageBox.Show(text, caption, messageBoxButtons);
        }

        // 协议事件委托
        private void onServerStopHandler()
        {
            MessageBox.Show("服务器已关闭");
        }
        private void onKickHandler(String neckname)
        {
            String str;
            if (neckname == ChaitClient.Instance.Neckname)
            {
                str = "[系统]你已被踢出聊天室";
            }
            else
            {
                str = "[系统]"+neckname + "因违反规则被踢出聊天室";
            }
            Invoke(new delUpdateLobbyChatContent(updateLobbyChatContent), str);
        }
        private void onNeckExistHandler()
        {
            MessageBox.Show("[系统]你选择的昵称已被使用，请重新选择后再登陆");
        }
        private void onDisconnectHandler()
        {
            MessageBox.Show("[系统]连接已断开");
        }
        private void onJoinHandler(String neckName)
        {
            String str;
            if(neckName == ChaitClient.Instance.Neckname)
            {
                str = "[系统]欢迎加入聊天室";
            }
            else
            {
                str ="[系统]" + neckName + "加入了聊天室";
                Invoke(new delSwitchNameListItem(switchNameListItem), neckName);
            }
            Invoke(new delUpdateLobbyChatContent(updateLobbyChatContent), str);
        }
        private void onQuitHandler(String neckName)
        {
            String str = "[系统]"+neckName + "离开了聊天室";
            Invoke(new delUpdateLobbyChatContent(updateLobbyChatContent), str);
        }
        private void onNeckListHandler(List<String> neckList)
        {
            Invoke(new delUpdateNeckList(updateNeckList), neckList);
        }
        private void onLobbyChatHandler(String neckName, String chatStr)
        {
            String str = neckName + "：" + chatStr;
            Invoke(new delUpdateLobbyChatContent(updateLobbyChatContent), str);
        }
        private void onChatHandler(String neckname, String chatStr)
        {
            if (!privateChatForms.Keys.Contains(neckname))
            {
                Invoke(new delCreatePrivateForm(createPrivateForm), neckname);  // TODO 用户体验不好，需改善
            }
            else
            {
               // privateChatForms[neckName].BringToFront();    // TODO 用户体验不好，需改善
            }

            Invoke(new delUpdatePrivateForm(updatePrivateForm),neckname, chatStr);
        }
        private void onJoinGroupHandler(String neckName, String groupName)
        {
            String str;
            if (!groupChatForms.Keys.Contains(groupName))
            {
                Invoke(new delCreateGroupForm(createGroupForm), groupName);
            }
            if(neckName == ChaitClient.Instance.Neckname)
            {
                str = "[系统]欢迎加入群组"+groupName;
            }
            else
            {
                str = "[系统]" + neckName + "加入了群组: " + groupName;
                Invoke(new delSwitchMemberListItem(switchMemberListItem), groupName, neckName);
            }
            Invoke(new delUpdateGroupForm(updateGroupForm),groupName, str);
        }
        private void onQuitGroupHandler(String neckName, String groupName)
        {
            String str = "[系统]" + neckName + "离开了群组：" + groupName;
            Invoke(new delUpdateLobbyChatContent(updateLobbyChatContent), str);
        }
        private void onGroupListHandler(List<String> groupList)
        {
            Invoke(new delUpdateGroupList(updateGroupList), groupList);
        }
        private void onYellHandler(String groupName, String neckName, String yellStr)
        {
            String str = neckName + "：" + yellStr;
            Invoke(new delUpdateGroupForm(updateGroupForm), groupName, str);
        }
        private void onFileRequestHandler(String senderNeck, String fileName)
        {
            String mbStr = senderNeck + "想要向你发送文件'" + fileName + "'，是否接受？";

            DialogResult dr = DialogResult.No;
            Invoke(new delShowMessageBox(showMessageBox), dr, mbStr, "文件发送请求", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.RestoreDirectory = true;
                sfd.FileName = fileName;

                DialogResult fdr = sfd.ShowDialog();

                if (fdr == System.Windows.Forms.DialogResult.OK)
                {
                    ChaitClient.Instance.AcceptFile(senderNeck, fileName, sfd.FileName);
                }
                else
                {
                    ChaitClient.Instance.RefuseFile(senderNeck, fileName);
                }
            }
            else
            {
                ChaitClient.Instance.RefuseFile(senderNeck, fileName);
            }
        }
        private void onChatErrorHandler(String errorStr)
        {
            Invoke(new delShowError(showError), "聊天系统错误：" + errorStr);
        }
        private void onFSSendingHandler(String receiverNeck, String fileName, String sourcePath, int bytesSended)
        {
            Invoke(new delUpdateStatusStrip(updateStatusStrip),
                sts_fileReceive, "从" + receiverNeck + "发送文件" + fileName + "：" + bytesSended + "...");
            Application.DoEvents(); // TODO 有什么作用?
        }
        private void onFSSendDoneHandler(String receiverNeck, String fileName, String sourcePath)
        {
            Invoke(new delUpdateStatusStrip(updateStatusStrip),
                sts_fileReceive, "向" + receiverNeck + "发送文件" + fileName + "：完成");
            Application.DoEvents(); // TODO 有什么作用?
        }
        private void onFSErrorHandler(String errorStr)
        {
            Invoke(new delShowError(showError), "文件发送系统错误：" + errorStr);
        }
        private void onFRReceivingHandler(String senderNeck, String fileName, String savePath, int bytesReceiveed)
        {
            Invoke(new delUpdateStatusStrip(updateStatusStrip), sts_fileReceive, "从" + senderNeck + "接收文件" + fileName + "：" + bytesReceiveed + "...");
            Application.DoEvents(); // TODO 有什么作用?
        }
        private void onFRReceiveDoneHandler(String senderNeck, String fileName, String savePath)
        {
            Invoke(new delUpdateStatusStrip(updateStatusStrip), sts_fileReceive, "从" + senderNeck + "接收文件" + fileName + "：完成");
            Application.DoEvents(); // TODO 有什么作用?
        }
        private void onVideoRequest(String srcNeck, String otherIP, int otherPort)
        {
            Invoke(new DelVideoRequest(delVideoRequest), srcNeck, otherIP, otherPort);
        }
        private delegate void DelVideoRequest(String srcNeck, String otherIP, int otherPort);
        private void delVideoRequest(String srcNeck, String otherIP, int otherPort)
        {
            DialogResult dr = 
                MessageBox.Show("来自：" + srcNeck, "视频聊天请求", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                PrivateForm pf = null;
                if (privateChatForms.Keys.Contains(srcNeck))
                {
                    pf = privateChatForms[srcNeck];
                }
                else
                {
                    pf = createPrivateForm(srcNeck);
                }
                pf.ToggleVideoMove(true);
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(otherIP), otherPort);
                ChaitClient.Instance.AcceptVideo(ep, srcNeck, pf.OnFrameReceivedHandler);
            }
            else
            {
                ChaitClient.Instance.RefuseVideo(srcNeck);
            }
        }

        private void onVideoAccepted(String targetNeck, String otherIP, int otherPort)
        {
            // 获取私聊窗口
            PrivateForm pf = null;
            if (privateChatForms.Keys.Contains(targetNeck))
            {
                pf = privateChatForms[targetNeck];
            }
            else
            {
                pf = createPrivateForm(targetNeck);
            }
            pf.ToggleVideoMove(true);
            // 
            ChaitClient.Instance.BeginVideo(targetNeck, otherIP, otherPort);
        }
        private void onVideoRefused(String targetNeck)
        {
            ChaitClient.Instance.ClearVideo(targetNeck);
            Invoke(new delShowMessageBox(showMessageBox), new DialogResult(), "请求被拒绝", "视频聊天", MessageBoxButtons.OK);
        }
        private void onVideoStop(String otherNeck)
        {
            // 停止视频模块
            ChaitClient.Instance.ClearVideo(otherNeck);
            // 切换到非视频UI
            for (int i = 0; i < privateChatForms.Count; i++)
            {
                if (privateChatForms[otherNeck].Text == otherNeck)
                {
                    privateChatForms[otherNeck].ToggleVideoMove(false);
                    return;
                }
            }
        }
        private void onFRErrorHandler(String errorStr)
        {
            Invoke(new delShowError(showError), "文件接收系统错误：" + errorStr);
        }
    }
}