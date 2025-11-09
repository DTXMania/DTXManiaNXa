using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DTXCreatorNXa
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
            // .NET (Core 以降) では、Shift-JIS を利用可能にするために、プロバイダの明示的な登録が必要。
            Encoding.RegisterProvider( CodePagesEncodingProvider.Instance );

#if DEBUG
#if USE_ENGLISHRESOURCE
			Thread.CurrentThread.CurrentUICulture = new CultureInfo( "en-GB", false );	// yyagi; For testing English resources
#elif USE_GERMANRESOURCE
			Thread.CurrentThread.CurrentCulture = new CultureInfo( "de-DE", false );	// yyagi; For testing decimal point in German resources
#endif
#endif
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new CMainForm() );
		}
	}
}
