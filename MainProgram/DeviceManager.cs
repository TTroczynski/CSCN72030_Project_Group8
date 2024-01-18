using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainProgram
{

    public class DeviceManager
    {
        private Dictionary<DeviceType, Device> devices = new Dictionary<DeviceType, Device>();

        public bool GetDevice(DeviceType typeNumber, ref Device connectedDevice)
        {
            Device foundDevice = null;
            if(devices.TryGetValue(typeNumber, out foundDevice))
            {
                connectedDevice = foundDevice;
                return true;
            }
            return false;
        }

        public bool AddDevice(Device newDevice, DeviceType typeNumber)
        {
            if(!devices.ContainsKey(typeNumber))
            {
                devices.Add((DeviceType)typeNumber, newDevice);
                return true;
            }
            return false;
        }

        public bool RemoveDevice(DeviceType typeNumber)
        {
            return devices.Remove(typeNumber);
        }

        public void Update()
        {
            foreach (Device device in devices.Values)
            {
                device.Update();
            }
        }
        public int GetDeviceFaults(DeviceType typeNumber)
        {
            Device tempDevice = null;
            if(devices.TryGetValue(typeNumber, out tempDevice))
            {
                return devices[(DeviceType)typeNumber].CheckFlag();
            }
            return TankGuiGlobals.NEGONE_INT;
        }
    }
}
