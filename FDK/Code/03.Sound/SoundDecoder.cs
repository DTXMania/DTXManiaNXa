namespace FDK
{
    /// <summary>
    /// xa,oggデコード用の基底クラス
    /// </summary>
    public abstract class SoundDecoder //: IDisposable
    {
        public long nTotalPCMSize { get; protected set; }
        public CWin32.WAVEFORMATEX wfx { get; protected set; }

        public abstract int Open( string filename );
        /// <returns>
        /// <para lang="ja">実際にデコードされたバイト数。</para>
        /// <para lang="en">The number of bytes actually decoded.</para>
        /// </returns>
        public abstract long Decode( ref byte[] Dest, long offset );
        public abstract void Close();
    }
}
