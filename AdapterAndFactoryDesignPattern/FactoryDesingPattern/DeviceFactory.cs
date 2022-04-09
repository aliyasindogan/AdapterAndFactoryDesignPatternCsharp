namespace AdapterAndFactoryDesignPattern
{
    public class DeviceFactory : IDeviceFactory
    {
        public string DeviceConnection(Device device)
        {
            IDeviceAdapter deviceAdapter1 = new Device1SDKAdapter();
            IDeviceAdapter deviceAdapter2 = new Device2SDKAdapter();
            switch (device.DeviceSDKType)
            {
                case DeviceSDKTypes.Device1SDK:
                    return deviceAdapter1.DeviceConnection(device.IP, device.Port);

                case DeviceSDKTypes.Device2SDK:
                    return deviceAdapter2.DeviceConnection(device.IP, device.Port);
            }
            return "";
        }
    }
}