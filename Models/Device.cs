using System.Net.Sockets;

namespace Tumbleweed.Models
{
    class Device
    {
        public string Name { set; get; }

        public string Type { set; get; }

        public string IPAddress { set; get; }

        private readonly TcpClient _tcpClient;

        public Device(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
        }
    }
}
