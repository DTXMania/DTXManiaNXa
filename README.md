# DTXManiaNXa

DTXManiaNXa は、[DTXManiaNX](https://github.com/limyz/DTXmaniaNX) から派生し、いくつかの改修を加えたものです。

## 主な違い

||DTXManiaNX|DTXManiaNXa|
|---|---|---|
|フレームワーク|.NET Framework 4.7.1|.NET 9 (Win7 API)|
|DTXファイル|Shift-JIS|Shift-JIS or UTF-8|
|配布|exe|zip|
|DTX2WAV|対応|未対応
|Discord Rich Presence|?|未対応|

# DirectX ユーザランタイムについて

DTXManiaNXa は Direct3D9 を使用しています。
もし [DirectX エンドユーザランタイム](https://www.microsoft.com/ja-jp/download/details.aspx?id=35)をまだインストールしたことがなければ、先にインストールしてください。

# リリースファイルの作成手順

1. DTXManiaNXaプロジェクトを発行する。
1. DTXCreatorNXaプロジェクトを発行する。
1. DTXCreatorNXaの発行内容（exeが1つだけ）を、DTXManiaNXaの発行先フォルダにコピー。
1. DTXManiaNXaの発行先フォルダを「DTXManiaNXa」に改名し、そのフォルダを zip 化。
1. zip のファイル名を変更（例：``DTXManiaNXa-1.0.0.zip``）。
