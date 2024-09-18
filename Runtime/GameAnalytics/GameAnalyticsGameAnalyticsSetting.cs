using System;
using GameFrameX.GameAnalytics.Runtime;
using UnityEngine;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    [Serializable]
    [UnityEngine.Scripting.Preserve]
    public sealed class GameAnalyticsGameAnalyticsSetting : BaseGameAnalyticsSetting
    {
        [Header("appid")] [UnityEngine.Scripting.Preserve]
        public string appid;

        [Header("渠道")] [UnityEngine.Scripting.Preserve]
        public string channelId;

        [Header("客户端ID")] [UnityEngine.Scripting.Preserve]
        public string clientId;

        [Header("appkey")] [UnityEngine.Scripting.Preserve]
        public string appKey;

        [Header("secretkey")] [UnityEngine.Scripting.Preserve]
        public string secretKey;
    }
}