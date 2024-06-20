using System.Collections.Generic;
using GameFrameX.GameAnalytics.Runtime;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    internal class GameAnalyticsByGameAnalyticsManager : BaseGameAnalyticsManager
    {
        public override void Init(string appid, string channel, string appKey, string secretKey)
        {
        }

        public override void StartTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.StartTimer(eventName);
        }

        public override void PauseTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.PauseTimer(eventName);
        }

        public override void ResumeTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.ResumeTimer(eventName);
        }

        public override void StopTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.StopTimer(eventName);
        }

        public override void Event(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName);
        }

        public override void Event(string eventName, float eventValue)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, eventValue);
        }

        public override void Event(string eventName, Dictionary<string, object> customF)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, customF);
        }

        public override void Event(string eventName, float eventValue, Dictionary<string, object> customF)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, eventValue, customF);
        }
    }
}