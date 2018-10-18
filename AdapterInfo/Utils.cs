using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace AdapterInfo
{
    /// <summary>
    /// utility class, methos created to the app
    /// </summary>
    public class Utils
    {
        public static List<string> GetInterfaces()
        {
            List<string> nicCards = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {   
                nicCards.Add(nic.Name);
            }
            return nicCards;
        }

        public static Dictionary<string,string> GetNicIPAddress(string nicName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var card = NetworkInterface.GetAllNetworkInterfaces().ToList().FirstOrDefault(ent=> ent.Name== nicName);
            if (card != null)
            {
                var ipAdress = card.GetIPProperties().UnicastAddresses.ToList().Where(ent => ent.Address.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault();
                result.Add("IpAddress", ipAdress.Address.ToString());
                var defaultGW = card.GetIPProperties().GatewayAddresses.FirstOrDefault();
                var subnetMask = ipAdress.IPv4Mask.ToString();
                if(defaultGW != null)
                {
                    result.Add("Gateway", defaultGW.Address.ToString());
                }
                else
                {
                    result.Add("Gateway", "No disponible");
                }
                if(subnetMask != null)
                {
                    result.Add("SubnetMask", subnetMask.ToString());
                }
                else
                {
                    result.Add("SubnetMask", "No disponible");
                }
                return result;
            }
            return null;
        }
    }
}
