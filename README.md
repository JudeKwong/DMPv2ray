# DMPv2ray

> A modern-UI proxy client built on v2rayN. 一款基于 v2rayN 开发的现代化界面代理客户端。

🌐 **官网 / Official Website**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray 是一款基于开源项目 [v2rayN](https://github.com/2dust/v2rayN) 二次开发的跨平台代理客户端。在保留 v2rayN 强大的多内核支持（Xray、sing-box、Mihomo）与完整功能的同时，我们对用户界面进行了现代化重构，使操作更加简洁直观。

DMPv2ray is a cross-platform proxy client built upon the open-source project [v2rayN](https://github.com/2dust/v2rayN). While preserving v2rayN's powerful multi-core support (Xray, sing-box, and Mihomo) and full feature set, it delivers a modernized, redesigned user interface that is cleaner and more intuitive.

---

## 功能特性 / Features

- **多内核支持**：内置 Xray / sing-box / Mihomo 三大代理内核，随装随用 / Multi-core support: bundled Xray, sing-box and Mihomo cores.
- **规则模式**：国外网站自动走代理，其余流量一律直连国内网络，开箱即用 / Built-in **Rule Mode**: foreign websites go through the proxy, all other traffic connects directly.
- **简化规则管理**：添加规则只需填写名称、域名、匹配类型（完整域名 / 域名前缀）、代理策略（代理 / 直连）/ Simplified rule management: name, domain, match type (full domain / domain prefix) and policy (proxy / direct).
- **订阅管理**：支持多订阅、自动更新 / Subscription management with auto-update.
- **现代化界面**：简洁直观的现代化 UI / A clean and modern UI.
- **跨平台**：Windows / Linux / macOS / Cross-platform: Windows, Linux and macOS.

## 支持平台 / Supported Platforms

| Platform / 平台 | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## 快速开始 / Quick Start

1. 从 [Releases](https://github.com/DMP_Pig/DMPv2ray/releases) 下载 Windows 安装包或便携版压缩包 / Download the Windows installer or portable archive from Releases.
2. 添加订阅或节点 / Add a subscription or server node.
3. 选择「规则模式」即可使用 / Select **Rule Mode** and start using it.

## 从源码构建 / Build from Source

环境要求：.NET SDK 10.0+（Windows 构建需启用 Windows Targeting）。

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## 目录结构 / Directory Structure

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## 致谢 / Acknowledgements

感谢以下开源项目及其作者：

- [v2rayN](https://github.com/2dust/v2rayN) — 本项目的基础
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — Geo 数据

## 开源协议 / License

本项目基于 v2rayN 二次开发，以 [GNU GPL v3.0](LICENSE) 许可发布，并遵守所有上游项目的开源许可，详见 [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md)。

This project is a derivative work of v2rayN and is released under the [GNU GPL v3.0](LICENSE). It complies with all upstream open-source licenses; see [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) for details.

---
© 2026 DMP_Pig
