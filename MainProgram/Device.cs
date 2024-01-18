using MainProgram;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public enum DeviceType
    {
        pump,
        heater,
        phSensor,
        nitrateSensor,
        nitriteSensor,
        ammoniaSensor,
        salinitySensor,
        hardnessSensor,
    }

    public abstract class Device
    {
        protected DeviceType deviceType;

        public abstract double Update();

        public abstract int CheckFlag();

        public abstract DeviceType GetDeviceType();

    }
    public abstract class DeviceConstants
    {
        public static readonly int DeviceTypeCount = 8;
    }
}

