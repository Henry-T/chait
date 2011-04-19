using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Drawing;

namespace ChaitAppClient.Video
{
    public class VideoMirror
    {
        // Variables
        public String OtherNeck;
        public IPEndPoint OtherEP;
        private UdpClient otherClient;

        public int ThisPort;
        private UdpClient thisClient;

        public bool IsReady{get; private set;}

        // 图像接收消息
        public delegate void OnFrameReceivedHandler(Bitmap frame);
        public event OnFrameReceivedHandler OnFrameReceivedEvent;

        public VideoMirror()
        {
            IsReady = false;
        }

        // 开始
        public void Begin()
        {
            IsReady = true;
            thisClient = new UdpClient(ThisPort );
            otherClient = new UdpClient(OtherEP);
            thisClient.BeginReceive(onReceive, null);
        }
        // 请求被拒绝时的清理
        public void Clear()
        {
            // 这里没有清理的必要，因为该对象将在VideoManager中被删除
            IsReady = false;
            if (thisClient != null)
            {
                thisClient.Close();
                thisClient = null;
            }
            if (otherClient != null)
            {
                otherClient.Close();
                otherClient.Close();
            }
        }
        private void onReceive(IAsyncResult ar)
        {
            // 获取单帧图片 ...
            Bitmap frame = new Bitmap(100,100);
            // ...
            if (OnFrameReceivedEvent != null)
                OnFrameReceivedEvent(frame);
        }

        // SendFrame
        public void SendData(byte[] data)
        {
            if(otherClient != null)
                otherClient.BeginSend(data, data.Length, OtherEP, null, null);
        }


        // 停止发送
        public void Stop()
        {
            otherClient.Close();
        }
    }
}
