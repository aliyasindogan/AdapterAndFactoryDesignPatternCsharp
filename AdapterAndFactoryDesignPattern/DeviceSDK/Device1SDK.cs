using System;

namespace AdapterAndFactoryDesignPattern
{
    public class Device1SDK
    {
        public string Connection(string ip, int port)
        {
            return $@"Device 1'e IP:{ip} Port:{port} ile bağlantı sağlandı!";
        }
    }
}