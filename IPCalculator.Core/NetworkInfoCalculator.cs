using IPCalculator.Core;
using System.Net;

namespace IPCalculatorNS
{
    public class NetworkInfoCalculator : INetworkInfoCalculator
    {
        private readonly IIPConverter converter;

        public NetworkInfoCalculator(IIPConverter converter)
        {
            this.converter = converter;
        }

        public NetworkInfo Calculate(string ipAddress, int subnetSuffix)
        {
            if (!IPAddress.TryParse(ipAddress, out _))
            {
                throw new FormatException($"{nameof(ipAddress)} is not in correct format");
            }
            if (subnetSuffix < 0 || subnetSuffix > 30)
            {
                throw new ArgumentOutOfRangeException($"{nameof(subnetSuffix)} is not within the range of 0 to 30");
            }

            char[] ipAddressBits = converter.ToBinary(ipAddress)?.Replace(".", "")?.ToCharArray();
            char[] networkAddressBits = ipAddressBits.ToArray();
            char[] broadcastAddressBits = ipAddressBits.ToArray();
            for (int i = subnetSuffix; i < 32; i++)
            {
                networkAddressBits[i] = '0';
                broadcastAddressBits[i] = '1';
            }

            char[][] networkOctets = networkAddressBits.Chunk(8).ToArray();
            char[][] broadcastOctets = broadcastAddressBits.Chunk(8).ToArray();
            string[] networkSegments = new string[networkOctets.Length];
            string[] broadcastSegments = new string[broadcastOctets.Length];
            for (int i = 0; i < networkOctets.Count(); i++)
            {
                networkSegments[i] = Convert.ToString(Convert.ToByte(string.Join("", networkOctets[i]), 2), 10);
                broadcastSegments[i] = Convert.ToString(Convert.ToByte(string.Join("", broadcastOctets[i]), 2), 10);
            }

            NetworkInfo networkInfo = new NetworkInfo();
            networkInfo.NetworkAddress = string.Join(".", networkSegments); ;
            networkInfo.BroadcastAddress = string.Join(".", broadcastSegments); ;

            return networkInfo;
        }
    }
}