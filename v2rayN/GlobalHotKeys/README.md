<div align="center">

**🌐 选择语言 / Select Language**

[简体中文](#简体中文) · [繁體中文](#繁體中文) · [English](#english) · [Español](#español) · [Français](#français) · [العربية](#العربية) · [Русский](#русский) · [Português](#português)

</div>

> **说明 / Note**: 以简体中文为标准 · Simplified Chinese is the standard reference.

---

## 简体中文

GlobalHotKeys 是一个用于在 Windows 上注册全局热键的小型 .NET 库，由 Martin Kramer 编写（https://lostindetails.com）。

该库允许应用程序即使当前没有焦点，也能响应按键事件。

## 附加信息
更多信息请访问：https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## 安装
通过 `dotnet add package` 安装 NuGet 包：
```bat
dotnet add package GlobalHotKeys.Windows
```

## 使用示例
请参阅 `src/Examples` 文件夹中的示例。

以下是一个 C# 控制台应用程序的示例：

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## 源码说明
- C#
- 示例涵盖：
  - WinForms
  - Wpf
  - Console（控制台）
  - AvaloniaUI
- 实现了一个简单的消息循环

## 许可证
本库采用 WTFPL 或 MIT 双重许可证。
这意味着你可以自由选择 WTFPL 或 MIT 许可证。之所以提供选择，是因为尽管 WTFPL 更为宽松，但 MIT 许可证更为人所熟知。

### 版权声明 - WTFPL
版权所有 © 2021 Martin Kramer (https://lostindetails.com)
本作品是自由的。你可以根据 Sam Hocevar 发布的《Do What The Fuck You Want To Public License》（想干嘛就干嘛公共许可证）第 2 版的条款，自由地重新分发和修改它。详情请参见 http://www.wtfpl.net/。

### 版权声明 - MIT
版权所有 © 2021 Martin Kramer (https://lostindetails.com)

特此授予任何获得本软件及相关文档文件（“软件”）副本的人免费许可，允许其不受限制地处理本软件，包括但不限于使用、复制、修改、合并、发布、分发、再许可和/或出售本软件的副本，并允许向其提供本软件的人这样做，但须满足以下条件：

上述版权声明和本许可声明应包含在本软件的所有副本或重要部分中。

本软件按“现状”提供，不附带任何明示或暗示的保证，包括但不限于适销性、特定用途适用性和非侵权性的保证。在任何情况下，作者或版权持有人均不对因使用本软件或与本软件相关的任何索赔、损害或其他责任负责，无论是合同、侵权或其他方式引起的。

---

## 繁體中文

GlobalHotKeys 是一個用於在 Windows 上註冊全域熱鍵的小型 .NET 程式庫，由 Martin Kramer 編寫（https://lostindetails.com）。

該程式庫允許應用程式即使目前沒有焦點，也能回應按鍵事件。

## 附加資訊
更多資訊請造訪：https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## 安裝
透過 `dotnet add package` 安裝 NuGet 套件：
```bat
dotnet add package GlobalHotKeys.Windows
```

## 使用範例
請參閱 `src/Examples` 資料夾中的範例。

以下是一個 C# 主控台應用程式的範例：

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## 原始碼說明
- C#
- 範例涵蓋：
  - WinForms
  - Wpf
  - Console（主控台）
  - AvaloniaUI
- 實作了一個簡單的訊息迴圈

## 授權條款
本程式庫採用 WTFPL 或 MIT 雙重授權。
這表示你可以自由選擇 WTFPL 或 MIT 授權。之所以提供選擇，是因為儘管 WTFPL 更為寬鬆，但 MIT 授權更為人所熟知。

### 版權聲明 - WTFPL
版權所有 © 2021 Martin Kramer (https://lostindetails.com)
本作品是自由的。你可以根據 Sam Hocevar 發布的《Do What The Fuck You Want To Public License》（想做什麼就做什麼公共授權）第 2 版的條款，自由地重新散布和修改它。詳情請參見 http://www.wtfpl.net/。

### 版權聲明 - MIT
版權所有 © 2021 Martin Kramer (https://lostindetails.com)

特此授予任何獲得本軟體及相關文件檔案（「軟體」）副本的人免費許可，允許其不受限制地處理本軟體，包括但不限於使用、複製、修改、合併、發布、散布、再授權和／或出售本軟體的副本，並允許向其提供本軟體的人這樣做，但須滿足以下條件：

上述版權聲明和本許可聲明應包含在本軟體的所有副本或重要部分中。

本軟體按「現狀」提供，不附帶任何明示或暗示的保證，包括但不限於適銷性、特定用途適用性和非侵權性的保證。在任何情況下，作者或版權持有人均不對因使用本軟體或與本軟體相關的任何索賠、損害或其他責任負責，無論是契約、侵權或其他方式引起的。

---

## English

GlobalHotKeys is a tiny .NET Library for registering global HotKeys on Windows, written by Martin Kramer (https://lostindetails.com)

The library allows an application to react to Key Press events even if the application does not currently have focus.

## Additional Info
For additional info please visit: https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## Installation
Install the nuget package via `dotnet add package`
```bat
dotnet add package GlobalHotKeys.Windows
```

## Example Usage
Please take a look at the examples in the `src/Examples` folder.

Here is an example for a C# Console Application:

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## Source POI
- C#
- Examples for
  - WinForms
  - Wpf
  - Console
  - AvaloniaUI
- Implements a simple Message Loop

## License
This library is dual Licensed under the WTFPL or MIT.
That means you are free to choose either the WTFPL or the MIT License.The reason for giving you the option is that the even though the WTFPL is the more permissive license, the MIT License is better known.

### COPYRIGHT - WTFPL
Copyright © 2021 Martin Kramer (https://lostindetails.com)
This work is free. You can redistribute it and/or modify it under the
terms of the Do What The Fuck You Want To Public License, Version 2,
as published by Sam Hocevar. See http://www.wtfpl.net/ for more details.

### COPYRIGHT - MIT
Copyright © 2021 Martin Kramer (https://lostindetails.com)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

---

## Español

GlobalHotKeys es una pequeña biblioteca .NET para registrar HotKeys globales en Windows, escrita por Martin Kramer (https://lostindetails.com).

La biblioteca permite que una aplicación reaccione a los eventos de pulsación de teclas incluso si la aplicación no tiene el foco actualmente.

## Información adicional
Para obtener más información, visite: https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## Instalación
Instale el paquete NuGet mediante `dotnet add package`:
```bat
dotnet add package GlobalHotKeys.Windows
```

## Ejemplo de uso
Consulte los ejemplos de la carpeta `src/Examples`.

A continuación, un ejemplo para una aplicación de consola en C#:

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## Aspectos destacados del código
- C#
- Ejemplos para
  - WinForms
  - Wpf
  - Consola
  - AvaloniaUI
- Implementa un bucle de mensajes simple

## Licencia
Esta biblioteca tiene una licencia dual: WTFPL o MIT.
Eso significa que eres libre de elegir entre la licencia WTFPL o la licencia MIT. La razón por la que se te da la opción es que, aunque la WTFPL es la licencia más permisiva, la licencia MIT es más conocida.

### COPYRIGHT - WTFPL
Copyright © 2021 Martin Kramer (https://lostindetails.com)
Este trabajo es libre. Puedes redistribuirlo y/o modificarlo bajo los términos de la Do What The Fuck You Want To Public License, Versión 2, publicada por Sam Hocevar. Consulta http://www.wtfpl.net/ para obtener más detalles.

### COPYRIGHT - MIT
Copyright © 2021 Martin Kramer (https://lostindetails.com)

Por la presente se concede permiso, de forma gratuita, a cualquier persona que obtenga una copia de este software y de los archivos de documentación asociados (el "Software"), para tratar el Software sin restricción, incluidos, entre otros, los derechos de usar, copiar, modificar, fusionar, publicar, distribuir, sublicenciar y/o vender copias del Software, y para permitir a las personas a las que se proporcione el Software hacer lo mismo, sujeto a las siguientes condiciones:

El aviso de copyright anterior y este aviso de permiso se incluirán en todas las copias o partes sustanciales del Software.

EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O IMPLÍCITA, INCLUIDAS, ENTRE OTRAS, LAS GARANTÍAS DE COMERCIABILIDAD, IDONEIDAD PARA UN FIN PARTICULAR Y NO INFRACCIÓN. EN NINGÚN CASO LOS AUTORES O TITULARES DE LOS DERECHOS DE AUTOR SERÁN RESPONSABLES DE NINGUNA RECLAMACIÓN, DAÑO U OTRA RESPONSABILIDAD, YA SEA POR UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRO MODO, QUE SURJA DE O EN RELACIÓN CON EL SOFTWARE O EL USO U OTROS TRATOS CON EL SOFTWARE.

---

## Français

GlobalHotKeys est une petite bibliothèque .NET pour l'enregistrement de raccourcis clavier (HotKeys) globaux sous Windows, écrite par Martin Kramer (https://lostindetails.com).

La bibliothèque permet à une application de réagir aux événements de pression de touches même si l'application n'a pas le focus actuellement.

## Informations complémentaires
Pour plus d'informations, veuillez consulter : https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## Installation
Installez le package NuGet via `dotnet add package` :
```bat
dotnet add package GlobalHotKeys.Windows
```

## Exemple d'utilisation
Veuillez consulter les exemples dans le dossier `src/Examples`.

Voici un exemple pour une application console en C# :

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## Points forts du code
- C#
- Exemples pour
  - WinForms
  - Wpf
  - Console
  - AvaloniaUI
- Implémente une simple boucle de messages

## Licence
Cette bibliothèque est sous double licence WTFPL ou MIT.
Cela signifie que vous êtes libre de choisir entre la licence WTFPL ou la licence MIT. La raison pour laquelle ce choix vous est proposé est que, même si la WTFPL est la licence la plus permissive, la licence MIT est plus connue.

### COPYRIGHT - WTFPL
Copyright © 2021 Martin Kramer (https://lostindetails.com)
Cette œuvre est libre. Vous pouvez la redistribuer et/ou la modifier selon les termes de la Do What The Fuck You Want To Public License, Version 2, publiée par Sam Hocevar. Voir http://www.wtfpl.net/ pour plus de détails.

### COPYRIGHT - MIT
Copyright © 2021 Martin Kramer (https://lostindetails.com)

La permission est accordée par la présente, gratuitement, à toute personne obtenant une copie de ce logiciel et des fichiers de documentation associés (le « Logiciel »), de traiter le Logiciel sans restriction, y compris, sans limitation, les droits d'utiliser, copier, modifier, fusionner, publier, distribuer, sous-licencier et/ou vendre des copies du Logiciel, et de permettre aux personnes à qui le Logiciel est fourni de faire de même, sous réserve des conditions suivantes :

L'avis de droit d'auteur ci-dessus et cet avis d'autorisation doivent être inclus dans toutes les copies ou parties substantielles du Logiciel.

LE LOGICIEL EST FOURNI « TEL QUEL », SANS GARANTIE D'AUCUNE SORTE, EXPRESSE OU IMPLICITE, Y COMPRIS MAIS SANS S'Y LIMITER LES GARANTIES DE COMMERCIABILITÉ, D'ADÉQUATION À UN USAGE PARTICULIER ET D'ABSENCE DE CONTREFAÇON. EN AUCUN CAS LES AUTEURS OU TITULAIRES DU DROIT D'AUTEUR NE SERONT RESPONSABLES DE TOUTE RÉCLAMATION, DOMMAGE OU AUTRE RESPONSABILITÉ, QUE CE SOIT DANS LE CADRE D'UN CONTRAT, D'UN DÉLIT OU AUTREMENT, DÉCOULANT DE OU EN RELATION AVEC LE LOGICIEL OU SON UTILISATION OU D'AUTRES TRANSACTIONS AVEC LE LOGICIEL.

---

## العربية

GlobalHotKeys هي مكتبة .NET صغيرة لتسجيل مفاتيح الاختصار العالمية (HotKeys) على نظام Windows، كتبها Martin Kramer (https://lostindetails.com).

تسمح المكتبة للتطبيق بالتفاعل مع أحداث الضغط على المفاتيح حتى لو لم يكن التطبيق في بؤرة التركيز (focus) حالياً.

## معلومات إضافية
لمزيد من المعلومات يرجى زيارة: https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## التثبيت
ثبّت حزمة NuGet عبر `dotnet add package`:
```bat
dotnet add package GlobalHotKeys.Windows
```

## مثال على الاستخدام
يرجى إلقاء نظرة على الأمثلة الموجودة في مجلد `src/Examples`.

فيما يلي مثال لتطبيق وحدة تحكم (Console) بلغة C#:

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## مزايا الكود المصدري
- C#
- أمثلة لـ
  - WinForms
  - Wpf
  - Console (وحدة التحكم)
  - AvaloniaUI
- يطبّق حلقة رسائل بسيطة (Message Loop)

## الترخيص
هذه المكتبة مرخّصة بموجب ترخيص مزدوج: WTFPL أو MIT.
هذا يعني أنك حر في اختيار إما ترخيص WTFPL أو ترخيص MIT. والسبب في منحك هذا الخيار هو أنه على الرغم من أن WTFPL هو الترخيص الأكثر سماحاً، إلا أن ترخيص MIT أكثر شهرة.

### COPYRIGHT - WTFPL
حقوق النشر © 2021 Martin Kramer (https://lostindetails.com)
هذا العمل حر. يمكنك إعادة توزيعه و/أو تعديله بموجب شروط رخصة «افعل ما تشاء» العامة (Do What The Fuck You Want To Public License)، الإصدار 2، التي نشرها Sam Hocevar. راجع http://www.wtfpl.net/ لمزيد من التفاصيل.

### COPYRIGHT - MIT
حقوق النشر © 2021 Martin Kramer (https://lostindetails.com)

يُمنح بموجب هذا الإذن مجاناً لأي شخص يحصل على نسخة من هذا البرنامج وملفات التوثيق المرتبطة به («البرنامج»)، للتعامل مع البرنامج دون أي قيود، بما في ذلك على سبيل المثال لا الحصر حقوق الاستخدام والنسخ والتعديل والدمج والنشر والتوزيع والترخيص من الباطن و/أو بيع نسخ من البرنامج، والسماح للأشخاص الذين يُزودون بالبرنامج بالقيام بذلك، مع مراعاة الشروط التالية:

يجب تضمين إشعار حقوق النشر أعلاه وإشعار الإذن هذا في جميع نسخ البرنامج أو الأجزاء الجوهرية منه.

يُقدَّم البرنامج «كما هو»، دون أي ضمان من أي نوع، صريح أو ضمني، بما في ذلك على سبيل المثال لا الحصر ضمانات القابلية للتسويق والملاءمة لغرض معين وعدم التعدي على الحقوق. لا يتحمل المؤلفون أو أصحاب حقوق النشر في أي حال من الأحوال المسؤولية عن أي مطالبة أو أضرار أو مسؤولية أخرى، سواء في إطار عقد أو تقصير أو غير ذلك، تنشأ عن البرنامج أو فيما يتعلق به أو عن استخدامه أو التعاملات الأخرى معه.

---

## Русский

GlobalHotKeys — это крошечная .NET-библиотека для регистрации глобальных горячих клавиш в Windows, написанная Мартином Крамером (Martin Kramer, https://lostindetails.com).

Библиотека позволяет приложению реагировать на события нажатия клавиш, даже если приложение в данный момент не имеет фокуса.

## Дополнительная информация
Дополнительную информацию см. на сайте: https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## Установка
Установите пакет NuGet с помощью `dotnet add package`:
```bat
dotnet add package GlobalHotKeys.Windows
```

## Пример использования
Ознакомьтесь с примерами в папке `src/Examples`.

Вот пример для консольного приложения на C#:

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## Особенности исходного кода
- C#
- Примеры для
  - WinForms
  - Wpf
  - Console (консоль)
  - AvaloniaUI
- Реализует простой цикл сообщений

## Лицензия
Эта библиотека распространяется под двойной лицензией WTFPL или MIT.
Это означает, что вы можете свободно выбрать либо лицензию WTFPL, либо лицензию MIT. Причина, по которой вам предоставляется выбор, заключается в том, что хотя WTFPL является более разрешительной лицензией, лицензия MIT более известна.

### COPYRIGHT - WTFPL
Copyright © 2021 Martin Kramer (https://lostindetails.com)
Эта работа является свободной. Вы можете распространять её и/или изменять её на условиях Do What The Fuck You Want To Public License, версии 2, опубликованной Сэмом Хосеваром (Sam Hocevar). Подробнее см. http://www.wtfpl.net/.

### COPYRIGHT - MIT
Copyright © 2021 Martin Kramer (https://lostindetails.com)

Настоящим предоставляется бесплатное разрешение любому лицу, получившему копию этого программного обеспечения и связанных с ним файлов документации («Программное обеспечение»), использовать Программное обеспечение без ограничений, включая, без ограничений, права на использование, копирование, изменение, объединение, публикацию, распространение, сублицензирование и/или продажу копий Программного обеспечения, а также разрешать лицам, которым предоставляется Программное обеспечение, делать это при следующих условиях:

Вышеуказанное уведомление об авторских правах и данное уведомление о разрешении должны быть включены во все копии или значительные части Программного обеспечения.

ПРОГРАММНОЕ ОБЕСПЕЧЕНИЕ ПРЕДОСТАВЛЯЕТСЯ «КАК ЕСТЬ», БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ, ЯВНЫХ ИЛИ ПОДРАЗУМЕВАЕМЫХ, ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ, ГАРАНТИЯМИ ТОВАРНОЙ ПРИГОДНОСТИ, ПРИГОДНОСТИ ДЛЯ ОПРЕДЕЛЁННОЙ ЦЕЛИ И ОТСУТСТВИЯ НАРУШЕНИЯ ПРАВ. НИ В КОЕМ СЛУЧАЕ АВТОРЫ ИЛИ ПРАВООБЛАДАТЕЛИ НЕ НЕСУТ ОТВЕТСТВЕННОСТИ ЗА КАКИЕ-ЛИБО ПРЕТЕНЗИИ, УБЫТКИ ИЛИ ИНУЮ ОТВЕТСТВЕННОСТЬ, БУДЬ ТО В РАМКАХ ДОГОВОРА, ДЕЛИКТА ИЛИ ИНЫМ ОБРАЗОМ, ВОЗНИКАЮЩИЕ ИЗ ИЛИ В СВЯЗИ С ПРОГРАММНЫМ ОБЕСПЕЧЕНИЕМ ИЛИ ЕГО ИСПОЛЬЗОВАНИЕМ ИЛИ ИНЫМИ ДЕЙСТВИЯМИ С НИМ.

---

## Português

GlobalHotKeys é uma pequena biblioteca .NET para registrar teclas de atalho globais (HotKeys) no Windows, escrita por Martin Kramer (https://lostindetails.com).

A biblioteca permite que um aplicativo reaja a eventos de pressionamento de teclas, mesmo que o aplicativo não tenha o foco no momento.

## Informações adicionais
Para obter mais informações, visite: https://lostindetails.com/articles/Global-HotKeys-for-Windows-Applications

## Instalação
Instale o pacote NuGet via `dotnet add package`:
```bat
dotnet add package GlobalHotKeys.Windows
```

## Exemplo de uso
Dê uma olhada nos exemplos na pasta `src/Examples`.

Aqui está um exemplo para um aplicativo de console em C#:

```cs
using System;
using GlobalHotKeys;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
```

## Destaques do código-fonte
- C#
- Exemplos para
  - WinForms
  - Wpf
  - Console
  - AvaloniaUI
- Implementa um loop de mensagens simples

## Licença
Esta biblioteca é licenciada duplamente sob a WTFPL ou MIT.
Isso significa que você é livre para escolher a licença WTFPL ou a licença MIT. A razão para lhe dar essa opção é que, embora a WTFPL seja a licença mais permissiva, a licença MIT é mais conhecida.

### COPYRIGHT - WTFPL
Copyright © 2021 Martin Kramer (https://lostindetails.com)
Este trabalho é livre. Você pode redistribuí-lo e/ou modificá-lo sob os termos da Do What The Fuck You Want To Public License, Versão 2, publicada por Sam Hocevar. Veja http://www.wtfpl.net/ para mais detalhes.

### COPYRIGHT - MIT
Copyright © 2021 Martin Kramer (https://lostindetails.com)

A permissão é concedida por meio deste, gratuitamente, a qualquer pessoa que obtenha uma cópia deste software e dos arquivos de documentação associados (o "Software"), para lidar com o Software sem restrição, incluindo, sem limitação, os direitos de usar, copiar, modificar, fundir, publicar, distribuir, sublicenciar e/ou vender cópias do Software, e permitir que as pessoas a quem o Software é fornecido façam o mesmo, sujeito às seguintes condições:

O aviso de direitos autorais acima e este aviso de permissão devem ser incluídos em todas as cópias ou partes substanciais do Software.

O SOFTWARE É FORNECIDO "COMO ESTÁ", SEM GARANTIA DE QUALQUER TIPO, EXPRESSA OU IMPLÍCITA, INCLUINDO, MAS NÃO SE LIMITANDO A, GARANTIAS DE COMERCIABILIDADE, ADEQUAÇÃO A UM FIM ESPECÍFICO E NÃO VIOLAÇÃO. EM NENHUM CASO OS AUTORES OU DETENTORES DOS DIREITOS AUTORAIS SERÃO RESPONSÁVEIS POR QUALQUER REIVINDICAÇÃO, DANOS OU OUTRA RESPONSABILIDADE, SEJA EM UMA AÇÃO DE CONTRATO, ATO ILÍCITO OU DE OUTRA FORMA, DECORRENTE DE OU EM CONEXÃO COM O SOFTWARE OU O USO OU OUTRAS TRANSAÇÕES COM O SOFTWARE.

---

