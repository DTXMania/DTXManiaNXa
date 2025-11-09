using System.Diagnostics;
using System.Text;
using Ude;

namespace FDK
{
    /// <summary>
    /// 文字コード自動判別機能付きのストリームリーダー。
    /// </summary>
    public static class CStreamReaderWithEncodingDetection
    {
        public static StreamReader Create( string path, bool append = false )
        {
            byte[] bytes = File.ReadAllBytes( path );

            // Ude を使ってエンコーディングを判定
            var detector = new CharsetDetector();
            detector.Feed( bytes, 0, bytes.Length );
            detector.DataEnd();

            // 対応しているのは、Shift_JIS と UTF-8 のみ。
            if( detector.Charset == "Shift-JIS" || detector.Charset == "UTF-8" )
            {
                // 判定できた場合はそのエンコーディングでストリームリーダーを生成して返す。
                return new StreamReader( path, Encoding.GetEncoding( detector.Charset ) );
            }
            else
            {
                // 判定できなかった場合は、すべて Shift-JIS と見なす。
                // ※ Shift-JIS が UTF-16LE や ASCII などと誤解釈されることも多いため、detector.Charaset をそのまま指定することはしない。
                return new StreamReader( path, Encoding.GetEncoding( "Shift-JIS" ) );
            }
        }
    }
}
