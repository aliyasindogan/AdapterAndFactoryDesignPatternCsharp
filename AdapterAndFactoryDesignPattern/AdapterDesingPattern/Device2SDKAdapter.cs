namespace AdapterAndFactoryDesignPattern
{
    public class Device2SDKAdapter : IDeviceAdapter
    {
        public string DeviceConnection(string ip, int port)
        {
            Device2SDK device2SDK = new Device2SDK();
            var data = device2SDK.ConnectionTCP(ip);
            return data;
        }
    }
}