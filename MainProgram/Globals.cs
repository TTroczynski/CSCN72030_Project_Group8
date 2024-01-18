using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public class Globals
    {
        public const int INDICATOR_RUNNING = 1;
        public const int BELOW_THRESHOLD = 2;
    }

    public static class SettingsGlobals
    {
        public const double INCREMENT = 0.5;
        public const double INCREMENT_SMALL = 0.1;
        public const double INCREMENT_VSMALL = 0.01;
        public const double INCREMENT_LARGE = 500;
        public const double ZERO_DOUBLE = 0.000;
        public const int ZERO_INT = 0;

        public static bool systemMode = false;

    }

    public static class TankGuiGlobals
    {
        public const int UPDATE_INTERVAL = 250;
        public const int MESSAGE_INTERVAL = 5000;
        public const int CUSTOM_MESSAGES_START = 16;//0-15 , custom messages start at 17.
        public const int ZERO_INT = 0;
        public const int ONE_INT = 1;
        public const int NEGONE_INT = -1;
        public static bool systemMode = false;
    }

    static public class PumpGlobals
    {
        public const double MAXFLOWRATE = 10.000;
        public const double MINFLOWRATE = 0;
    }

    public static class Guis
    {
        public static bool systemMode = true; //auto or manual 
        public const int ILLEGAL_INDEX = -1;

        public static int currentFault = 16;
        public static int currentDeviceFaults = 0;
        public const int BITS_IN_INTEGER = 32;
        public const string DECIMAL_SPECIFIER = "#.000";

        public static TankGui TankGui = null;
        public static SettingsGui settingsGui = null;
        public static AlarmsGui alarmsGui = null;
    }
}