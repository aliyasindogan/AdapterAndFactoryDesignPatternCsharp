namespace AdapterAndFactoryDesignPattern
{
    public class Device2SDK
    {
        public string ConnectionTCP(string ip)
        {
            return $@"Device 2'e IP:{ip} Port:2048 ile bağlantı sağlandı!";
        }
    }
}