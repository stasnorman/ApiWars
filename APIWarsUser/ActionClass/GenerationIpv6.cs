using APIWarsUser.ActionClass.HelperClass.World.Model;
using System.Net;

namespace APIWarsUser.ActionClass
{
    public class GenerationIpv6
    {
        private int? _countIp { get; set; }
        private List<string> _ipAddresses = new();
        private Random _GenerationIP { get; set; } = new Random();
        public GenerationIpv6(int countKey)
        {
            _countIp = countKey;
        }

        public List<string> GenerationIP() {

            for (int i = 0; i < _countIp; i++)
            {
                byte[] bytes = new byte[16];
                new Random().NextBytes(bytes);
                IPAddress ipv6Address = new IPAddress(bytes);
                string addressString = ipv6Address.ToString();
                _ipAddresses.Add(addressString);
            }

            return _ipAddresses;
        }
    }
}
