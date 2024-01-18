using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public static class Stubs
    {
        public static double GenerateStubbedValue(double baseValue, double acceptableOffset)
        {
            Random random = new Random();
            double offsetValue = random.NextDouble() * acceptableOffset;

            int temp = random.Next(1, 3);   //if 1, add the offset, if 2, subtract the offset

            if (temp == 1)
                return baseValue + (offsetValue * 1);
            else
                return ((baseValue + (offsetValue * -1)) >= TankGuiGlobals.ZERO_INT) ? baseValue + (offsetValue * -1) : baseValue;
        }

        public static int GenerateFlag(int maintain_State = 0)
        {
            Random random = new Random();
            if (maintain_State > 0)
            {
                return maintain_State;
            }
            else
            {
                return random.Next(HardnessAndPumpStubConstants.MINFLAGVALUE, HardnessAndPumpStubConstants.MAXFLAGVALUE);
            }
        }

        public static bool IsOperatingStub()
        {
            return true;
        }
    }

    public static class HardnessAndPumpStubConstants
    {
        public static int MINFLAGVALUE = 1073790976;
        //110000000000000010000000000000

        public static int MAXFLAGVALUE = 1610645503;//11000000000000001111111111111111

        public static int SINGLEFLAGVALUE = 1610629120;

        public static uint MINALARM = 16;

        public static uint MAXALARM = 31;

        public static double SIMULATED_HARDNESS_BASEVALUE = 0.5;

        public static double SIMULATED_HARDNESS_VARIANCE = 0.05;

        public static double SIMULATED_PUMP_VARIANCE = 1;
    }
}
