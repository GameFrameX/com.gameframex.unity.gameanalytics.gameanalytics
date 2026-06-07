<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GameAnalytics

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

GameFrameX GameAnalytics 元件 - 提供遊戲開發者整合和使用遊戲資料分析功能的介面。該元件封裝了 GameAnalytics SDK，提供事件上報、計時功能和自訂事件報告。

## 特性

- **事件追蹤** - 上報簡單事件、數值事件和自訂欄位事件
- **計時功能** - 開始和停止計時器，用於測量事件持續時間
- **初始化保護** - 所有方法在執行前檢查初始化狀態
- **自訂欄位** - 支援基於字典的自訂事件資料

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.gameanalytics": "1.1.0"
  }
}
```

## 使用注意事項

- 請確保在使用元件的任何方法之前，元件已被正確初始化
- 若未初始化，則不進行任何操作，確保了只有在元件初始化後事件上報或計時才有效
- 上報的事件名稱應該具有代表性和唯一性，以確保資料分析的準確性

## 整合提示

- 專案中應引入命名空間 `GameFrameX.GameAnalytics.Runtime`
- 確保 `GameAnalyticsManager` 被正確實例化，並已透過 `GameFramework` 註冊
- 對於自訂欄位，使用 `Dictionary<string, string>` 類型保持鍵值對的資料結構

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。


## 依賴

| 套件 | 說明 |
|------|------|
| (无) | - |


## 文檔與資源

- [官方文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- QQ群: 467608841 / 233840761
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
