<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GameAnalytics

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

GameFrameX GameAnalytics コンポーネント - ゲーム開発者にゲームアナリティクス機能の統合と使用のためのインターフェースを提供します。GameAnalytics SDK をラップし、イベントトラッキング、タイマー機能、カスタムイベントレポートを提供します。

## 特徴

- **イベントトラッキング** - シンプルなイベント、数値ベースのイベント、カスタムフィールドイベントのレポート
- **タイマー機能** - イベントの継続時間を測定するためのタイマーの開始と停止
- **初期化ガード** - すべてのメソッドは実行前に初期化状態を確認
- **カスタムフィールド** - ディクショナリベースのカスタムイベントデータをサポート

## インストール

### Git URL 経由（推奨）

1. Unity エディタで Package Manager を開く
2. "+" ボタンをクリックし "Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics.git
   ```

### manifest.json 経由

プロジェクトの `Packages/manifest.json` に以下を追加：

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.gameanalytics": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics.git"
  }
}
```

### 手動インストール

1. 最新のリリースパッケージをダウンロード
2. プロジェクトの `Packages` ディレクトリに展開
3. Unity が自動的にパッケージを認識して読み込みます

## クイックスタート

### 初期化

Unity の `Awake` メソッドで `GameAnalyticsComponent` を初期化します。`Init()` を呼び出して初期化を完了します：

```csharp
using GameFrameX.GameAnalytics.Runtime;

public class GameAnalyticsExample : MonoBehaviour
{
    private void Awake()
    {
        // GameAnalyticsComponent を取得して初期化
        var gameAnalyticsComponent = GameEntry.GetComponent<GameAnalyticsComponent>();
        gameAnalyticsComponent.Init();
    }
}
```

### タイマー機能

```csharp
// タイマー開始
gameAnalyticsComponent.StartTimer("level_complete");

// タイマー停止
gameAnalyticsComponent.StopTimer("level_complete");
```

### イベントレポート

```csharp
// シンプルなイベント
gameAnalyticsComponent.Event("button_clicked");

// 数値付きイベント
gameAnalyticsComponent.Event("score_achieved", 100.0f);

// カスタムフィールド付きイベント
var customFields = new Dictionary<string, string>
{
    { "level", "5" },
    { "character", "warrior" }
};
gameAnalyticsComponent.Event("level_started", customFields);

// 数値とカスタムフィールド付きイベント
gameAnalyticsComponent.Event("level_completed", 95.5f, customFields);
```

## 使用上の注意

- コンポーネントのメソッドを呼び出す前に、正しく初期化されていることを確認してください
- 初期化されていない場合、操作は実行されず、初期化後のみイベントのレポートやタイマーが有効になります
- データ分析の正確性を確保するため、イベント名は代表的で一意なものにしてください

## 統合のヒント

- プロジェクトで名前空間 `GameFrameX.GameAnalytics.Runtime` をインポートしてください
- `GameAnalyticsManager` が正しくインスタンス化され、`GameFramework` に登録されていることを確認してください
- カスタムフィールドには `Dictionary<string, string>` 型を使用してください

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
