using System.Runtime.InteropServices;

namespace FDK
{
    public static class COS
    {
        /// <summary>
        /// OSがXP以前ならfalse, Vista以降ならtrueを返す
        /// </summary>
        /// <returns></returns>
        public static bool bIsVistaOrLater()
        {
            return bCheckOSVersion( 6, 0 );
        }
        /// <summary>
        /// OSがVista以前ならfalse, Win7以降ならtrueを返す
        /// </summary>
        /// <returns></returns>
        public static bool bIsWin7OrLater()
        {
            return bCheckOSVersion( 6, 1 );
        }
        /// <summary>
        /// OSがWin7以前ならfalse, Win8以降ならtrueを返す
        /// </summary>
        /// <returns></returns>
        public static bool bIsWin8OrLater()
        {
            return bCheckOSVersion( 6, 2 );
        }
        /// <summary>
        /// OSがWin10以前ならfalse, Win10以降ならtrueを返す
        /// </summary>
        /// <returns></returns>
        public static bool bIsWin10OrLater()
        {
            return bCheckOSVersion( 10, 0 );
        }

        /// <summary>
        /// 指定のOSバージョン以上であればtrueを返す
        /// </summary>
        private static bool bCheckOSVersion( int major, int minor )
        {
            //プラットフォームの取得
            //System.OperatingSystem os = System.Environment.OSVersion;
            //if (os.Platform != PlatformID.Win32NT)      // NT系でなければ、XP以前か、PC Windows系以外のOS。
            //{
            //	return false;
            //}
            //var mmb = tpGetOSVersion();
            int _major, _minor, _build;
            tpGetOSVersion( out _major, out _minor, out _build );

            //if (os.Version.Major >= major && os.Version.Minor >= minor)
            if( _major > major )
            {
                return true;
            }
            else if( _major == major && _minor >= minor )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// <para lang="ja">現在の Windows のバージョンを取得する。</para>
        /// <para lang="en">Gets the current Windows version.</para>
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        /// <param name="build"></param>
        private static void tpGetOSVersion( out int major, out int minor, out int build )
        {
            OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX();
            osVersionInfo.dwOSVersionInfoSize = Marshal.SizeOf( typeof( OSVERSIONINFOEX ) );
            RtlGetVersion( ref osVersionInfo );
            major = osVersionInfo.dwMajorVersion;
            minor = osVersionInfo.dwMinorVersion;
            build = osVersionInfo.dwBuildNumber;
        }

        [StructLayout( LayoutKind.Sequential )]
        private struct OSVERSIONINFOEX
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs( UnmanagedType.ByValTStr, SizeConst = 128 )]
            public string szCSDVersion;
        }

        [DllImport( "ntdll.dll" )]
        static extern int RtlGetVersion( ref OSVERSIONINFOEX versionInfo );
    }
}
