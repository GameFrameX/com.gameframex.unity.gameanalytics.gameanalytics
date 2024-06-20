using System.Collections.Generic;
using GameFrameX.GameAnalytics.Runtime;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    internal class GameAnalyticsByGameAnalyticsManager : BaseGameAnalyticsManager
    {
        private readonly Dictionary<string, object> m_publicProperties = new Dictionary<string, object>();

        public override void Init(string appid, string channel, string appKey, string secretKey)
        {
            GameAnalyticsSDK.GameAnalytics.EnableFpsHistogram(true);
            GameAnalyticsSDK.GameAnalytics.EnableMemoryHistogram(true);
            GameAnalyticsSDK.GameAnalytics.EnableAdvertisingIdTracking(true);
            GameAnalyticsSDK.GameAnalytics.EnableSDKInitEvent(true);
            GameAnalyticsSDK.GameAnalytics.SetEnabledManualSessionHandling(true);
            GameAnalyticsSDK.GameAnalytics.EnableHealthHardwareInfo(true);
            GameAnalyticsSDK.GameAnalytics.SetEnabledEventSubmission(true);
        }

        public override void SetPublicProperties(string key, object value)
        {
            m_publicProperties[key] = value;
            GameAnalyticsSDK.GameAnalytics.SetGlobalCustomEventFields(m_publicProperties);
        }

        public override void ClearPublicProperties()
        {
            m_publicProperties.Clear();
            GameAnalyticsSDK.GameAnalytics.SetGlobalCustomEventFields(m_publicProperties);
        }

        public override Dictionary<string, object> GetPublicProperties()
        {
            return m_publicProperties;
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