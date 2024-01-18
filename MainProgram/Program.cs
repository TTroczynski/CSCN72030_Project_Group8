using System.Windows.Forms;

namespace MainProgram
{
    class Program
    {
        public static void Main()
        {
            DeviceManager newDeviceManager = new DeviceManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Guis.TankGui = new TankGui(ref newDeviceManager, ref Guis.systemMode);
            Guis.settingsGui = new SettingsGui(ref newDeviceManager, ref Guis.systemMode);
            Guis.alarmsGui = new AlarmsGui(ref newDeviceManager, ref Guis.systemMode);

            Application.Run(Guis.TankGui);
        }
    }
}

