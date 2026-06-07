<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GameAnalytics

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics)](https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

GameFrameX GameAnalytics Component - Provides game developers with an interface for integrating and using game analytics functionality. This component wraps the GameAnalytics SDK to offer event tracking, timer functionality, and custom event reporting.

## Features

- **Event Tracking** - Report simple events, value-based events, and custom field events
- **Timer Functionality** - Start and stop timers for measuring event durations
- **Initialization Guard** - All methods check initialization status before executing
- **Custom Fields** - Support for dictionary-based custom event data

## Installation

### Via Git URL (Recommended)

1. Open Package Manager in Unity Editor
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics.git
   ```

### Via manifest.json

Add the following to your project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.gameanalytics": "https://github.com/GameFrameX/com.gameframex.unity.gameanalytics.gameanalytics.git"
  }
}
```

### Manual Installation

1. Download the latest release package
2. Extract it to your project's `Packages` directory
3. Unity will automatically recognize and load the package

## Quick Start

### Installation

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

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

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gameanalytics.gameanalytics": "1.1.0"
  }
}
```

## Usage Notes

- Ensure the component is properly initialized before calling any methods
- If `_isInit` is `false`, no operations will be performed, ensuring events are only reported after initialization
- Event names should be representative and unique to ensure accurate data analysis

## Integration Tips

- Import the namespace `GameFrameX.GameAnalytics.Runtime` in your project
- Ensure `GameAnalyticsManager` is properly instantiated and registered with `GameFramework`
- Use `Dictionary<string, string>` for custom fields

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

See [LICENSE.md](LICENSE.md) for license information.
