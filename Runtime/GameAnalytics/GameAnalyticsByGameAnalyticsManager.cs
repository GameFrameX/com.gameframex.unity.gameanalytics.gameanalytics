using System.Collections.Generic;
using GameFrameX.GameAnalytics.Runtime;
using GameFrameX.Runtime;

namespace GameFrameX.GameAnalytics.GameAnalytics.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    public sealed class GameAnalyticsByGameAnalyticsManager : BaseGameAnalyticsManager
    {
        private readonly Dictionary<string, object> m_publicProperties = new Dictionary<string, object>();
        private readonly Dictionary<string, string> Args = new Dictionary<string, string>();
        private GameAnalyticsGameAnalyticsSetting m_GameAnalyticsSetting;

        [UnityEngine.Scripting.Preserve]
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

        [UnityEngine.Scripting.Preserve]
        public override void ManualInit(Dictionary<string, string> args)
        {
            Init(args);
        }

        [UnityEngine.Scripting.Preserve]
        public override bool IsManualInit()
        {
            return true;
        }

        [UnityEngine.Scripting.Preserve]
        public override void SetPublicProperties(string key, object value)
        {
            m_publicProperties[key] = value;
            GameAnalyticsSDK.GameAnalytics.SetGlobalCustomEventFields(m_publicProperties);
        }

        [UnityEngine.Scripting.Preserve]
        public override void ClearPublicProperties()
        {
            m_publicProperties.Clear();
            GameAnalyticsSDK.GameAnalytics.SetGlobalCustomEventFields(m_publicProperties);
        }

        [UnityEngine.Scripting.Preserve]
        public override Dictionary<string, object> GetPublicProperties()
        {
            return m_publicProperties;
        }

        [UnityEngine.Scripting.Preserve]
        public override void StartTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.StartTimer(eventName);
        }

        [UnityEngine.Scripting.Preserve]
        public override void PauseTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.PauseTimer(eventName);
        }

        [UnityEngine.Scripting.Preserve]
        public override void ResumeTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.ResumeTimer(eventName);
        }

        [UnityEngine.Scripting.Preserve]
        public override void StopTimer(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.StopTimer(eventName);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, float eventValue)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, eventValue);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, Dictionary<string, object> customF)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, customF);
        }

        [UnityEngine.Scripting.Preserve]
        public override void Event(string eventName, float eventValue, Dictionary<string, object> customF)
        {
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName, eventValue, customF);
        }
    }
}