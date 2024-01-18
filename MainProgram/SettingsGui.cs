using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class SettingsGui : Form
    {
        int[] deviceFlags = new int[8];
        DeviceManager devices = null;

        public SettingsGui(ref DeviceManager devicesInstance, ref bool systemMode)
        {
            InitializeComponent();

            devices = devicesInstance;
            lb_Devices.Items.Clear();

            UpdateDeviceList();

            btn_DecreaseLower.Enabled = false;
            btn_IncreaseLower.Enabled = false;
            lbl_LowerThreshold.Enabled = false;
            lbl_Lower.Enabled = false;
            lbl_UpperThreshold.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            lbl_LowerThreshold.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            lbl_OperatingValue.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            lb_Devices.SelectedIndex = SettingsGlobals.ZERO_INT;
            pb_IconImage.BackgroundImage = Properties.Resources.pump;
            pb_IconImage.SizeMode = PictureBoxSizeMode.Normal;
            pnl_ConnectMessageResult.Visible = false;
            pnl_DisconnectMessageResult.Visible = false;

            if (systemMode)
            {
                AutoMode();
            }
            else
            {
                ManualMode();
            }
        }

        private void AddGlobalUpdateHandler(object sender, EventArgs e)
        {
            this.timerMessages.Elapsed += new System.Timers.ElapsedEventHandler(this.DisplayMessages);
            this.timerStatuses.Elapsed += new System.Timers.ElapsedEventHandler(this.GlobalUpdate);
        }

        private void ResetDeviceAddRemoveLabel(object sender, EventArgs e)
        {
            pnl_DisconnectMessageResult.Visible = false;
            pnl_ConnectMessageResult.Visible = false;
            this.timer_AddRemoveMessages.Enabled = false;
        }

        private void UpdateDeviceList()
        {
            lb_Devices.Items.Clear();

            for (int i = 0; i < DeviceConstants.DeviceTypeCount; i++)
            {
                try
                {
                    Device currentDevice = null;

                    if (devices.GetDevice((DeviceType)i, ref currentDevice))
                    {
                        if(currentDevice != null)
                        {
                            if (currentDevice.GetDeviceType() == DeviceType.pump)
                                lb_Devices.Items.Add("Pump");
                            else if (currentDevice.GetDeviceType() == DeviceType.heater)
                                lb_Devices.Items.Add("Heater");
                            else if (currentDevice.GetDeviceType() == DeviceType.phSensor)
                                lb_Devices.Items.Add("Ph Sensor");
                            else if (currentDevice.GetDeviceType() == DeviceType.nitrateSensor)
                                lb_Devices.Items.Add("Nitrate Sensor");
                            else if (currentDevice.GetDeviceType() == DeviceType.nitriteSensor)
                                lb_Devices.Items.Add("Nitrite Sensor");
                            else if (currentDevice.GetDeviceType() == DeviceType.ammoniaSensor)
                                lb_Devices.Items.Add("Ammonia Sensor");
                            else if (currentDevice.GetDeviceType() == DeviceType.salinitySensor)
                                lb_Devices.Items.Add("Salinity Sensor");
                            else if (currentDevice.GetDeviceType() == DeviceType.hardnessSensor)
                                lb_Devices.Items.Add("Hardness Sensor");
                            else
                                lb_Devices.Items.Add(string.Empty);
                        }
                        
                    }
                    else
                    {
                        lb_Devices.Items.Add(string.Empty);
                    }
                }
                catch (Exception e)
                {
                    lb_Devices.Items.Add(string.Empty);
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void GlobalUpdate(object sender, EventArgs e)
        {
            UpdateStatuses();
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void ChangedSelection(object sender, EventArgs e)
        {
            btn_DecreaseLower.Enabled = false;
            btn_IncreaseLower.Enabled = false;
            btn_DecreaseOperating.Enabled = false;
            btn_IncreaseOperating.Enabled = false;
            btn_DecreaseUpper.Enabled = false;
            btn_IncreaseUpper.Enabled = false;
            lbl_OperatingValue.Enabled = false;
            lbl_LowerThreshold.Enabled = false;
            lbl_UpperThreshold.Enabled = false;
            lbl_Lower.Enabled = false;
            lbl_Operating.Enabled = false;
            lbl_Upper.Enabled = false;
            lbl_UpperThreshold.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            lbl_LowerThreshold.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            lbl_OperatingValue.Text = SettingsGlobals.ZERO_DOUBLE.ToString();
            Device foundDevice = null;
            switch (lb_Devices.SelectedIndex)
            {
                case (int)DeviceType.pump:

                    pb_IconImage.BackgroundImage = Properties.Resources.pump;

                    if (devices.GetDevice(DeviceType.pump, ref foundDevice) && !Guis.systemMode)
                    {
                        
                        Pump foundPump = (Pump)foundDevice;
                        lbl_OperatingValue.Text = foundPump.GetFlowRate().ToString(Guis.DECIMAL_SPECIFIER);
                        lbl_OperatingValue.Enabled = true;
                        btn_DecreaseOperating.Enabled = true;
                        btn_IncreaseOperating.Enabled = true;
                        lbl_Operating.Enabled = true;
                    }
                    
                    break;
                case (int)DeviceType.heater:

                    if(devices.GetDevice(DeviceType.heater, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Heater;
                        Heater foundHeater = (Heater)foundDevice;
                        lbl_UpperThreshold.Text = foundHeater.GetMaxAlertTemp().ToString();
                        lbl_LowerThreshold.Text = foundHeater.GetMinAlertTemp().ToString();
                        lbl_OperatingValue.Text = foundHeater.GetUserSetTemp().ToString();
                        lbl_OperatingValue.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        btn_DecreaseOperating.Enabled = true;
                        btn_IncreaseOperating.Enabled = true;
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        lbl_Operating.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.phSensor:

                    if (devices.GetDevice(DeviceType.phSensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Ph;
                        PhBalance foundPhSensor = (PhBalance)foundDevice;
                        lbl_UpperThreshold.Text = foundPhSensor.GetMaxPhAlertValue().ToString();
                        lbl_LowerThreshold.Text = foundPhSensor.GetMinPhAlertValue().ToString();
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.nitrateSensor:

                    if (devices.GetDevice(DeviceType.nitrateSensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Nitrate;
                        Nitrate foundNitrate = (Nitrate)foundDevice;
                        lbl_LowerThreshold.Text = foundNitrate.getThresholdMin().ToString();
                        lbl_UpperThreshold.Text = foundNitrate.getThresholdMax().ToString();
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.nitriteSensor:

                    if (devices.GetDevice(DeviceType.nitriteSensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Nitrite;
                        Nitrite foundNitriteSensor = (Nitrite)foundDevice;
                        lbl_LowerThreshold.Text = foundNitriteSensor.getThresholdMin().ToString();
                        lbl_UpperThreshold.Text = foundNitriteSensor.getThresholdMax().ToString();
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.ammoniaSensor:

                    if (devices.GetDevice(DeviceType.ammoniaSensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Ammonia;
                        Ammonia foundAmmoniaSensor = (Ammonia)foundDevice;
                        lbl_LowerThreshold.Text = foundAmmoniaSensor.getThresholdMin().ToString();
                        lbl_UpperThreshold.Text = foundAmmoniaSensor.getThresholdMax().ToString();
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.salinitySensor:

                    if (devices.GetDevice(DeviceType.salinitySensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.Salinity;
                        Salinity foundSalinitySensor = (Salinity)foundDevice;
                        lbl_UpperThreshold.Text = foundSalinitySensor.GetMaxSalinityAlertValue().ToString();
                        lbl_LowerThreshold.Text = foundSalinitySensor.GetMinSalinityAlertValue().ToString();
                        btn_DecreaseLower.Enabled = true;
                        btn_IncreaseLower.Enabled = true;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_LowerThreshold.Enabled = true;
                        lbl_Lower.Enabled = true;
                        lbl_Upper.Enabled = true;
                    }
                    break;
                case (int)DeviceType.hardnessSensor:

                    if (devices.GetDevice(DeviceType.hardnessSensor, ref foundDevice))
                    {
                        pb_IconImage.BackgroundImage = Properties.Resources.hardness;
                        Hardness foundHardnessSensor = (Hardness)foundDevice;
                        btn_DecreaseUpper.Enabled = true;
                        btn_IncreaseUpper.Enabled = true;
                        lbl_UpperThreshold.Enabled = true;
                        lbl_Upper.Enabled = true;
                        lbl_UpperThreshold.Text = foundHardnessSensor.GetThreshold().ToString();
                    }
                    break;
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
            if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
            {
                lbl_OperatingValue.Enabled = false;
                btn_DecreaseOperating.Enabled = false;
                btn_IncreaseOperating.Enabled = false;
                lbl_Operating.Enabled = false;
            }
            AutoMode();
        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {
            Guis.systemMode = false;
            if(lb_Devices.SelectedIndex == (int)DeviceType.pump)
            {
                lbl_OperatingValue.Enabled = true;
                btn_DecreaseOperating.Enabled = true;
                btn_IncreaseOperating.Enabled = true;
                lbl_Operating.Enabled = true;
            }
            
            ManualMode();
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
            if (this.Visible)
            {
                this.timerMessages.Enabled = true;
            }
            else
            {
                this.timerMessages.Enabled = false;
            }
        }

        private void SettingsGui_Load(object sender, EventArgs e)
        {
            pnl_FaultBanner.Visible = false;

            if(Guis.systemMode)
            {
                lbl_OperatingValue.Enabled = false;
                btn_DecreaseOperating.Enabled = false;
                btn_IncreaseOperating.Enabled = false;
                lbl_Operating.Enabled = false;
            }
        }

        private void OnClosing(object sender, EventArgs e)
        {
            Guis.TankGui.Close();
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

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guis.TankGui.Show();

        }
        private void btn_IncreaseUpper_Click(object sender, EventArgs e)
        {
            double thresholdValue = 0;
            if (double.TryParse(lbl_UpperThreshold.Text, out thresholdValue))
            {
                if(lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    thresholdValue += SettingsGlobals.INCREMENT;
                    if (thresholdValue > HeaterConstants.MAX_USER_SET_TEMP)
                    {
                        thresholdValue = HeaterConstants.MAX_USER_SET_TEMP;
                    }
                }
                else if(lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {

                    thresholdValue += SettingsGlobals.INCREMENT_LARGE;
                    if (thresholdValue > SalinityConstants.OCEAN_RANGE[0])
                    {
                        thresholdValue = SalinityConstants.OCEAN_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    thresholdValue += SettingsGlobals.INCREMENT;
                    if (thresholdValue > PhConstants.HIGH_PH)
                    {
                        thresholdValue = PhConstants.HIGH_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    Device temp = null;
                    devices.GetDevice(DeviceType.hardnessSensor, ref temp);
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue > HardnessConstants.MAXHARDNESS)
                    {
                        thresholdValue = HardnessConstants.MAXHARDNESS;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue > PumpGlobals.MAXFLOWRATE)
                    {
                        thresholdValue = PumpGlobals.MAXFLOWRATE;
                    }
                }
                else
                {
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                }


                lbl_UpperThreshold.Text = thresholdValue.ToString();
            }
            Console.WriteLine(thresholdValue);
        }

        public void btn_DecreaseUpper_Click(object sender, EventArgs e)
        {
            double thresholdValue = 0;
            if (double.TryParse(lbl_UpperThreshold.Text, out thresholdValue))
            {

                if (lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT;
                    if(thresholdValue < HeaterConstants.MIN_USER_SET_TEMP)
                    {
                        thresholdValue = HeaterConstants.MIN_USER_SET_TEMP;
                    }

                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_LARGE;
                    if(thresholdValue < SalinityConstants.FRESH_RANGE[0])
                    {
                        thresholdValue = SalinityConstants.FRESH_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT;
                    if(thresholdValue < PhConstants.LOW_PH)
                    {
                        thresholdValue = PhConstants.LOW_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue < PumpGlobals.MINFLOWRATE)
                    {
                        thresholdValue = PumpGlobals.MINFLOWRATE;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue < HardnessConstants.MINHARDNESS)
                    {
                        thresholdValue = HardnessConstants.MINHARDNESS;
                    }
                }
                else
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                }
                lbl_UpperThreshold.Text = thresholdValue.ToString();
            }
        }
        

        private void btn_IncreaseLower_Click(object sender, EventArgs e)
        {
            double thresholdValue = 0;

            if (double.TryParse(lbl_LowerThreshold.Text, out thresholdValue))
            {
                if (lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    thresholdValue += SettingsGlobals.INCREMENT;
                    if (thresholdValue > HeaterConstants.MAX_USER_SET_TEMP)
                    {
                        thresholdValue = HeaterConstants.MAX_USER_SET_TEMP;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {

                    thresholdValue += SettingsGlobals.INCREMENT_LARGE;
                    if (thresholdValue > SalinityConstants.OCEAN_RANGE[0])
                    {
                        thresholdValue = SalinityConstants.OCEAN_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    thresholdValue += SettingsGlobals.INCREMENT;
                    if (thresholdValue > PhConstants.HIGH_PH)
                    {
                        thresholdValue = PhConstants.HIGH_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    Device temp = null;
                    devices.GetDevice(DeviceType.hardnessSensor, ref temp);
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue > HardnessConstants.MAXHARDNESS)
                    {
                        thresholdValue = HardnessConstants.MAXHARDNESS;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue > PumpGlobals.MAXFLOWRATE)
                    {
                        thresholdValue = PumpGlobals.MAXFLOWRATE;
                    }
                }
                else
                {
                    thresholdValue += SettingsGlobals.INCREMENT_SMALL;
                }
                lbl_LowerThreshold.Text = thresholdValue.ToString();
            }
        }

        private void btn_DecreaseLower_Click(object sender, EventArgs e)
        {
            double thresholdValue = 0;
            if (double.TryParse(lbl_LowerThreshold.Text, out thresholdValue))
            {
                if (lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT;
                    if (thresholdValue < HeaterConstants.MIN_USER_SET_TEMP)
                    {
                        thresholdValue = HeaterConstants.MIN_USER_SET_TEMP;
                    }

                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_LARGE;
                    if (thresholdValue < SalinityConstants.FRESH_RANGE[0])
                    {
                        thresholdValue = SalinityConstants.FRESH_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT;
                    if (thresholdValue < PhConstants.LOW_PH)
                    {
                        thresholdValue = PhConstants.LOW_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue < PumpGlobals.MINFLOWRATE)
                    {
                        thresholdValue = PumpGlobals.MINFLOWRATE;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (thresholdValue < HardnessConstants.MINHARDNESS)
                    {
                        thresholdValue = HardnessConstants.MINHARDNESS;
                    }
                }
                else
                {
                    thresholdValue -= SettingsGlobals.INCREMENT_SMALL;
                }
                lbl_LowerThreshold.Text = thresholdValue.ToString();
            }
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            double tempValueHigh = 0;
            double tempOperatingValue = 0;
            double tempValueLow = 0;
            try
            {
                Device foundDevice = null;
                if (devices.GetDevice((DeviceType)lb_Devices.SelectedIndex, ref foundDevice)){
                    switch (foundDevice.GetDeviceType())
                    {
                        case DeviceType.pump:
                            Pump tempPump = (Pump)foundDevice;
                            if (double.TryParse(lbl_OperatingValue.Text, out tempOperatingValue))
                                tempPump.SetFlowRate(tempOperatingValue);
                            break;
                        case DeviceType.heater:
                            Heater tempHeater = (Heater)foundDevice;
                            if (double.TryParse(lbl_OperatingValue.Text, out tempOperatingValue))
                                tempHeater.SetUserSetTemp(tempOperatingValue);
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempHeater.SetMaxAlertTemp(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempHeater.SetMinAlertTemp(tempValueLow);
                            break;
                        case DeviceType.phSensor:
                            PhBalance tempPhBalance = (PhBalance)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempPhBalance.SetMaxPhAlertValue(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempPhBalance.SetMinPhAlertValue(tempValueLow);
                            break;
                        case DeviceType.nitrateSensor:
                            Nitrate tempNitrate = (Nitrate)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempNitrate.setThresholdMax(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempNitrate.setThresholdMin(tempValueLow);
                            break;
                        case DeviceType.nitriteSensor:
                            Nitrite tempNitrite = (Nitrite)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempNitrite.setThresholdMax(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempNitrite.setThresholdMin(tempValueLow);
                            break;
                        case DeviceType.ammoniaSensor:
                            Ammonia tempAmmonia = (Ammonia)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempAmmonia.setThresholdMax(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempAmmonia.setThresholdMin(tempValueLow);
                            break;
                        case DeviceType.salinitySensor:
                            Salinity tempSalinity = (Salinity)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempSalinity.SetMaxSalinityAlertValue(tempValueHigh);
                            if (double.TryParse(lbl_LowerThreshold.Text, out tempValueLow))
                                tempSalinity.SetMinSalinityAlertValue(tempValueLow);
                            break;
                        case DeviceType.hardnessSensor:
                            Hardness tempHardness = (Hardness)foundDevice;
                            if (double.TryParse(lbl_UpperThreshold.Text, out tempValueHigh))
                                tempHardness.SetThreshold(tempValueHigh);
                            break;
                        default:

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if(devices.RemoveDevice((DeviceType)lb_Devices.SelectedIndex))
            {
                pnl_DisconnectMessageResult.BackColor = Color.LightSeaGreen;
                lbl_DisconnectMessage.Text = "Device disconnected";
            }
            else
            {
                pnl_DisconnectMessageResult.BackColor = Color.OrangeRed;
                lbl_DisconnectMessage.Text = "Failed to disconnect device";
            }
            pnl_DisconnectMessageResult.Visible = true;
            this.timer_AddRemoveMessages.Enabled = true;
            UpdateDeviceList();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Device toAdd = null;
            DeviceType typeToAdd = TankGuiGlobals.ZERO_INT;

            switch(cb_ToAdd.SelectedIndex)
            {
                case 0:
                    toAdd = new Pump();
                    typeToAdd = DeviceType.pump;
                    break;
                case 1:
                    toAdd = new Heater();
                    typeToAdd = DeviceType.heater;
                    break;
                case 2:
                    toAdd = new PhBalance();
                    typeToAdd = DeviceType.phSensor;
                    break;
                case 3:
                    toAdd = new Nitrate();
                    typeToAdd = DeviceType.nitrateSensor;
                    break;
                case 4:
                    toAdd = new Nitrite();
                    typeToAdd = DeviceType.nitriteSensor;
                    break;
                case 5:
                    toAdd = new Ammonia();
                    typeToAdd = DeviceType.ammoniaSensor;
                    break;
                case 6:
                    toAdd = new Salinity();
                    typeToAdd = DeviceType.salinitySensor;
                    break;
                case 7:
                    toAdd = new Hardness();
                    typeToAdd = DeviceType.hardnessSensor;
                    break;
            }
            if(toAdd != null)
            {
                if (devices.AddDevice(toAdd, typeToAdd))
                {
                    pnl_ConnectMessageResult.BackColor = Color.LightSeaGreen;
                    lbl_ConnectMessage.Text = "Device connected";
                }
                else
                {
                    pnl_ConnectMessageResult.BackColor = Color.OrangeRed;
                    lbl_ConnectMessage.Text = "Failed to connect device";
                }
                pnl_ConnectMessageResult.Visible = true;
                this.timer_AddRemoveMessages.Enabled = true;
            }
            UpdateDeviceList();
        }

        private void btn_IncreaseOperating_Click(object sender, EventArgs e)
        {
            //lbl_OperatingValue
            double operatingValue = 0;

            if (double.TryParse(lbl_OperatingValue.Text, out operatingValue))
            {
                if (lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    operatingValue += SettingsGlobals.INCREMENT;
                    if (operatingValue > HeaterConstants.MAX_USER_SET_TEMP)
                    {
                        operatingValue = HeaterConstants.MAX_USER_SET_TEMP;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {

                    operatingValue += SettingsGlobals.INCREMENT_LARGE;
                    if (operatingValue > SalinityConstants.OCEAN_RANGE[0])
                    {
                        operatingValue = SalinityConstants.OCEAN_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    operatingValue += SettingsGlobals.INCREMENT;
                    if (operatingValue > PhConstants.HIGH_PH)
                    {
                        operatingValue = PhConstants.HIGH_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    Device temp = null;
                    devices.GetDevice(DeviceType.hardnessSensor, ref temp);
                    operatingValue += SettingsGlobals.INCREMENT_SMALL;
                    if (operatingValue > HardnessConstants.MAXHARDNESS)
                    {
                        operatingValue = HardnessConstants.MAXHARDNESS;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    operatingValue += SettingsGlobals.INCREMENT_SMALL;
                    if (operatingValue > PumpGlobals.MAXFLOWRATE)
                    {
                        operatingValue = PumpGlobals.MAXFLOWRATE;
                    }
                }
                else
                {
                    operatingValue += SettingsGlobals.INCREMENT_SMALL;
                }
                lbl_OperatingValue.Text = operatingValue.ToString();
            }
        }

        private void btn_DecreaseOperating_Click(object sender, EventArgs e)
        {
            //lbl_OperatingValue
            double operatingValue = 0;
            if (double.TryParse(lbl_OperatingValue.Text, out operatingValue))
            {
                if (lb_Devices.SelectedIndex == (int)DeviceType.heater)
                {
                    operatingValue -= SettingsGlobals.INCREMENT;
                    if (operatingValue < HeaterConstants.MIN_USER_SET_TEMP)
                    {
                        operatingValue = HeaterConstants.MIN_USER_SET_TEMP;
                    }

                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.salinitySensor)
                {
                    operatingValue -= SettingsGlobals.INCREMENT_LARGE;
                    if (operatingValue < SalinityConstants.FRESH_RANGE[0])
                    {
                        operatingValue = SalinityConstants.FRESH_RANGE[0];
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.phSensor)
                {
                    operatingValue -= SettingsGlobals.INCREMENT;
                    if (operatingValue < PhConstants.LOW_PH)
                    {
                        operatingValue = PhConstants.LOW_PH;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.pump)
                {
                    operatingValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (operatingValue < PumpGlobals.MINFLOWRATE)
                    {
                        operatingValue = PumpGlobals.MINFLOWRATE;
                    }
                }
                else if (lb_Devices.SelectedIndex == (int)DeviceType.hardnessSensor)
                {
                    operatingValue -= SettingsGlobals.INCREMENT_SMALL;
                    if (operatingValue < HardnessConstants.MINHARDNESS)
                    {
                        operatingValue = HardnessConstants.MINHARDNESS;
                    }
                }
                else
                {
                    operatingValue -= SettingsGlobals.INCREMENT_SMALL;
                }
                lbl_OperatingValue.Text = operatingValue.ToString();
            }
        }

        private void btn_Alarms_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Guis.alarmsGui.Show();
        }
    }
}
