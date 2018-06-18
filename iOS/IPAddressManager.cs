using System.Net;
using GetMyIpAddress.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(IPAddressManager))]
namespace GetMyIpAddress.iOS
{
    public class IPAddressManager : IIPAddressManager
    {
        /// <summary>
        /// Retorna o IP do aplicativo
        /// </summary>
        /// <returns></returns>
        public string GetIPAddress()
        {
            IPAddress[] adresses = Dns.GetHostAddresses(Dns.GetHostName());

            if (adresses != null && adresses[0] != null)
            {
                return adresses[0].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}