<div align="center">

**🌐 选择语言 / Select Language**

[简体中文](#简体中文) · [繁體中文](#繁體中文) · [English](#english) · [Español](#español) · [Français](#français) · [العربية](#العربية) · [Русский](#русский) · [Português](#português)

</div>

> **说明 / Note**: 以简体中文为标准 · Simplified Chinese is the standard reference.

---

## 简体中文

## DMPv2ray

> 一款基于 v2rayN 开发的现代化界面代理客户端。

🌐 **官网**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray 是一款基于开源项目 [v2rayN](https://github.com/2dust/v2rayN) 二次开发的跨平台代理客户端。在保留 v2rayN 强大的多内核支持（Xray、sing-box、Mihomo）与完整功能的同时，我们对用户界面进行了现代化重构，使操作更加简洁直观。

---

## 功能特性

- **多内核支持**：内置 Xray / sing-box / Mihomo 三大代理内核，随装随用。
- **规则模式**：国外网站自动走代理，其余流量一律直连国内网络，开箱即用。
- **简化规则管理**：添加规则只需填写名称、域名、匹配类型（完整域名 / 域名前缀）、代理策略（代理 / 直连）。
- **订阅管理**：支持多订阅、自动更新。
- **现代化界面**：简洁直观的现代化 UI。
- **跨平台**：Windows / Linux / macOS。

## 支持平台

| 平台 | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## 快速开始

1. 从 [Releases](https://github.com/DMP_Pig/DMPv2ray/releases) 下载 Windows 安装包或便携版压缩包。
2. 添加订阅或节点。
3. 选择「规则模式」即可使用。

## 从源码构建

环境要求：.NET SDK 10.0+（Windows 构建需启用 Windows Targeting）。

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## 目录结构

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## 致谢

感谢以下开源项目及其作者：

- [v2rayN](https://github.com/2dust/v2rayN) — 本项目的基础
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — Geo 数据

## 开源协议

本项目基于 v2rayN 二次开发，以 [GNU GPL v3.0](LICENSE) 许可发布，并遵守所有上游项目的开源许可，详见 [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md)。

---
© 2026 DMP_Pig

---

## 繁體中文

## DMPv2ray

> 一款基於 v2rayN 開發的現代化介面代理用戶端。

🌐 **官網**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray 是一款基於開放原始碼專案 [v2rayN](https://github.com/2dust/v2rayN) 二次開發的跨平台代理用戶端。在保留 v2rayN 強大的多核心支援（Xray、sing-box、Mihomo）與完整功能的同時，我們對使用者介面進行了現代化重構，使操作更加簡潔直觀。

---

## 功能特性

- **多核心支援**：內建 Xray / sing-box / Mihomo 三大代理核心，隨裝隨用。
- **規則模式**：國外網站自動走代理，其餘流量一律直接連線國內網路，開箱即用。
- **簡化規則管理**：新增規則只需填寫名稱、網域、比對類型（完整網域 / 網域前綴）、代理策略（代理 / 直接連線）。
- **訂閱管理**：支援多訂閱、自動更新。
- **現代化介面**：簡潔直觀的現代化 UI。
- **跨平台**：Windows / Linux / macOS。

## 支援平台

| 平台 | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## 快速開始

1. 從 [Releases](https://github.com/DMP_Pig/DMPv2ray/releases) 下載 Windows 安裝程式或可攜版壓縮檔。
2. 新增訂閱或節點。
3. 選擇「規則模式」即可使用。

## 從原始碼建置

環境需求：.NET SDK 10.0+（Windows 建置需啟用 Windows Targeting）。

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## 目錄結構

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## 致謝

感謝以下開放原始碼專案及其作者：

- [v2rayN](https://github.com/2dust/v2rayN) — 本專案的基礎
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — Geo 資料

## 開放原始碼授權

本專案基於 v2rayN 二次開發，以 [GNU GPL v3.0](LICENSE) 授權發布，並遵守所有上游專案的開放原始碼授權，詳見 [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md)。

---
© 2026 DMP_Pig

---

## English

## DMPv2ray

> A modern-UI proxy client built on v2rayN.

🌐 **Official Website**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray is a cross-platform proxy client built upon the open-source project [v2rayN](https://github.com/2dust/v2rayN). While preserving v2rayN's powerful multi-core support (Xray, sing-box, and Mihomo) and full feature set, it delivers a modernized, redesigned user interface that is cleaner and more intuitive.

---

## Features

- **Multi-core support**: bundled Xray, sing-box, and Mihomo proxy cores, ready to use out of the box.
- **Rule Mode**: foreign websites automatically go through the proxy, while all remaining traffic connects directly to the domestic network — ready to use out of the box.
- **Simplified rule management**: to add a rule, just fill in the name, domain, match type (full domain / domain prefix), and proxy policy (proxy / direct).
- **Subscription management**: supports multiple subscriptions with automatic updates.
- **Modern UI**: a clean, intuitive, modern interface.
- **Cross-platform**: Windows / Linux / macOS.

## Supported Platforms

| Platform | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## Quick Start

1. Download the Windows installer or portable archive from [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. Add a subscription or server node.
3. Select **Rule Mode** and start using it.

## Build from Source

Requirements: .NET SDK 10.0+ (Windows builds require Windows Targeting to be enabled).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## Directory Structure

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## Acknowledgements

Thanks to the following open-source projects and their authors:

- [v2rayN](https://github.com/2dust/v2rayN) — the foundation of this project
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — Geo data

## License

This project is a derivative work of v2rayN and is released under the [GNU GPL v3.0](LICENSE). It complies with all upstream open-source licenses; see [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) for details.

---
© 2026 DMP_Pig

---

## Español

## DMPv2ray

> Un cliente de proxy con interfaz moderna basado en v2rayN.

🌐 **Sitio oficial**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray es un cliente de proxy multiplataforma desarrollado a partir del proyecto de código abierto [v2rayN](https://github.com/2dust/v2rayN). Además de conservar el potente soporte multinúcleo de v2rayN (Xray, sing-box y Mihomo) y su conjunto completo de funciones, hemos rediseñado la interfaz de usuario con un enfoque moderno, haciendo que su uso sea más simple e intuitivo.

---

## Características

- **Soporte multinúcleo**: incluye los tres núcleos de proxy Xray / sing-box / Mihomo, listos para usar.
- **Modo de Reglas**: los sitios web extranjeros pasan automáticamente por el proxy y el resto del tráfico se conecta directamente a la red nacional, listo para usar.
- **Gestión de reglas simplificada**: para añadir una regla solo hay que indicar el nombre, el dominio, el tipo de coincidencia (dominio completo / prefijo de dominio) y la política de proxy (proxy / conexión directa).
- **Gestión de suscripciones**: admite varias suscripciones con actualización automática.
- **Interfaz moderna**: una interfaz moderna, limpia e intuitiva.
- **Multiplataforma**: Windows / Linux / macOS.

## Plataformas compatibles

| Plataforma | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## Inicio rápido

1. Descargue el instalador de Windows o el archivo comprimido de la versión portátil desde [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. Añada una suscripción o un nodo.
3. Seleccione el **Modo de Reglas** y empiece a usarlo.

## Compilar desde el código fuente

Requisitos: .NET SDK 10.0+ (para compilar en Windows es necesario habilitar Windows Targeting).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## Estructura de directorios

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## Agradecimientos

Agradecemos los siguientes proyectos de código abierto y a sus autores:

- [v2rayN](https://github.com/2dust/v2rayN) — la base de este proyecto
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — datos Geo

## Licencia

Este proyecto es un desarrollo derivado de v2rayN y se publica bajo la licencia [GNU GPL v3.0](LICENSE). Cumple con las licencias de código abierto de todos los proyectos upstream; consulte [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) para más detalles.

---
© 2026 DMP_Pig

---

## Français

## DMPv2ray

> Un client proxy à interface moderne basé sur v2rayN.

🌐 **Site officiel** : [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray est un client proxy multiplateforme développé à partir du projet open source [v2rayN](https://github.com/2dust/v2rayN). Tout en conservant la puissante prise en charge multinoyau de v2rayN (Xray, sing-box et Mihomo) et l'ensemble complet de ses fonctionnalités, nous avons entièrement modernisé l'interface utilisateur pour la rendre plus simple et plus intuitive.

---

## Fonctionnalités

- **Prise en charge multinoyau** : les trois noyaux proxy Xray / sing-box / Mihomo sont intégrés, prêts à l'emploi.
- **Mode de règles** : les sites web étrangers passent automatiquement par le proxy et tout le reste du trafic se connecte directement au réseau local, prêt à l'emploi.
- **Gestion simplifiée des règles** : pour ajouter une règle, il suffit de renseigner le nom, le domaine, le type de correspondance (domaine complet / préfixe de domaine) et la politique de proxy (proxy / connexion directe).
- **Gestion des abonnements** : prend en charge plusieurs abonnements avec mise à jour automatique.
- **Interface moderne** : une interface moderne, épurée et intuitive.
- **Multiplateforme** : Windows / Linux / macOS.

## Plateformes prises en charge

| Plateforme | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## Démarrage rapide

1. Téléchargez l'installeur Windows ou l'archive de la version portable depuis [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. Ajoutez un abonnement ou un nœud.
3. Sélectionnez le **Mode de règles** et commencez à l'utiliser.

## Compiler à partir des sources

Prérequis : .NET SDK 10.0+ (pour compiler sous Windows, Windows Targeting doit être activé).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## Structure des répertoires

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## Remerciements

Merci aux projets open source suivants et à leurs auteurs :

- [v2rayN](https://github.com/2dust/v2rayN) — la base de ce projet
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — données Geo

## Licence

Ce projet est un développement dérivé de v2rayN, publié sous la licence [GNU GPL v3.0](LICENSE). Il respecte les licences open source de tous les projets amont ; voir [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) pour plus de détails.

---
© 2026 DMP_Pig

---

## العربية

## DMPv2ray

> عميل بروكسي بواجهة عصرية مبني على v2rayN.

🌐 **الموقع الرسمي**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray هو عميل بروكسي متعدد المنصات مبني على المشروع مفتوح المصدر [v2rayN](https://github.com/2dust/v2rayN) كتطوير مشتق منه. مع الحفاظ على دعم v2rayN القوي متعدد النوى (Xray وsing-box وMihomo) ومجموعة الميزات الكاملة، أعدنا تصميم واجهة المستخدم بأسلوب عصري لتصبح أبسط وأكثر سهولة ووضوحًا.

---

## الميزات

- **دعم متعدد النوى**: يتضمن نوى البروكسي الثلاثة Xray / sing-box / Mihomo، جاهزة للاستخدام فورًا.
- **وضع القواعد**: تدخل المواقع الأجنبية تلقائيًا عبر البروكسي، بينما يتصل باقي حركة المرور بالشبكة المحلية اتصالًا مباشرًا، جاهز للاستخدام دون إعدادات إضافية.
- **إدارة مبسّطة للقواعد**: لإضافة قاعدة، يكفي إدخال الاسم واسم النطاق ونوع المطابقة (نطاق كامل / بادئة نطاق) وسياسة البروكسي (بروكسي / اتصال مباشر).
- **إدارة الاشتراكات**: يدعم اشتراكات متعددة مع التحديث التلقائي.
- **واجهة عصرية**: واجهة مستخدم عصرية بسيطة وواضحة.
- **متعدد المنصات**: Windows / Linux / macOS.

## المنصات المدعومة

| المنصة | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## بدء سريع

1. نزّل مثبّت Windows أو الأرشيف المضغوط للإصدار المحمول من [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. أضف اشتراكًا أو عقدة.
3. اختر **وضع القواعد** وابدأ في الاستخدام.

## البناء من المصدر

المتطلبات: .NET SDK 10.0+ (يتطلب البناء على Windows تفعيل Windows Targeting).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## بنية الدليل

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## شكر وتقدير

نشكر المشاريع مفتوحة المصدر التالية ومؤلفيها:

- [v2rayN](https://github.com/2dust/v2rayN) — أساس هذا المشروع
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — بيانات Geo

## الترخيص

هذا المشروع هو تطوير مشتق من v2rayN، ويُصدر بموجب ترخيص [GNU GPL v3.0](LICENSE)، ويلتزم بتراخيص المصدر المفتوح لجميع المشاريع الأم؛ انظر [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) للتفاصيل.

---
© 2026 DMP_Pig

---

## Русский

## DMPv2ray

> Современный прокси-клиент, созданный на основе v2rayN.

🌐 **Официальный сайт**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

DMPv2ray — это кроссплатформенный прокси-клиент, созданный на основе проекта с открытым исходным кодом [v2rayN](https://github.com/2dust/v2rayN). Сохраняя мощную мультиядерную поддержку v2rayN (Xray, sing-box и Mihomo) и полный набор функций, мы модернизировали пользовательский интерфейс, сделав его проще и интуитивнее.

---

## Возможности

- **Мультиядерная поддержка**: встроенные прокси-ядра Xray / sing-box / Mihomo — установил и можно пользоваться.
- **Режим правил**: зарубежные сайты автоматически идут через прокси, а весь остальной трафик — напрямую к локальной сети; работает сразу из коробки.
- **Упрощённое управление правилами**: чтобы добавить правило, достаточно указать имя, домен, тип сопоставления (полный домен / префикс домена) и прокси-политику (прокси / прямое соединение).
- **Управление подписками**: поддержка нескольких подписок с автоматическим обновлением.
- **Современный интерфейс**: чистый и интуитивно понятный современный UI.
- **Кроссплатформенность**: Windows / Linux / macOS.

## Поддерживаемые платформы

| Платформа | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## Быстрый старт

1. Скачайте установщик Windows или архив портативной версии со страницы [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. Добавьте подписку или узел.
3. Выберите **режим правил** и начинайте пользоваться.

## Сборка из исходников

Требования: .NET SDK 10.0+ (для сборки под Windows необходимо включить Windows Targeting).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## Структура каталогов

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## Благодарности

Благодарим следующие проекты с открытым исходным кодом и их авторов:

- [v2rayN](https://github.com/2dust/v2rayN) — основа этого проекта
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — данные Geo

## Лицензия

Этот проект является производной разработкой v2rayN и распространяется по лицензии [GNU GPL v3.0](LICENSE). Он соблюдает лицензии открытого исходного кода всех вышестоящих проектов; подробности см. в [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md).

---
© 2026 DMP_Pig

---

## Português

## DMPv2ray

> Um cliente de proxy com interface moderna baseado no v2rayN.

🌐 **Site oficial**: [https://dmpv2ray.judekwong.com](https://dmpv2ray.judekwong.com)

O DMPv2ray é um cliente de proxy multiplataforma desenvolvido a partir do projeto de código aberto [v2rayN](https://github.com/2dust/v2rayN). Além de manter o poderoso suporte multinúcleo do v2rayN (Xray, sing-box e Mihomo) e o conjunto completo de funcionalidades, redesenhamos a interface do usuário com uma abordagem moderna, tornando o uso mais simples e intuitivo.

---

## Recursos

- **Suporte multinúcleo**: inclui os três núcleos de proxy Xray / sing-box / Mihomo, prontos para usar.
- **Modo de Regras**: sites estrangeiros passam automaticamente pelo proxy e todo o restante do tráfego se conecta diretamente à rede local, pronto para uso imediato.
- **Gerenciamento simplificado de regras**: para adicionar uma regra, basta preencher o nome, o domínio, o tipo de correspondência (domínio completo / prefixo de domínio) e a política de proxy (proxy / conexão direta).
- **Gerenciamento de assinaturas**: suporta várias assinaturas com atualização automática.
- **Interface moderna**: uma interface moderna, limpa e intuitiva.
- **Multiplataforma**: Windows / Linux / macOS.

## Plataformas suportadas

| Plataforma | x64 | arm64 |
| --- | --- | --- |
| Windows | ✅ | ✅ |
| Linux | ✅ | ✅ |
| macOS | ✅ | ✅ |

## Início rápido

1. Baixe o instalador do Windows ou o arquivo compactado da versão portátil em [Releases](https://github.com/DMP_Pig/DMPv2ray/releases).
2. Adicione uma assinatura ou um nó.
3. Selecione o **Modo de Regras** e comece a usar.

## Compilar a partir do código-fonte

Pré-requisitos: .NET SDK 10.0+ (para compilar no Windows, é necessário ativar o Windows Targeting).

```bash
git clone https://github.com/DMP_Pig/DMPv2ray.git
cd DMPv2ray

# Windows
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release -p:EnableWindowsTargeting=true

# Linux / macOS
dotnet build v2rayN/v2rayN.Desktop/v2rayN.Desktop.csproj -c Release
```

## Estrutura de diretórios

```
v2rayN/
├── ServiceLib/          # 核心逻辑库（配置、路由、订阅、内核管理等）
├── v2rayN.Desktop/      # Avalonia 桌面客户端（本项目实际使用的界面）
├── AmazTool/            # 更新辅助工具
└── GlobalHotKeys/       # 全局热键库
```

## Agradecimentos

Agradecemos aos seguintes projetos de código aberto e seus autores:

- [v2rayN](https://github.com/2dust/v2rayN) — a base deste projeto
- [Xray-core](https://github.com/XTLS/Xray-core)
- [sing-box](https://github.com/SagerNet/sing-box)
- [mihomo](https://github.com/MetaCubeX/mihomo)
- [Loyalsoldier/v2ray-rules-dat](https://github.com/Loyalsoldier/v2ray-rules-dat) — dados Geo

## Licença

Este projeto é um desenvolvimento derivado do v2rayN, publicado sob a licença [GNU GPL v3.0](LICENSE), e cumpre as licenças de código aberto de todos os projetos upstream; consulte [THIRD_PARTY_LICENSES.md](THIRD_PARTY_LICENSES.md) para detalhes.

---
© 2026 DMP_Pig

---

