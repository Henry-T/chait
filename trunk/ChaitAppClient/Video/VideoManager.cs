using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ChaitAppClient.Video
{
    /// <summary>
    /// 负责多个视频聊天回话的管理
    /// </summary>
    class VideoManager
    {
        // 端口号
        int usePort = 5567;

        // 视频设备接口
        AvicapManager capMgr;

        // 捕获发送计时器
        System.Timers.Timer capTimer;

        // 视频角色镜像
        public List<VideoMirror> videoList = new List<VideoMirror>();

        // 初始化捕获设备
        public void InitCapture(IntPtr handle, int width, int height)
        {
            capTimer = new System.Timers.Timer(1000);
            capTimer.Elapsed += new ElapsedEventHandler(capTimer_Elapsed);
            capTimer.Start();
            capMgr = new AvicapManager(handle, width, height);
            capMgr.Start();
            capMgr.Test();

            // 测试用 - 本机多实例
            Random r = new Random((int)DateTime.Now.Ticks);
            usePort = r.Next(3000, 8000);
        }

        // 开始视频聊天会话
        public int BeginVideoAsSource(String tgtNeck, VideoMirror.OnFrameReceivedHandler onFRH)
        {
            foreach (VideoMirror vs in videoList)
            {
                if (tgtNeck == vs.OtherNeck)
                {
                    throw new Exception("视频连接重复！");
                }
            }
            VideoMirror newSource = new VideoMirror();
            newSource.OnFrameReceivedEvent += onFRH;
            newSource.OtherNeck = tgtNeck;
            int srcPort = getNextPort();
            newSource.ThisPort = srcPort;
            videoList.Add(newSource);

            return srcPort;
        }
        public int BeginVideoAsTarget(IPEndPoint srcEP, String srcNeck)
        {
            foreach (VideoMirror vr in videoList)
            {
                if (srcNeck == vr.OtherNeck)
                {
                    throw new Exception("视频连接重复！");
                }
            }
            VideoMirror newTarget = new VideoMirror();
            newTarget.OtherEP = srcEP;
            newTarget.OtherNeck = srcNeck;
            int tgtPort = getNextPort();
            newTarget.ThisPort = tgtPort;
            videoList.Add(newTarget);

            return tgtPort;
        }

        // 开始发送和接收 - 在必要参数都设定完毕的情况下才能够调用
        // 1. 主动方接收到视频许可 
        public void Begin(String otherNeck, String otherIP, int otherPort)
        {
            foreach (VideoMirror vm in videoList)
            {
                if (vm.OtherNeck == otherNeck)
                {
                    vm.OtherEP = new IPEndPoint(IPAddress.Parse(otherIP), otherPort);
                    vm.Begin();
                }
            }
        }
        // 2.被动方接收视频请求时
        public void Begin(String otherNeck, VideoMirror.OnFrameReceivedHandler onFRH)
        {
            foreach (VideoMirror vm in videoList)
            {
                if (vm.OtherNeck == otherNeck)
                {
                    vm.OnFrameReceivedEvent += onFRH;
                    vm.Begin();
                }
            }
        } 
        // 在视频请求被拒绝时清理视频模块
        public void Clear(String targetNeck)
        {
            for (int i = 0; i < videoList.Count; i++)
            {
                if (videoList[i].OtherNeck == targetNeck)
                {
                    videoList[i].Clear();
                    videoList.RemoveAt(i);
                }
            }
        }

        // 停止接收
        public void StopReceive(String otherNeck)
        {
            for(int i =0;i<videoList.Count; i++)
            {
                if (videoList[i].OtherNeck == otherNeck)
                {
                    videoList[i].Stop();
                    videoList.RemoveAt(i); 
                    return;
                }
            }
        }

        // 停止发送
        public void StopSend(String receiverNeck)
        {
            for (int i = 0; i < videoList.Count; i++)
            {
                if (videoList[i].OtherNeck == receiverNeck)
                {
                    videoList[i].Stop();
                    videoList.RemoveAt(i);
                    return;
                }
            }
        }

        private void capTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Bitmap frame = capMgr.GrabImage();
            MemoryStream ms = new MemoryStream();
            frame.Save(ms, ImageFormat.Bmp);
            byte[] data = ms.GetBuffer();
            foreach (VideoMirror vs in videoList)
            {
                if (vs.IsReady)
                {
                    vs.SendData(data);
                }
            }
        }

        // 获取下一个端口 
        // TODO 增加空闲端口扫描功能
        private int getNextPort()
        {
            return usePort++;
        }
    }
}
