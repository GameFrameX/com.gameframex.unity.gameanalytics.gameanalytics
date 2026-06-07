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

## クイックスタート

### インストール

Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.gameanalytics": "1.1.0"
  }
}
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


## 依存関係

| パッケージ | 説明 |
|----------|------|
| (无) | - |


## ドキュメントとリソース

- [ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- QQグループ: 467608841 / 233840761
## ライセンス

詳しくは [LICENSE.md](LICENSE.md) をご参照ください。
