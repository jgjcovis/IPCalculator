using IPCalculatorNS;
using System.Net;

namespace IPCalculator.Core
{
    public class IPConverter : IIPConverter
    {
        public string ToBinary(string ipAddress)
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

        public string ToIP(string binaryIpAddress)
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
    }
}
