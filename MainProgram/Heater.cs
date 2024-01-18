using MainProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace MainProgram
{ 
    public static class HeaterConstants
    {
        public static double MIN_USER_SET_TEMP = 30.0;
        public static double MAX_USER_SET_TEMP = 110.0;
    }
    public class Heater : Device
    {

        //ATTRIBUTES
        private double realTimeTemp;
        private double userSetTemp;
        private double minAlertTemp;
        private double maxAlertTemp;

        //CONSTRUCTORS
        public Heater()    //Default Constructor
        {
            realTimeTemp = 90;
            userSetTemp = 90;
            minAlertTemp = 85.0;
            maxAlertTemp = 95.0;
            deviceType = DeviceType.heater;
        }

        //GETTERS
        public double GetRealTimeTemp()
        {
            return realTimeTemp;
        }
        public double GetUserSetTemp()
        {
            return userSetTemp;
        }
        public double GetMinAlertTemp()
        {
            return minAlertTemp;
        }
        public double GetMaxAlertTemp()
        {
            return maxAlertTemp;
        }

        //SETTERS
        public void SetRealTimeTemp(double realTimeTemp)
        {
            this.realTimeTemp = realTimeTemp;
        }
        public void SetUserSetTemp(double userSetTemp)
        {
            this.userSetTemp = userSetTemp;
        }
        public void SetMinAlertTemp(double minAlertTemp)
        {
            this.minAlertTemp = minAlertTemp;
        }
        public void SetMaxAlertTemp(double maxAlertTemp)
        {
            this.maxAlertTemp = maxAlertTemp;
        }

        //OTHER FUNCTIONS
        public int CalculateFlag(double minAlertTemp, double maxAlertTemp, double userSetTemp, double realTimeTemp)
        {

            return 1;
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

            if (realTimeTemp < minAlertTemp || realTimeTemp > maxAlertTemp)
                ba[25] = true;
            else ba[24] = true;

            if (ba.Length > 32)
                throw new Exception("Bit Array size cannot fit into 32-bit integer.\n");
            else
                ba.CopyTo(flag, 0);

            return flag[0];
        }

        public override double Update()
        {
            double sensedValue = Stubs.GenerateStubbedValue(userSetTemp, 5);
            realTimeTemp = sensedValue;
            return sensedValue;
        }

    }
}
