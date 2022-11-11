using IPCalculatorNS;

namespace IPCalculator.Core
{
    public interface INetworkInfoCalculator
    {
        NetworkInfo Calculate(string ipAddress, int subnetSuffix);
    }
}
