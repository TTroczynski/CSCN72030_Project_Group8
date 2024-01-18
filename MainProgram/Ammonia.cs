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

    public static class AmmoniaConstants
    {
        //public const string AMMONIALOW = "Too Low";
        public const string AMMONIANEUTRAL = "Neutral";
        public const string AMMONIAHIGH = "Too High";
        public const int NEUTRALVALUE = 0;
    }
    public static class AmmoniaGlobals
    {
        public const int THRESHOLD_LOW = 0;
        public const double THRESHOLD_NEUTRAL = 0.5;
        public const int THRESHOLD_HIGH = 1;

        public const int THRESHOLD_VARIANCE = 1;
    }

    public class Ammonia : Device
    {
        private double ammoniaValue;
        private string ammoniaLabel;
        private double ammoniaThresholdMin;
        private double ammoniaThresholdMax;

        //constructor
        public Ammonia()
        {
            ammoniaValue = AmmoniaConstants.NEUTRALVALUE;               //neutral values
            ammoniaLabel = AmmoniaConstants.AMMONIANEUTRAL;
            ammoniaThresholdMin = 0;
            ammoniaThresholdMax = 1;
            deviceType = DeviceType.ammoniaSensor;
        }

        //getters
        public double getAmmoniaValue()
        {
            return ammoniaValue;
        }
        public string getAmmoniaLabel()
        {
            return ammoniaLabel;
        }
        public double getThresholdMin()
        {
            return ammoniaThresholdMin;
        }
        public double getThresholdMax()
        {
            return ammoniaThresholdMax;
        }

        //setters
        public void setAmmoniaValue(double ammoniaValue)
        {
            this.ammoniaValue = ammoniaValue;
        }
        public void setAmmoniaLabel(string ammoniaLabel)
        {
            this.ammoniaLabel = ammoniaLabel;
        }
        public void setThresholdMin(double ammoniaThresholdMin)
        {
            this.ammoniaThresholdMin = ammoniaThresholdMin;
        }
        public void setThresholdMax(double ammoniaThresholdMax)
        {
            this.ammoniaThresholdMax = ammoniaThresholdMax;
        }

        //other methods
        public string calculateAmmoniaLabel(double ammoniaValue)
        {
            if (ammoniaValue <= 1)
            {
                return AmmoniaConstants.AMMONIANEUTRAL;   //returning "neutral"
            }
            else if (ammoniaValue > 1)
            {
                return AmmoniaConstants.AMMONIAHIGH;   //returning "too high"
            }
            else
                return AmmoniaConstants.AMMONIAHIGH;

        }
        public override double Update()
        {
            return Stubs.GenerateStubbedValue(AmmoniaGlobals.THRESHOLD_NEUTRAL, AmmoniaGlobals.THRESHOLD_VARIANCE);
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
            if (ammoniaValue <= 1)
                ba[22] = true;
            else if (ammoniaValue > 1)
                ba[23] = true;

            if (ba.Length > 32)
                throw new Exception("Bit array size cannot fit into 32-bit interger.\n");
            else
                ba.CopyTo(flag, 0);
            return flag[0];
        }
    }
}


