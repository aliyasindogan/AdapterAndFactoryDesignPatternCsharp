namespace AdapterAndFactoryDesignPattern
{
    public class Device1SDKAdapter : IDeviceAdapter
    {
        public string DeviceConnection(string ip, int port)
        {
            Device1SDK device1SDK = new Device1SDK();
            return device1SDK.Connection(ip, port);
        }

         
    }
}