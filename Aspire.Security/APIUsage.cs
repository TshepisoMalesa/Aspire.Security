using System.Net;

namespace Aspire.Security
{
  public class APIUsage
  {
    public static string GetUserIP()
    {
      string? hostName = Dns.GetHostName();
      // Get the IP from GetHostByName method of dns class.
      List<IPAddress> ips = Dns.GetHostByName(hostName).AddressList.ToList();
      List<String> ipNames = new List<String>();

      ips.ForEach(ip =>
      {
        ipNames.Add(ip.ToString());
      });
      
      return ipNames.FirstOrDefault();

    }
  }
}