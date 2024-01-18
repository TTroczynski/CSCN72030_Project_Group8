using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class AlarmsGui : Form
    {
        int[] deviceFlags = new int[8];
        DeviceManager devices = null;

        public AlarmsGui(ref DeviceManager devicesInstance, ref bool systemMode)
        {
            devices = devicesInstance;
            InitializeComponent();
            pnl_FaultBanner.Visible = false;

            if (systemMode)
            {
                AutoMode();
            }
            else
            {
                ManualMode();
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

        private void UpdateListBox()
        {
            string pathToTextFile = AppDomain.CurrentDomain.BaseDirectory + "\\DeviceMessages.txt";
            int active = 0;
            BitArray deviceBits = new BitArray(new int[] { deviceFlags[Guis.currentDeviceFaults] });
            foreach (var bit in deviceBits)
            {
                if (bit is true && this.IsHandleCreated && !listBox1.Items.Contains(System.IO.File.ReadLines(pathToTextFile).Skip((Guis.currentDeviceFaults * (Guis.BITS_IN_INTEGER - 1)) + active).First()))
                {
                        lbl_Alarms.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(System.IO.File.ReadLines(pathToTextFile).Skip((Guis.currentDeviceFaults * (Guis.BITS_IN_INTEGER - 1)) + active).First());

                        });
                }
                active++;
                if(active == Guis.BITS_IN_INTEGER - 1)
                {
                    active = 0;
                }
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

                if (Guis.currentFault >= Guis.BITS_IN_INTEGER - 1)
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
                this.timer_DispayMessages.Enabled = true;
            }
            else
            {
                this.timer_DispayMessages.Enabled = false;
            }
        }
        private void OnClosing(object sender, EventArgs e)
        {
            Guis.TankGui.Close();
            Guis.settingsGui.Close();
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
        private void btn_Overview_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guis.TankGui.Show();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null && listBox1.Items.Count > TankGuiGlobals.ZERO_INT)
            {
                listBox1.SetSelected(TankGuiGlobals.ZERO_INT, true);
            }
            else if((listBox1.SelectedItem != null) && listBox1.Items.Count > TankGuiGlobals.ZERO_INT && listBox1.SelectedIndex != listBox1.Items.Count)
            {
                listBox1.SetSelected(listBox1.SelectedIndex + TankGuiGlobals.ONE_INT, true);
            }
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null && listBox1.Items.Count > TankGuiGlobals.ZERO_INT)
            {
                listBox1.SetSelected(TankGuiGlobals.ZERO_INT, true);
            }
            else if ((listBox1.SelectedItem != null) && listBox1.Items.Count > TankGuiGlobals.ZERO_INT && (listBox1.SelectedIndex != TankGuiGlobals.ZERO_INT))
            {
                listBox1.SetSelected(listBox1.SelectedIndex - TankGuiGlobals.ONE_INT, true);
            }

        }

        private void btn_Acknowledge_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void timerStatuses_Tick(object sender, EventArgs e)
        {
            UpdateStatuses();
        }

        private void timerListBox_Tick(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void AlarmsGui_Load(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > TankGuiGlobals.ZERO_INT)
            {
                listBox1.SetSelected(TankGuiGlobals.ZERO_INT, true);
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guis.settingsGui.Show();
        }

        private void btn_Overview_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Guis.TankGui.Show();
        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {
            Guis.systemMode = false;
            ManualMode();
        }

        private void btn_Auto_Click(object sender, EventArgs e)
        {
            Guis.systemMode = true;
            AutoMode();
        }
    }
}
