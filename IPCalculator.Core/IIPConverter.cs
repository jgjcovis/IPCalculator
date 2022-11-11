namespace IPCalculatorNS
{
    public interface IIPConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        string ToBinary(string ipAddress);

        string ToIP(string binaryIpAddress);
    }
}