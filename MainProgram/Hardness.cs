using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainProgram
{

    public class HardnessConstants
    {
        public const double MAXHARDNESS = 1;
        public const double MINHARDNESS = 0;
    }
    public class Hardness : Device
    {
        private double threshold;
        public Hardness()
        {
            threshold = 0;
            this.deviceType = DeviceType.hardnessSensor;
        }

        public void SetThreshold(double newThreshold)
        {
            this.threshold = newThreshold;
        }

        public double GetThreshold()
        {
            return this.threshold;
        }

        public override double Update()
        {
            return Stubs.GenerateStubbedValue(HardnessAndPumpStubConstants.SIMULATED_HARDNESS_BASEVALUE, HardnessAndPumpStubConstants.SIMULATED_HARDNESS_VARIANCE);
        }

        public override int CheckFlag()
        {
            if(threshold > HardnessAndPumpStubConstants.SIMULATED_HARDNESS_BASEVALUE)
            {
                return Stubs.GenerateFlag(Globals.BELOW_THRESHOLD);
            }
            return Stubs.GenerateFlag(HardnessAndPumpStubConstants.MINFLAGVALUE);
        }

        public override DeviceType GetDeviceType()
        {
            return this.deviceType;
        }
    }
}
