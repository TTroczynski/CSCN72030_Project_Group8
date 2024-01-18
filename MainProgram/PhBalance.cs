using MainProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class PhConstants
{
    public static string NEUTRAL = "Neutral";
    public static string ACIDIC = "Acidic";
    public static string BASIC = "Alkaline";

    public static int LOW_PH = 0;
    public static int NEUTRAL_PH = 7;
    public static int HIGH_PH = 14;
}

namespace MainProgram
{
    public class PhBalance : Device
    {
        //CONSTANTS


        //ATTRIBUTES
        private double phValue;
        private double minPhAlertValue;
        private double maxPhAlertValue;
        private string phLabel;


        //CONSTRUCTORS
        public PhBalance()
        {
            phValue = PhConstants.NEUTRAL_PH; //7
            phLabel = PhConstants.NEUTRAL;
            minPhAlertValue = 6;
            maxPhAlertValue = 8;
            deviceType = DeviceType.phSensor;
        }

        //GETTERS
        public double GetPhValue()
        {
            return phValue;
        }
        public string GetPhLabel()
        {
            return phLabel;
        }

        public double GetMinPhAlertValue()
        {
            return minPhAlertValue;
        }

        public double GetMaxPhAlertValue()
        {
            return maxPhAlertValue;
        }


        //SETTERS
        public void SetPhValue(double phValue)
        {
            this.phValue = phValue;
        }
        public void SetPhLabel(string phLabel)
        {
            this.phLabel = phLabel;
        }
        public void SetMinPhAlertValue(double minPhAlertValue)
        {
            this.minPhAlertValue = minPhAlertValue;
        }
        public void SetMaxPhAlertValue(double maxPhAlertValue)
        {
            this.maxPhAlertValue = maxPhAlertValue;
        }

        //METHODS
        public static string CalculatePhLabel(double phBalance)
        {

            if (phBalance == 7)
                return PhConstants.NEUTRAL;
            else if (phBalance < 7)
                return PhConstants.ACIDIC;
            else
                return PhConstants.BASIC;
        }


        //OVERRIDES
        public override DeviceType GetDeviceType()
        {
            return deviceType;
        }

        public override int CheckFlag()
        {
            int[] flag = new int[1];
            BitArray ba = new BitArray(new int[] { flag[0] });

            //check labels
            if (phValue < 7)        //bit 24
                ba[24] = true;
            else if (phValue == 7)  //bit 25
                ba[25] = true;
            else                    //bit 26
                ba[26] = true;

            //check ranges
            if (phValue < minPhAlertValue || phValue > maxPhAlertValue)
                ba[28] = true;
            else
                ba[27] = true;

            if (ba.Length > 32)
                throw new Exception("Bit Array size cannot fit into 32-bit integer.\n");
            else
                ba.CopyTo(flag, 0);

            return flag[0];

        }

        public override double Update()
        {
            return Stubs.GenerateStubbedValue(phValue, 2);
        }
    }
}
