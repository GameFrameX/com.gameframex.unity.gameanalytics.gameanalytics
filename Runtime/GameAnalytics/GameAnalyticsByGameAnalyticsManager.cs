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

            var sentryUnityOptions = new Sentry.Unity.SentryUnityOptions
            {
                Enabled = true,
                AttachScreenshot = true,
                Il2CppLineNumberSupportEnabled = true,
                AddBreadcrumbsWithStructuredLogs = true,
                CaptureLogErrorEvents = true,
                AutoStartupTraces = true,
                AutoSceneLoadTraces = true,
                ScreenshotQuality = Sentry.Unity.ScreenshotQuality.Low,
                ScreenshotCompression = 1,
            };
            Sentry.Unity.SentrySdk.Init(sentryUnityOptions);

            GameAnalyticsHelper.Init();
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
            Sentry.Unity.SentrySdk.SetTag();
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
            Sentry.Unity.SentrySdk.CaptureEvent(eventName);
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

        [UnityEngine.Scripting.Preserve]
        public override void SetPlayerId(string playerId)
        {
            GameAnalyticsSDK.GameAnalytics.SetExternalUserId(playerId);
        }
    }
}