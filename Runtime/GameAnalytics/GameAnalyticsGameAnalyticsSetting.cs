using System;
using GameFrameX.GameAnalytics.Runtime;
using UnityEngine;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    [Serializable]
    public sealed class GameAnalyticsGameAnalyticsSetting : BaseGameAnalyticsSetting
    {
        [Header("appid")]     public string appid;
        [Header("渠道")]        public string channelId;
        [Header("客户端ID")]     public string clientId;
        [Header("appkey")]    public string appKey;
        [Header("secretkey")] public string secretKey;
    }
}