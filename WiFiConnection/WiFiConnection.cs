using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;

namespace WiFiNetworks
{
    class WiFiNetwork
    {
        public string Name { get; set; }
        public string SignalStrength { get; set; }
        public string Description { get; set; }
        public List<string> BssId { get; set; }
        public bool IsSecured { get; set; }
        public bool IsConnected { get; set; }

        public bool Connect(string password)
        {
            var wifi = new Wifi();
            var accessPoint = wifi.GetAccessPoints().FirstOrDefault(x => x.Name.Equals(Name));
            if (accessPoint != null)
            {
                var authRequest = new AuthRequest(accessPoint)
                {
                    Password = password
                };
                return accessPoint.Connect(authRequest);
            }
            return false;
        }

        public bool Disconect()
        {
            new Wifi().Disconnect();
            return true;
        }

        public string GetBssIds()
        {
            var builder = new StringBuilder();
            builder.Append("BssIds: ");
            foreach (var bssId in BssId)
            {
                builder.Append(bssId + "\r\n");
            }
            return builder.ToString();
        }
    }
}
