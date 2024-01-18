using MainProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SalinityConstants
{
    public static string FRESH = "Fresh Water";                     //<1 000 ppm
    public static string SLI_SALINE = "Slight Saline";            //1 000.1 - 3 000 ppm
    public static string MOD_SALINE = "Moderate Saline";          //3 000.1 - 10 000 ppm
    public static string HIGH_SALINE = "High Saline ";            //10 000.1 - 35 000 ppm
    public static string OCEAN = "Ocean Levels";                    //>35 000.1 ppm

    public static double[] FRESH_RANGE = new double[2] { 0.0, 1000.0 };
    public static double[] SLI_SALINE_RANGE = new double[2] { 1000.1, 3000.0 };
    public static double[] MOD_SALINE_RANGE = new double[2] { 3000.1, 10000.0 };
    public static double[] HIGH_SALINE_RANGE = new double[2] { 10000.1, 35000.0 };
    public static double[] OCEAN_RANGE = new double[2] { 35000.1, 1000000.0 };

    public static int RANGE_START = 0;
    public static int RANGE_END = 1;
}

namespace MainProgram
{
    public class Salinity : Device
    {
        //ATTRIBUTES
        private double salinityValue;
        private double minSalinityAlertValue;
        private double maxSalinityAlertValue;
        private string salinityLabel;

        //CONSTRUCTORS
        public Salinity()
        {
            salinityValue = 6500.0;
            minSalinityAlertValue = 3000.1;
            maxSalinityAlertValue = 10000.0;
            salinityLabel = SalinityConstants.MOD_SALINE;
            deviceType = DeviceType.salinitySensor;
        }

        //GETTERS
        public double GetSalinityValue()
        {
            return salinityValue;
        }
        public string GetSalinityLabel()
        {
            return salinityLabel;
        }

        public double GetMinSalinityAlertValue()
        {
            return minSalinityAlertValue;
        }

        public double GetMaxSalinityAlertValue()
        {
            return maxSalinityAlertValue;
        }

        //SETTERS
        public void SetSalinityValue(double salinityValue)
        {
            this.salinityValue = salinityValue;
        }
        public void SetSalinityLabel(string salinityLabel)
        {
            this.salinityLabel = salinityLabel;
        }

        public void SetMinSalinityAlertValue(double minSalinityAlertValue)
        {
            this.minSalinityAlertValue = minSalinityAlertValue;
        }

        public void SetMaxSalinityAlertValue(double maxSalinityAlertValue)
        {
            this.maxSalinityAlertValue = maxSalinityAlertValue;
        }

        //OTHER METHODS
        public static string CalculateSalinityLabel(double salinityValue)
        {
            if (salinityValue > SalinityConstants.FRESH_RANGE[SalinityConstants.RANGE_START] && salinityValue < SalinityConstants.FRESH_RANGE[SalinityConstants.RANGE_END])
                return SalinityConstants.FRESH;
            else if (salinityValue > SalinityConstants.SLI_SALINE_RANGE[SalinityConstants.RANGE_START] && salinityValue < SalinityConstants.SLI_SALINE_RANGE[SalinityConstants.RANGE_END])
                return SalinityConstants.SLI_SALINE;
            else if (salinityValue > SalinityConstants.MOD_SALINE_RANGE[SalinityConstants.RANGE_START] && salinityValue < SalinityConstants.MOD_SALINE_RANGE[SalinityConstants.RANGE_END])
                return SalinityConstants.MOD_SALINE;
            else if (salinityValue > SalinityConstants.HIGH_SALINE_RANGE[SalinityConstants.RANGE_START] && salinityValue < SalinityConstants.HIGH_SALINE_RANGE[SalinityConstants.RANGE_END])
                return SalinityConstants.HIGH_SALINE;
            else if (salinityValue > SalinityConstants.OCEAN_RANGE[SalinityConstants.RANGE_START] && salinityValue < SalinityConstants.OCEAN_RANGE[SalinityConstants.RANGE_END])
                return SalinityConstants.OCEAN;
            else
                return "Error";
        }

        //OVERRIDES
        public override DeviceType GetDeviceType()
        {
            return deviceType;
        }

        public override int CheckFlag()
        {
            int start = SalinityConstants.RANGE_START;
            int end = SalinityConstants.RANGE_END;

            int[] flag = new int[1];
            BitArray ba = new BitArray(new int[] { flag[0] });

            //Check Labels
            if (salinityValue > SalinityConstants.FRESH_RANGE[start] && salinityValue < SalinityConstants.FRESH_RANGE[end])
                ba[24] = true;
            else if (salinityValue > SalinityConstants.SLI_SALINE_RANGE[start] && salinityValue < SalinityConstants.SLI_SALINE_RANGE[end])
                ba[25] = true;
            else if (salinityValue > SalinityConstants.MOD_SALINE_RANGE[start] && salinityValue < SalinityConstants.MOD_SALINE_RANGE[end])
                ba[26] = true;
            else if (salinityValue > SalinityConstants.HIGH_SALINE_RANGE[start] && salinityValue < SalinityConstants.HIGH_SALINE_RANGE[end])
                ba[27] = true;
            else if (salinityValue > SalinityConstants.OCEAN_RANGE[start] && salinityValue < SalinityConstants.OCEAN_RANGE[end])
                ba[28] = true;

            //Checks in range
            if (salinityValue < minSalinityAlertValue || salinityValue > maxSalinityAlertValue)
                ba[30] = true;
            else
                ba[29] = true;

            if (ba.Length > 32)
                throw new Exception("Bit Array size cannot fit into 32-bit integer.\n");
            else
                ba.CopyTo(flag, 0);

            return flag[0];
        }

        public override double Update()
        {
            return Stubs.GenerateStubbedValue(salinityValue, 10000);
        }
    }
}
