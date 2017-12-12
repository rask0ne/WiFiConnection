using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WiFiNetworks
{
    class NetworkPing
    {
        public string PingToAddress(string address)
        {
            Ping ping = new Ping();
            PingReply pingReply;
            try
            {
                pingReply = ping.Send(address);
            }
            catch (PingException)
            {
                return "Network connection error";
            }
            return "RoundTripTime: " + pingReply.RoundtripTime
                + "\r\nStatus: " + pingReply.Status 
                + "\r\nAddress: " + pingReply.Address;
        }
    }
}
