# 第三方开源组件许可声明 / Third-Party Open Source Licenses

本项目 **DMPv2ray** 是基于 [v2rayN](https://github.com/2dust/v2rayN) 的二次开发项目。
本项目整体以 **GNU GPL v3.0** 许可发布（见根目录 `LICENSE` 文件），并遵守以下所有上游项目的开源协议。

> 说明：以下仅列出本项目直接使用/分发的上游项目。凡本项目涉及的修改，均保留上游版权声明并遵循各自许可证要求。

## 一、代码 / 图形界面

| 组件 | 上游项目 | 版权归属 | 许可证 | 说明 |
| --- | --- | --- | --- | --- |
| 图形界面（本项目的母项目） | [v2rayN](https://github.com/2dust/v2rayN) | © 2dust | [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) | 本仓库为其二次开发版本 |
| 全局热键库 | [GlobalHotKeys](https://github.com/2dust/GlobalHotKeys) | © 2dust / Martin Kramer | [WTFPL-2.0](https://en.wikipedia.org/wiki/WTFPL) | 位于 `v2rayN/GlobalHotKeys` |
| 更新辅助工具 | AmazTool | © 2dust | GPL-3.0 | 随 v2rayN 分发的工具 |

## 二、代理内核（随发布包分发，未包含在本源码仓库）

| 组件 | 上游项目 | 版权归属 | 许可证 |
| --- | --- | --- | --- |
| Xray 内核 | [Xray-core](https://github.com/XTLS/Xray-core) | © XTLS | [MPL-2.0](https://www.mozilla.org/en-US/MPL/2.0/) |
| sing-box 内核 | [sing-box](https://github.com/SagerNet/sing-box) | © SagerNet | [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) |
| Mihomo 内核 | [mihomo](https://github.com/MetaCubeX/mihomo) | © MetaCubeX | [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) |

## 三、数据文件（随发布包分发）

| 组件 | 来源 | 许可证 |
| --- | --- | --- |
| geoip.dat / geosite.dat | [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) | [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) |

## 四、字体

| 组件 | 来源 | 许可证 |
| --- | --- | --- |
| Noto Sans SC (`NotoSansSC-Regular.ttf`) | [notofonts/noto-cjk](https://github.com/notofonts/noto-cjk) | [SIL OFL 1.1](https://openfontlicense.org/) |

## 五、NuGet 依赖（主要，以各包 nuspec 声明为准）

| 包 | 许可证 |
| --- | --- |
| Avalonia / Avalonia.Desktop / AvaloniaEdit / Controls.DataGrid | MIT |
| ReactiveUI / ReactiveUI.Avalonia / ReactiveUI.SourceGenerators | MIT |
| Semi.Avalonia / Semi.Avalonia.DataGrid / Semi.Avalonia.AvaloniaEdit | MIT |
| DialogHost.Avalonia | MIT |
| SkiaSharp / SkiaSharp.NativeAssets.Linux | MIT |
| H.NotifyIcon.Wpf | MIT |
| MaterialDesignThemes | MIT |
| QRCoder | MIT |
| ZXing.Net.Bindings.SkiaSharp | MIT |
| CliWrap | MIT |
| Downloader | MIT |
| YamlDotNet | MIT |
| IPNetwork2 | MIT |
| sqlite-net-e | MIT |
| NLog | BSD-3-Clause |
| TaskScheduler | MIT |
| xunit / AwesomeAssertions（测试） | Apache-2.0 / MIT |

> 各依赖的完整许可证文本以 [nuget.org](https://www.nuget.org) 上对应包的发布信息为准。

## 联系 / 版权

- 作者：**DMP_Pig**
- 本项目对上游 v2rayN 的修改，按 GPL-3.0 要求随源码一并提供。
