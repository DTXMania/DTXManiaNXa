using System.Runtime.Serialization;

namespace FDK
{
    /// <summary>
    /// テクスチャの作成に失敗しました。
    /// </summary>
    public class CTextureCreateFailedException : Exception
    {
        public CTextureCreateFailedException()
        {
        }
        public CTextureCreateFailedException( string message )
            : base( message )
        {
        }
        [Obsolete( "This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}" )]
        public CTextureCreateFailedException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
        public CTextureCreateFailedException( string message, Exception innerException )
            : base( message, innerException )
        {
        }
    }
}
