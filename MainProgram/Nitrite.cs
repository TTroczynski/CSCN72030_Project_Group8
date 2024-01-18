using MainProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace MainProgram
{
    public static class NitriteConstants
    {
        public const string NITRITELOW = "Too Low";
        public const string NITRITENEUTRAL = "Neutral";
        public const string NITRITEHIGH = "Too High";
        public const int NEUTRALVALUE = 20;
    }
    public static class NitriteGlobals
    {
        public const int THRESHOLD_LOW = 4;
        public const int THRESHOLD_NEUTRAL = 20;
        public const int THRESHOLD_HIGH = 41;

        public const int THRESHOLD_VARIANCE = 1;
    }

    public class Nitrite : Device
    {
        private double nitriteValue;
        private string nitriteLabel;
        private double nitriteThresholdMin;
        private double nitriteThresholdMax;

        //constructor
        public Nitrite()
        {
            nitriteValue = NitriteConstants.NEUTRALVALUE;               //neutral values
            nitriteLabel = NitriteConstants.NITRITENEUTRAL;
            nitriteThresholdMin = 0;
            nitriteThresholdMax = 100;
            deviceType = DeviceType.nitriteSensor;
        }

        //getters
        public double getNitriteValue()
        {
            return nitriteValue;
        }
        public string getNitriteLabel()
        {
            return nitriteLabel;
        }
        public double getThresholdMin()
        {
            return nitriteThresholdMin;
        }
        public double getThresholdMax()
        {
            return nitriteThresholdMax;
        }

        //setters
        public void setNitriteValue(double nitriteValue)
        {
            this.nitriteValue = nitriteValue;
        }
        public void setNitrateLabel(string nitrateLabel)
        {
            this.nitriteLabel = nitrateLabel;
        }
        public void setThresholdMin(double nitriteThresholdMin)
        {
            this.nitriteThresholdMin = nitriteThresholdMin;
        }
        public void setThresholdMax(double nitriteThresholdMax)
        {
            this.nitriteThresholdMax = nitriteThresholdMax;
        }

        //other methods
        public string calculateNitriteLabel(double nitriteValue)
        {
            if (nitriteValue >= 0.01 && nitriteValue <= 0.9)
            {
                return NitriteConstants.NITRITELOW;   //returning "too low"
            }
            else if (nitriteValue >= 1 && nitriteValue <= 40)
            {
                return NitriteConstants.NITRITENEUTRAL;   //returning "neutral"
            }
            else if (nitriteValue >= 41)
            {
                return NitriteConstants.NITRITEHIGH;   //returning "too high"
            }
            else
                return NitrateConstants.NITRATEHIGH;
        }

        public override double Update()
        {
            return Stubs.GenerateStubbedValue(NitriteGlobals.THRESHOLD_NEUTRAL, NitrateGlobals.THRESHOLD_VARIANCE);
        }

        public override DeviceType GetDeviceType()
        {
            return deviceType;
        }

        public override int CheckFlag()    
        {
            int[] flag = new int[1];
            BitArray ba = new BitArray(new int[] { flag[0] });

            //check values
            if (nitriteValue >= 0.01 && nitriteValue <= 0.9)
                ba[22] = true;
            else if (nitriteValue >= 1 && nitriteValue <= 40)
                ba[23] = true;
            else
                ba[24] = true;

            //check labels

            if (ba.Length > 32)
                throw new Exception("Bit array size cannot fit into 32-bit interger.\n");
            else
                ba.CopyTo(flag, 0);
            return flag[0];
        }
    }
}


