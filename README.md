# DMPv2ray

**DMPv2ray** 是一个基于 [v2rayN](https://github.com/2dust/v2rayN) 二次开发的跨平台代理客户端，作者 **DMP_Pig**。

- 支持 **Xray**、**sing-box**、**Mihomo** 内核
- 内置「规则模式」：国外网站走代理，其余一律走国内直连
- 简化了规则管理：添加规则只需填写名称、域名、匹配类型、代理策略
- 现代化界面，适合日常使用

> 本项目遵守上游 [v2rayN](https://github.com/2dust/v2rayN)（GPL-3.0）及 Xray / sing-box / mihomo / Geo 数据等所有上游项目的开源协议，详见 [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md)。

## 支持平台

| 平台 | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## 快速开始

1. 从 Releases 下载安装包（Windows）或便携版压缩包
2. 添加订阅 / 节点
3. 选择「规则模式」即可使用

## 从源码构建（Windows）

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true
```

## 致谢

- 感谢 [v2rayN](https://github.com/2dust/v2rayN) 及其作者 2dust
- 感谢 [Xray-core](https://github.com/XTLS/Xray-core)、[sing-box](https://github.com/SagerNet/sing-box)、[mihomo](https://github.com/MetaCubeX/mihomo)
- 感谢 [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat)

## 许可证

[GPL-3.0](LICENSE)（fork 自 v2rayN，详见 [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md)）
