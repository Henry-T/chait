using System;
using System.Collections.Generic;
using ChaitAppProtocol;
using ChaitAppClient.Video;
using System.Net;
namespace ChaitAppClient
{
    public partial class ChaitClient
    {
        // Variables
        VideoManager VideoMgr;

        public void InitVideo(IntPtr handle)
        {
            VideoMgr = new VideoManager();
            VideoMgr.InitCapture(handle, 100, 100);
        }

        #region 协议回调 - 视频
        // 视频请求事件
        public delegate void OnVideoRequestHandler(String neckname, String otherIP, int otherPort);
        public event OnVideoRequestHandler OnVideoRequestEvent;
        // 接受请求事件
        public delegate void OnVideoAcceptHandler(String neckname, String otherIP, int otherPort);
        public event OnVideoAcceptHandler OnVideoAcceptEvent;
        // 拒绝请求事件
        public delegate void OnVideoRefuseHandler(String neckname);
        public event OnVideoRefuseHandler OnVideoRefuseEvent;
        // 结束视频事件
        public delegate void OnVideoStopHandler(String neckname);
        public event OnVideoStopHandler OnVideoStopEvent;
        #endregion

        #region 客户端行为 - 视频
        public void VideoRequest(String targetNeck, VideoMirror.OnFrameReceivedHandler onFRH)
        {
            // 视频首发准备
            int srcPort = VideoMgr.BeginVideoAsSource(targetNeck, onFRH);
            // 发送请求消息
            String dataStr = System.Convert.ToChar(CProtocol.VideoRequest).ToString();
            dataStr += ((char)System.Text.Encoding.UTF8.GetBytes(targetNeck).Length).ToString();
            dataStr += targetNeck;
            dataStr += ((char)srcPort).ToString();
            sendData(dataStr);
        }
        public void AcceptVideo(IPEndPoint otherEP, String otherNeck, VideoMirror.OnFrameReceivedHandler onFRH)
        {
            // 视频收发准备
            int tgtPort = VideoMgr.BeginVideoAsTarget(otherEP, otherNeck);
            // 发送接受消息
            String dataStr = System.Convert.ToChar(CProtocol.VideoAccept).ToString();
            dataStr += ((char)System.Text.Encoding.UTF8.GetBytes(otherNeck).Length).ToString();
            dataStr += otherNeck;
            dataStr += ((char)tgtPort).ToString();
            sendData(dataStr);
            // 开始收发视频
            ChaitClient.Instance.BeginVideo(otherNeck, onFRH);
        }
        public void RefuseVideo(String sourceNeck)
        {
            // 发送拒绝消息
            String dataStr = System.Convert.ToChar(CProtocol.VideoRefused).ToString();
            dataStr += sourceNeck;
            sendData(dataStr);
        }

        // 在收到视频接受消息后开始视频
        public void BeginVideo(String otherNeck, String otherIP, int otherPort)
        {
            VideoMgr.Begin(otherNeck, otherIP, otherPort);
        }
        // 在收到视频请求后同意并开始视频
        public void BeginVideo(String otherNeck, VideoMirror.OnFrameReceivedHandler onFRH)
        {
            VideoMgr.Begin(otherNeck,  onFRH);
        }
        // 在视频请求被拒绝时清理视频模块
        public void ClearVideo(String otherNeck)
        {
            VideoMgr.Clear(otherNeck);
        }
        // 主动停止视频
        public void StopVideo(String targetNeck)
        {
            // 发送结束消息
            String dataStr = System.Convert.ToChar(CProtocol.VideoStop).ToString();
            dataStr += targetNeck;
            sendData(dataStr);
            // 清理视频模块
            VideoMgr.Clear(targetNeck);
        }
        #endregion
    }
}