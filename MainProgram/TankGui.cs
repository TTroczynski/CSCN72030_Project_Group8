using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class TankGui : Form
    {
        int[] deviceFlags = new int[DeviceConstants.DeviceTypeCount];
        DeviceManager devices = null;
        private static double previousTotalErrorInSalinity = 0;
        private static double lastError = 0;

        public TankGui(ref DeviceManager deviceInstance, ref bool systemMode)
        {
            devices = deviceInstance;
            InitializeComponent();
            IntializeDevices();
            if (systemMode)
            {
                AutoMode();
            }
            else
            {
                ManualMode();
            }
        }
        private void GlobalUpdate(object sender, EventArgs e)
        {
            UpdateReadings();
            UpdateStatuses();
        }

        private void AddGlobalUpdateHandler(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            this.timerReadings.Elapsed += new System.Timers.ElapsedEventHandler(this.GlobalUpdate);
            this.timerMessages.Elapsed += new System.Timers.ElapsedEventHandler(this.DisplayMessages);
        }

        private void TankGui_Load(object sender, EventArgs e)
        {
            pnl_FaultBanner.Visible = false;
            pb_SalinityIcon.BackgroundImage = Properties.Resources.Salinity;
            pb_PumpIcon.BackgroundImage = Properties.Resources.pump;
            pb_PhIcon.BackgroundImage = Properties.Resources.Ph;
            pb_NitriteIcon.BackgroundImage = Properties.Resources.Nitrite;
            pb_NitrateIcon.BackgroundImage = Properties.Resources.Nitrate;
            pb_HeaterIcon.BackgroundImage = Properties.Resources.Heater;
            pb_HardnessIcon.BackgroundImage = Properties.Resources.hardness;
            pb_AmmoniaIcon.BackgroundImage = Properties.Resources.Ammonia;
        }

        private void IntializeDevices()
        {
            devices.AddDevice(new Pump(), DeviceType.pump);
            devices.AddDevice(new Heater(), DeviceType.heater);
            devices.AddDevice(new PhBalance(), DeviceType.phSensor);
            devices.AddDevice(new Nitrate(), DeviceType.nitrateSensor);
            devices.AddDevice(new Nitrite(), DeviceType.nitriteSensor);
            devices.AddDevice(new Ammonia(), DeviceType.ammoniaSensor);
            devices.AddDevice(new Salinity(), DeviceType.salinitySensor);
            devices.AddDevice(new Hardness(), DeviceType.hardnessSensor);

        }
        public void UpdateReadings()
        {
            Device foundDevice = null;

            for (int i = 0; i < DeviceConstants.DeviceTypeCount; i++)
            {
                try
                {
                    if(devices.GetDevice((DeviceType)i, ref foundDevice))
                    {
                        switch (foundDevice.GetDeviceType())
                        {
                            case DeviceType.pump:

                                Pump tempPump = (Pump)foundDevice;
                                lbl_Pump_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Pump_Value.Text = tempPump.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                });

                                break;
                            case DeviceType.heater:

                                Heater tempHeater = (Heater)foundDevice;
                                lbl_Heater_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Heater_Value.Text = tempHeater.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                });

                                break;
                            case DeviceType.phSensor:

                                PhBalance tempPh = (PhBalance)foundDevice;
                                lbl_Acidity_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Acidity_Value.Text = tempPh.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                    string temp = lbl_Acidity_Value.Text;
                                    double reading = Convert.ToDouble(temp);
                                    ph_label.Text = PhBalance.CalculatePhLabel(reading);
                                });

                                break;
                            case DeviceType.nitrateSensor:

                                Nitrate tempNitrate = (Nitrate)foundDevice;
                                lbl_Nitrate_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Nitrate_Value.Text = tempNitrate.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                    string temp = lbl_Nitrate_Value.Text;
                                    double reading = Convert.ToDouble(temp);
                                    Nitrate_lbl.Text = tempNitrate.calculateNitrateLabel(reading);
                                });

                                break;
                            case DeviceType.nitriteSensor:

                                Nitrite tempNitrite = (Nitrite)foundDevice;
                                lbl_Nitrite_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Nitrite_Value.Text = tempNitrite.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                    string temp = lbl_Nitrite_Value.Text;
                                    double reading = Convert.ToDouble(temp);
                                    Nitrite_lbl.Text = tempNitrite.calculateNitriteLabel(reading);
                                });

                                break;
                            case DeviceType.ammoniaSensor:

                                Ammonia tempAmmonia = (Ammonia)foundDevice;
                                lbl_Ammonia_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Ammonia_Value.Text = tempAmmonia.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                    string temp = lbl_Ammonia_Value.Text;
                                    double reading = Convert.ToDouble(temp);
                                    Ammonia_lbl.Text = tempAmmonia.calculateAmmoniaLabel(reading);
                                });

                                break;
                            case DeviceType.salinitySensor:

                                Salinity tempSalinity = (Salinity)foundDevice;
                                lbl_Salinity_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Salinity_Value.Text = tempSalinity.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                    string temp = lbl_Salinity_Value.Text;
                                    double reading = Convert.ToDouble(temp);
                                    sal_label.Text = Salinity.CalculateSalinityLabel(reading);
                                });

                                break;
                            case DeviceType.hardnessSensor:

                                Hardness tempHardness = (Hardness)foundDevice;
                                lbl_Hardness_Value.Invoke((MethodInvoker)delegate
                                {
                                    lbl_Hardness_Value.Text = tempHardness.Update().ToString(Guis.DECIMAL_SPECIFIER);
                                });

                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void Lbl_Salinity_Value_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SetMode(object sender, EventArgs e)
        {
            if (Guis.systemMode)
            {
                AutoMode();
            }
            else
            {
                ManualMode();
            }
        }

        private void DisplayMessages(Object sender, EventArgs e)
        {
            string pathToTextFile = AppDomain.CurrentDomain.BaseDirectory + "\\DeviceMessages.txt";
            BitArray deviceBits = new BitArray(new int[] { deviceFlags[Guis.currentDeviceFaults] });

            if (this.Visible)
            {
                for (; Guis.currentFault < Guis.BITS_IN_INTEGER - 1; Guis.currentFault++)
                {
                    if (deviceBits[Guis.currentFault] is true)
                    {
                        break;
                    }
                }

                if (deviceBits[Guis.currentFault] && this.IsHandleCreated)
                {
                    lbl_Alarms.Visible = true;
                    pnl_FaultBanner.Visible = true;
                    lbl_Alarms.Invoke((MethodInvoker)delegate
                    {
                        lbl_Alarms.Text = System.IO.File.ReadLines(pathToTextFile).Skip((Guis.currentDeviceFaults * Guis.BITS_IN_INTEGER) + Guis.currentFault).First(); //reads from line 1 of txt file
                        
                    });
                }

                Guis.currentFault++;

                if (Guis.currentFault >= Guis.BITS_IN_INTEGER -1)
                {
                    Guis.currentFault = TankGuiGlobals.CUSTOM_MESSAGES_START;
                    Guis.currentDeviceFaults++;
                }
                if (Guis.currentDeviceFaults > DeviceConstants.DeviceTypeCount - 1)
                {
                    Guis.currentDeviceFaults = TankGuiGlobals.ZERO_INT;
                }
            }  
        }

        private void StartTimer(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                this.timerMessages.Enabled = true;
            }
            else
            {
                this.timerMessages.Enabled = false;
            }
        }

        public void UpdateStatuses()
        {
            for (int i = 0; i < DeviceConstants.DeviceTypeCount; i++)
            {
                try
                {
                    BitArray deviceBits = new BitArray(new int[] { devices.GetDeviceFaults((DeviceType)i) });

                    for (int j = 0; j < (deviceBits.Length / 2); j++)
                    {
                        bool bitAtJ = deviceBits[j];
                        deviceBits[j] = deviceBits[deviceBits.Length - j - TankGuiGlobals.ONE_INT];
                        deviceBits[deviceBits.Length - j - TankGuiGlobals.ONE_INT] = bitAtJ;
                    }
                    deviceBits.CopyTo(deviceFlags, i);
                    UpdateIndicators();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void UpdateIndicators()
        {
            string temp;
            double reading;
            BitArray deviceBits = null;
            BitArray ba;
            Device foundDevice = null;
            int[] faults = new int[1];
            for (int i = 0; i < DeviceConstants.DeviceTypeCount; i++)
            {
                deviceBits = new BitArray(new int[] { deviceFlags[i] });
                if (devices.GetDevice((DeviceType)i, ref foundDevice))
                {
                    switch (i)
                    {
                        case 0:

                            if (deviceBits[Globals.INDICATOR_RUNNING])
                            {

                                pump_G_border.Visible = false;
                                pump_R_border.Visible = true;
                            }
                            else
                            {
                                pump_G_border.Visible = true;
                                pump_R_border.Visible = false;
                            }
                            break;

                        case 1:
                            faults[0] = devices.GetDeviceFaults(DeviceType.heater);
                            ba = new BitArray(new int[] { faults[0] });

                            Heater tempHtr = (Heater)foundDevice;

                            if (ba[24] == true)
                            {
                                htr_G_border.Visible = true;
                                htr_R_border.Visible = false;
                            }
                            else if (ba[25] == true)
                            {
                                htr_G_border.Visible = false;
                                htr_R_border.Visible = true;
                            }

                            htr_min.Text = "Min: " + tempHtr.GetMinAlertTemp();
                            htr_max.Text = "Max: " + tempHtr.GetMaxAlertTemp();

                            break;

                        case 2:
                            temp = lbl_Acidity_Value.Text;
                            reading = Convert.ToDouble(temp);

                            PhBalance tempPh = (PhBalance)foundDevice;

                            if (reading >= tempPh.GetMinPhAlertValue() && reading <= tempPh.GetMaxPhAlertValue())
                            {                             
                                acid_G_border.Visible = true;
                                acid_R_border.Visible = false;
                            }
                            else
                            {
                                acid_G_border.Visible = false;
                                acid_R_border.Visible = true;
                            }

                            ph_min.Text = "Min: " + (tempPh.GetMinPhAlertValue()).ToString();
                            ph_max.Text = "Max: " + (tempPh.GetMaxPhAlertValue()).ToString();

                            break;

                        case 3:
                            temp = lbl_Nitrate_Value.Text;
                            reading = Convert.ToDouble(temp);
                            Nitrate tempNitra = (Nitrate)foundDevice;

                            if (reading >= tempNitra.getThresholdMin() && reading <= tempNitra.getThresholdMax())
                            {
                                nitrate_G_border.Visible = true;
                                nitrate_R_border.Visible = false;
                            }
                            else
                            {
                                nitrate_G_border.Visible = false;
                                nitrate_R_border.Visible = true;
                            }

                            nitrate_min.Text = "Min: " + (tempNitra.getThresholdMin()).ToString();
                            nitrate_max.Text = "Max: " + (tempNitra.getThresholdMax()).ToString();

                            break;

                        case 4:
                            temp = lbl_Nitrite_Value.Text;
                            reading = Convert.ToDouble(temp);
                            Nitrite tempNitri = (Nitrite)foundDevice;

                            if (reading >= tempNitri.getThresholdMin() && reading <= tempNitri.getThresholdMax())
                            {
                                nitrite_G_border.Visible = true;
                                nitrite_R_border.Visible = false;
                            }
                            else
                            {
                                nitrite_G_border.Visible = false;
                                nitrite_R_border.Visible = true;
                            }

                            nitrite_min.Text = "Min: " + (tempNitri.getThresholdMin()).ToString();
                            nitrite_max.Text = "Max: " + (tempNitri.getThresholdMax()).ToString();

                            break;

                        case 5:
                            temp = lbl_Ammonia_Value.Text;
                            reading = Convert.ToDouble(temp);
                            Ammonia tempAmm = (Ammonia)foundDevice;

                            if (reading >= tempAmm.getThresholdMin() && reading <= tempAmm.getThresholdMax())
                            {
                                amm_G_border.Visible = true;
                                amm_R_border.Visible = false;
                            }
                            else
                            {
                                amm_G_border.Visible = false;
                                amm_R_border.Visible = true;
                            }

                            amm_min.Text = "Min: " + (tempAmm.getThresholdMin()).ToString();
                            amm_max.Text = "Max: " + (tempAmm.getThresholdMax()).ToString();

                            break;
                        case 6:
                            temp = lbl_Salinity_Value.Text;
                            reading = Convert.ToDouble(temp);

                            Salinity tempSal = (Salinity)foundDevice;

                            if (reading >= tempSal.GetMinSalinityAlertValue() && reading <= tempSal.GetMaxSalinityAlertValue())
                            {
                                sal_G_border.Visible = true;
                                sal_R_border.Visible = false;
                            }
                            else
                            {
                                sal_G_border.Visible = false;
                                sal_R_border.Visible = true;
                            }

                            sal_min.Text = "Min: " + (tempSal.GetMinSalinityAlertValue()).ToString();
                            sal_max.Text = "Max: " + (tempSal.GetMaxSalinityAlertValue()).ToString();

                            break;

                        case 7:

                            Hardness tempHrd = (Hardness)foundDevice;

                            if (deviceBits[Globals.INDICATOR_RUNNING])
                            {
                                hrd_G_border.Visible = true;
                                hrd_R_border.Visible = false;
                            }
                            else
                            {
                                hrd_G_border.Visible = false;
                                hrd_R_border.Visible = true;
                            }

                            hrd_max.Text = "Max: " + (tempHrd.GetThreshold()).ToString();

                            break;
                    }
                }
                else
                {

                }
            }
        }
        public void ClearAlarms()
        {
            Array.Clear(deviceFlags, 0, deviceFlags.Length);
        }

        private void CalcSalinityPidResponse(Object sender, EventArgs e)
        {
            const double gainK = 0.3;
            const double integralTime = 0.00025;
            const double derivativeTime = 0.00025;
            //const double DIVIDEBY = 100;

            if (!Guis.systemMode)
                return;

            //M = Kc *e + Ki* SUM(e) + Kr * (en - en-1) + M
            //M is control output at the momentof n
            //en is the error at the moment of time n
            //Kc*en is the proportional term P, Kc is the proportional gain coefficient - stays fixed when set properly
            //Ki*SUM(n) is the integral term I, this is the sum of the calculated errors from the first sample ( i = 1) to the current moment
            //Kr*(en-en-1) is the derivative term. it is the error now minus the previous sample error

            Device foundSalinity = null;
            Device foundPump = null;

            if(devices.GetDevice(DeviceType.salinitySensor, ref foundSalinity) && devices.GetDevice(DeviceType.pump, ref foundPump))
            {
                Salinity sensor = (Salinity)foundSalinity;
                Pump pump = (Pump)foundPump;

                if (Guis.systemMode)
                {
                    double errorNow = sensor.Update() - sensor.GetSalinityValue();
                    double response = (gainK * errorNow) + (integralTime * previousTotalErrorInSalinity) + (derivativeTime * (errorNow - lastError));
                    lastError = errorNow - lastError;
                    previousTotalErrorInSalinity = errorNow + previousTotalErrorInSalinity;

                    if(response < TankGuiGlobals.ZERO_INT)
                    {
                        response = TankGuiGlobals.ZERO_INT;
                    }

                    pump.SetFlowRate(TankGuiGlobals.ONE_INT/ response);
                }
            }
            
        }
        public void AutoMode()
        {
            btn_Auto.BackColor = Color.SpringGreen;
            btn_Manual.BackColor = Color.White;
        }

        public void ManualMode()
        {
            btn_Auto.BackColor = Color.White;
            btn_Manual.BackColor = Color.Yellow;
        }
        private void btn_AutoMode_Click(object sender, EventArgs e)
        {
            Guis.systemMode = true;
            AutoMode();
        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {
            Guis.systemMode = false;
            ManualMode();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guis.settingsGui.Show();

        }

        private void btn_Alarms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guis.alarmsGui.Show();
        }
    }
}