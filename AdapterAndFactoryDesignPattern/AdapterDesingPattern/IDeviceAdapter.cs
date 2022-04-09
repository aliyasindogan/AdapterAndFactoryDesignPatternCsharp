namespace AdapterAndFactoryDesignPattern
{
    public interface IDeviceAdapter
    {
        string DeviceConnection(string ip, int port);
    }
}