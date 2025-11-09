using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedBass;
using ManagedBass.Asio;
using ManagedBass.Mix;

namespace FDK
{
    public static class BassAux
    {
        public static BassActive BassMix_ChannelIsActive( int handle )
        {
            BassFlags bASSFlag = BassMix.ChannelFlags( handle, BassFlags.Prescan, BassFlags.Default );
            if( bASSFlag < BassFlags.Default )
            {
                return BassActive.Stopped;
            }

            if( ( bASSFlag & BassFlags.Prescan ) != 0 )
            {
                return BassActive.Paused;
            }

            return BassActive.Playing;
        }
        public static bool BASS_Mixer_ChannelPlay( int handle )
        {
            if( BassMix.ChannelFlags( handle, BassFlags.Default, BassFlags.Prescan ) >= BassFlags.Default )
            {
                return true;
            }

            return false;
        }
        public static bool BASS_Mixer_ChannelPause( int handle )
        {
            if( BassMix.ChannelFlags( handle, BassFlags.Prescan, BassFlags.Prescan ) > BassFlags.Default )
            {
                return true;
            }

            return false;
        }

        public static AsioDeviceInfo[] BASS_ASIO_GetDeviceInfos()
        {
            var list = new List<AsioDeviceInfo>();

            for( int num = 0; num < BassAsio.DeviceCount; num++ )
            {
                AsioDeviceInfo item = BassAsio.GetDeviceInfo( num );
                list.Add( item );
            }

            var _ = BassAsio.CPUUsage;
            return list.ToArray();
        }
        public static DeviceInfo[] BASS_GetDeviceInfos()
        {
            var list = new List<DeviceInfo>();
            DeviceInfo item;
            for( int num = 0; num < Bass.DeviceCount; num++ )
            {
                item = Bass.GetDeviceInfo( num );
                list.Add( item );
                num++;
            }

            var _ = Bass.CPUUsage;
            return list.ToArray();
        }
    }
}