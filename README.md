# DTXManiaNXa とは

DTXManiaNXa は、[DTXManiaNX](https://github.com/limyz/DTXmaniaNX) から派生し、いくつかの改修を加えたものです。

## 主な違い

||DTXManiaNX|DTXManiaNXa|
|---|---|---|
|フレームワーク|.NET Framework 4.7.1|.NET 9 (Win7 API)|
|DTXファイル|Shift-JIS|Shift-JIS or UTF-8|
|配布|exe|zip|
|DTX2WAV|対応|未対応
|Discord Rich Presence|?|未対応|

# 実行時リソースについて

DTXManiaNXa のビルドでは、実行時に必要なリソース（Systemフォルダやネイティブdll）も
出力フォルダにコピーする必要があります。
そのため、ビルド後イベントで ``DTXManiaNXa/RuntimeResources/*`` を出力フォルダに ``xcopy`` するようにしています。
（ファイルのプロパティでビルド時にコピーするように設定できますが、すべてのファイルに対して行なう必要があり、面倒かつ漏れやすいので却下。）

