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
    public static class NitrateConstants
    {
        public const string NITRATELOW = "Too Low";
        public const string NITRATENEUTRAL = "Neutral";
        public const string NITRATEHIGH = "Too High";
        public const int NEUTRALVALUE = 10;
    }
    public static class NitrateGlobals
    {
        public const int THRESHOLD_LOW = 4;
        public const int THRESHOLD_NEUTRAL = 10;
        public const int THRESHOLD_HIGH = 17;

        public const int THRESHOLD_VARIANCE = 1;
    }

    public class Nitrate : Device
    {
        private double nitrateValue;
        private string nitrateLabel;
        private double nitrateThresholdMin;
        private double nitrateThresholdMax;

        //constructor
        public Nitrate()
        {
            nitrateValue = NitrateConstants.NEUTRALVALUE;               //neutral values
            nitrateLabel = NitrateConstants.NITRATENEUTRAL;
            nitrateThresholdMin = 0;
            nitrateThresholdMax = 100;
            deviceType = DeviceType.nitrateSensor;
        }

        //getters
        public double getNitrateValue()
        {
            return nitrateValue;
        }
        public string getNitrateLabel()
        {
            return nitrateLabel;
        }
        public double getThresholdMin()
        {
            return nitrateThresholdMin;
        }
        public double getThresholdMax()
        {
            return nitrateThresholdMax;
        }

        //setters
        public void setNitrateValue(double nitrateValue)
        {
            this.nitrateValue = nitrateValue;
        }
        public void setNitrateLabel(string nitrateLabel)
        {
            this.nitrateLabel = nitrateLabel;
        }
        public void setThresholdMin(double nitrateThresholdMin)
        {
            this.nitrateThresholdMin = nitrateThresholdMin;
        }
        public void setThresholdMax(double nitrateThresholdMax)
        {
            this.nitrateThresholdMax = nitrateThresholdMax;
        }

        //other methods
        public string calculateNitrateLabel(double nitrateValue)
        {
            if (nitrateValue <= 5)
            {
                return NitrateConstants.NITRATELOW;   //returning "too low"
            }
            else if (nitrateValue >= 6 && nitrateValue <= 15)
            {
                return NitrateConstants.NITRATENEUTRAL;   //returning "neutral"
            }
            else if (nitrateValue >= 16)
            {
                return NitrateConstants.NITRATEHIGH;   //returning "too high"
            }
            else
            {
                return NitrateConstants.NITRATEHIGH;
            }

        }
        public override double Update()
        {
            return Stubs.GenerateStubbedValue(NitrateGlobals.THRESHOLD_NEUTRAL, NitrateGlobals.THRESHOLD_VARIANCE);
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
            if (nitrateValue <= 5)
                ba[22] = true;
            else if (nitrateValue >= 6 && nitrateValue <= 15)
                ba[23] = true;
            else
                ba[24] = true;

            if (ba.Length > 32)
                throw new Exception("Bit array size cannot fit into 32-bit interger.\n");
            else
                ba.CopyTo(flag, 0);
            return flag[0];
        }
    }
}
