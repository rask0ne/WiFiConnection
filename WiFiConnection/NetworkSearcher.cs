using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;
using SimpleWifi;
using SimpleWifi.Win32;
using WlanClient = NativeWifi.WlanClient;

namespace WiFiNetworks
{
    class NetworkSearcher
    {
        private readonly Wifi _wifi = new Wifi();
        private WlanClient _wlanClient = new WlanClient();

        public List<WiFiNetwork> GetNetworks()
        {
            var networks = new List<WiFiNetwork>();
            foreach (var accessPoint in _wifi.GetAccessPoints())
            {
                networks.Add(new WiFiNetwork()
                {
                    Name = accessPoint.Name,
                    SignalStrength = accessPoint.SignalStrength.ToString() + "%",
                    Description = accessPoint.ToString(),
                    BssId = GetBssId(accessPoint),
                    IsSecured = accessPoint.IsSecure,
                    IsConnected = accessPoint.IsConnected
                });
            }
            return networks;
        }

        private List<string> GetBssId(AccessPoint accessPoint)
        {
            var wlanInterface = _wlanClient.Interfaces.FirstOrDefault();
            return wlanInterface?.GetNetworkBssList()
                .Where(x => Encoding.ASCII.GetString(x.dot11Ssid.SSID, 0, (int)x.dot11Ssid.SSIDLength).Equals(accessPoint.Name))
                .Select(y => Dot11BSSTostring(y)).ToList();
        }

        private string Dot11BSSTostring(Wlan.WlanBssEntry entry)
        {
            var bssIdBuilder = new StringBuilder();
            foreach (byte bssByte in entry.dot11Bssid)
            {
                bssIdBuilder.Append(bssByte.ToString("X"));
                bssIdBuilder.Append("-");
            }
            bssIdBuilder.Remove(bssIdBuilder.Length - 1, 1);
            return bssIdBuilder.ToString();
        }
    }
}
