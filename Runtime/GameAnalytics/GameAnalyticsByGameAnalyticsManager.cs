using System.Collections.Generic;
using GameFrameX.GameAnalytics.Runtime;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    internal class GameAnalyticsByGameAnalyticsManager : BaseGameAnalyticsManager
    {
        private readonly Dictionary<string, object>        m_publicProperties = new Dictionary<string, object>();
        private readonly Dictionary<string, string>        Args               = new Dictionary<string, string>();
        private          GameAnalyticsGameAnalyticsSetting m_GameAnalyticsSetting;

        public override void Init(Dictionary<string, string> args)
        {
            foreach (var arg in args)
            {
                Args[arg.Key] = arg.Value;
            }

            Log.Info("GameAnalyticsByGameAnalyticsManager Init, args:" + Utility.Json.ToJson(args));
            m_GameAnalyticsSetting = Utility.Json.ToObject<GameAnalyticsGameAnalyticsSetting>(Utility.Json.ToJson(args));

            if (m_GameAnalyticsSetting == null)
            {
                Log.Error("GameAnalyticsByGameAnalyticsManager Init: GameAnalyticsGameAnalyticsSetting is null");
                return;
            }

            GameAnalyticsSDK.GameAnalytics.EnableFpsHistogram(true);
            GameAnalyticsSDK.GameAnalytics.EnableMemoryHistogram(true);
            GameAnalyticsSDK.GameAnalytics.EnableAdvertisingIdTracking(true);
            GameAnalyticsSDK.GameAnalytics.EnableSDKInitEvent(true);
            GameAnalyticsSDK.GameAnalytics.SetEnabledManualSessionHandling(true);
            GameAnalyticsSDK.GameAnalytics.EnableHealthHardwareInfo(true);
            GameAnalyticsSDK.GameAnalytics.SetEnabledEventSubmission(true);
            GameAnalyticsSDK.GameAnalytics.SetExternalUserId(m_GameAnalyticsSetting.channelId);
        }

        public override void ManualInit(Dictionary<string, string> args)
        {
            Init(args);
        }

        public override bool IsManualInit()
        {
            return true;
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