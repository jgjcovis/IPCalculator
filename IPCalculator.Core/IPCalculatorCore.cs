using System.Net;

namespace IPCalculatorNS
{
    public class IPCalculatorCore
    {
        
        public static string ConvertToBinary(string ipAddress)
        {
            if (!IPAddress.TryParse(ipAddress, out IPAddress? address))
            {
                throw new FormatException($"{ipAddress} is not in correct format");
            }

            byte[] bytes = address.GetAddressBytes();
            string[] octets = new string[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                octets[i] = Convert.ToString(bytes[i], 2).PadLeft(8, '0');
            }

            string binaryAddress = string.Join(".", octets);
            return binaryAddress;
        }

        public static string ConvertBinaryToIP(string binaryIpAddress)
        {
            if (binaryIpAddress == null)
            {
                throw new ArgumentNullException();
            }
            if (!(binaryIpAddress.Split(".").All(octet => octet.Length == 8 && System.Text.RegularExpressions.Regex.IsMatch(octet, "^[01]{8}$"))
                && binaryIpAddress.Split(".").Length == 4))
            {
                throw new FormatException($"{nameof(binaryIpAddress)} is not in correct format.");
            }
            else
            {
                string[] octets = binaryIpAddress.Split('.');
                string[] segments = new string[octets.Length];
                for (int i = 0; i < octets.Length; i++)
                {
                    segments[i] = Convert.ToString(Convert.ToByte(octets[i], 2), 10);
                }

                string ipAddress = string.Join(".", segments);  

                return ipAddress;
            }
        }

        public static NetworkInfo Calculate(string ipAddress, int subnetSuffix)
        {
            if (!IPAddress.TryParse(ipAddress, out _))
            {
                throw new FormatException($"{nameof(ipAddress)} is not in correct format");
            }
            if (subnetSuffix < 0 || subnetSuffix > 30)
            {
                throw new ArgumentOutOfRangeException($"{nameof(subnetSuffix)} is not within the range of 0 to 30");
            }

            char[] ipAddressBits = ConvertToBinary(ipAddress).Replace(".", "").ToCharArray();
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
