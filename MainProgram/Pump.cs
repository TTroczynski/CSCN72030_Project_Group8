
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;


namespace MainProgram
{
    public class Pump : Device
    {
        private double flowRate;
        private bool operatingState;
        private const int FLAGSTART = 1;

        public Pump()
        {
            this.flowRate = 0;
            this.operatingState = true;
            this.deviceType = DeviceType.pump;
        }

        public void SetFlowRate(double newFlowRate)
        {
            if (newFlowRate > PumpGlobals.MAXFLOWRATE)
            {
                this.flowRate = PumpGlobals.MAXFLOWRATE;
            }
            else if (newFlowRate < PumpGlobals.MINFLOWRATE)
            {
                this.flowRate = PumpGlobals.MINFLOWRATE;
            }
            else
            {
                this.flowRate = newFlowRate;
            }
        }

        public double GetFlowRate()
        {
            return this.flowRate;
        }

        public bool IsOperating()
        {
            int[] flag = new int[FLAGSTART];
            BitArray ba = new BitArray(new int[] { flag[FLAGSTART - 1] });

            ba[FLAGSTART] = Stubs.IsOperatingStub();
            if (ba[FLAGSTART] == true)
            {
                operatingState = true;
                return operatingState;
            }

            return false;
        }

        public override double Update()
        {
            Console.WriteLine(flowRate.ToString());
            return Stubs.GenerateStubbedValue(this.flowRate, HardnessAndPumpStubConstants.SIMULATED_PUMP_VARIANCE);
        }

        public override int CheckFlag()
        {
            return Stubs.GenerateFlag(HardnessAndPumpStubConstants.MINFLAGVALUE);
        }

        public override DeviceType GetDeviceType()
        {
            return this.deviceType;
        }
    }
}
