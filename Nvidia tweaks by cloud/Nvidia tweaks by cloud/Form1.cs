using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nvidia_tweaks_by_cloud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            //
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string specificFolder = Path.Combine(folder, "nvd");
            Directory.CreateDirectory(specificFolder);
            //
            if (Settings.GetValue("hdcp") != null)
            {
                hdcp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                hdcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                hdcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("aspm") != null)
            {
                aspm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                aspm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                aspm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("Preemption") != null)
            {
                Preemption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                Preemption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                Preemption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("hsync") != null)
            {
                hsync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                hsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                hsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("uvm") != null)
            {
                uvm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                uvm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                uvm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("displayps") != null)
            {
                displayps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                displayps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                displayps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("tiled") != null)
            {
                tiled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                tiled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                tiled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("memoryt") != null)
            {
                memoryt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                memoryt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                memoryt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("async") != null)
            {
                async.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                async.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                async.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("pstweaks") != null)
            {
                pstweaks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                pstweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                pstweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
              //
            if (Settings.GetValue("gputimer") != null)
            {
                gputimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                gputimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                gputimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
           //
            if (Settings.GetValue("writecombining") != null)
            {
                writecombining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                writecombining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                writecombining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("VsyncIdleTimeout") != null)
            {
                VsyncIdleTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                VsyncIdleTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                VsyncIdleTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
            //
            if (Settings.GetValue("kboost") != null)
            {
                kboost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                kboost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
            }
            else
            {
                kboost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
            }
        }

        RegistryKey Settings = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\tweaks", true);

        private void Basic_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void hdcp_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("hdcp") != null)
            {
                Settings.DeleteValue("hdcp", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                    key.DeleteValue("RMHdcpKeyglobZero");
                    key.Close();
                }
                catch { }


                hdcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                hdcp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("hdcp", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                key.SetValue("RMHdcpKeyglobZero", 1);
                key.Close();

                hdcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                hdcp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void aspm_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("aspm") != null)
            {
                Settings.DeleteValue("aspm", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                    key.DeleteValue("RMDisableGpuASPMFlags");
                    key.DeleteValue("RMEnableASPMAtLoad");
                    key.DeleteValue("RMEnableASPMDT");
                    key.DeleteValue("RmOverrideSupportChipsetAspm");
                    key.DeleteValue("RMSbiosEnableASPMDT");
                    key.DeleteValue("RMEnableASPMDT");
                    key.Close();
                }
                catch { }


                aspm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                aspm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("aspm", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                key.SetValue("RMDisableGpuASPMFlags", 1);
                key.SetValue("RMEnableASPMAtLoad", 0);
                key.SetValue("RMEnableASPMDT", 0);
                key.SetValue("RmOverrideSupportChipsetAspm", 0);
                key.SetValue("RMSbiosEnableASPMDT", 0);
                key.SetValue("RMEnableASPMDT", 0);
                key.Close();

                aspm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                aspm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void Preemption_Click(object sender, EventArgs e)
        {
                if (Settings.GetValue("Preemption") != null)
                {
                    Settings.DeleteValue("Preemption", false);
                    try
                    {
                        Microsoft.Win32.RegistryKey key;
                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler");
                        key.DeleteValue("EnablePreemption");
                        key.Close();

                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                        key.DeleteValue("ComputePreemption");
                        key.Close();

                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                        key.DeleteValue("ComputePreemption");
                        key.DeleteValue("DisablePreemptionOnS3S4");
                        key.DeleteValue("EnableCEPreemption");
                        key.DeleteValue("DisableCudaContextPreemption");
                        key.DeleteValue("DisablePreemption");
                        key.Close();
                    }
                    catch { }


                    Preemption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                    Preemption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
                }
                else
                {
                    Settings.SetValue("Preemption", "1", RegistryValueKind.DWord);

                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler");
                    key.SetValue("EnablePreemption", 0);
                    key.Close();

                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.SetValue("ComputePreemption", 0);
                    key.Close();

                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.SetValue("ComputePreemption", 0);
                    key.SetValue("DisablePreemptionOnS3S4", 1);
                    key.SetValue("EnableCEPreemption", 0);
                    key.SetValue("DisableCudaContextPreemption", 1);
                    key.SetValue("DisablePreemption", 1);
                    key.SetValue("DisableCudaContextPreemption", 1);
                    key.SetValue("EnableAsyncMidBufferPreemption", 0);
                    key.SetValue("EnableMidGfxPreemption", 0);
                    key.Close();

                    Preemption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                    Preemption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
        }

        private void hsync_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("hsync") != null)
            {
                Settings.DeleteValue("hsync", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("PowerSaverHsyncOn");
                    key.Close();
                }
                catch { }


                hsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                hsync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("hsync", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("PowerSaverHsyncOn", 0);
                key.Close();

                hsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                hsync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void uvm_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("uvm") != null)
            {
                Settings.DeleteValue("uvm", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("UvmDisable");
                    key.Close();
                }
                catch { }

                uvm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                uvm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("uvm", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("UvmDisable", 1);
                key.Close();

                uvm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                uvm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void displayps_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("displayps") != null)
            {
                Settings.DeleteValue("displayps", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\nvlddmkm\Global\NVTweak");
                    key.DeleteValue("DisplayPowerSaving");
                    key.Close();
                }
                catch { }

                displayps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                displayps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("displayps", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\nvlddmkm\Global\NVTweak");
                key.SetValue("DisplayPowerSaving", 0);
                key.Close();

                displayps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                displayps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void tiled_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("tiled") != null)
            {
                Settings.DeleteValue("tiled", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("EnableTiledDisplay");
                    key.Close();
                }
                catch { }

                tiled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                tiled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("tiled", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("EnableTiledDisplay", 0);
                key.Close();

                tiled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                tiled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void memoryt_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("memoryt") != null)
            {
                Settings.DeleteValue("memoryt", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("EnableMemoryTiling");
                    key.Close();
                }
                catch { }

                memoryt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                memoryt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("memoryt", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("EnableMemoryTiling", 0);
                key.Close();

                memoryt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                memoryt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void async_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("async") != null)
            {
                Settings.DeleteValue("async", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("RMDisableAsyncMemScrub");
                    key.Close();
                }
                catch { }

                async.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                async.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("async", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("RMDisableAsyncMemScrub", 1);
                key.Close();

                async.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                async.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void pstweaks_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("pstweaks") != null)
            {
                Settings.DeleteValue("pstweaks", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                    key.DeleteValue("PowerSavingTweaks");
                    key.Close();
                }
                catch { }

                pstweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                pstweaks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("pstweaks", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                key.SetValue("PowerSavingTweaks", 0);
                key.Close();

                pstweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                pstweaks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void gputimer_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("gputimer") != null)
            {
                Settings.DeleteValue("gputimer", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                    key.DeleteValue("UseGpuTimer");
                    key.Close();
                }
                catch { }

                gputimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                gputimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("gputimer", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                key.SetValue("UseGpuTimer", 1);
                key.Close();

                gputimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                gputimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void writecombining_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("writecombining") != null)
            {
                Settings.DeleteValue("writecombining", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                    key.DeleteValue("DisableWriteCombining");
                    key.Close();
                }
                catch { }

                writecombining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                writecombining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("writecombining", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm");
                key.SetValue("DisableWriteCombining", 1);
                key.Close();

                writecombining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                writecombining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void VsyncIdleTimeout_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("VsyncIdleTimeout") != null)
            {
                Settings.DeleteValue("VsyncIdleTimeout", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler");
                    key.DeleteValue("VsyncIdleTimeout");
                    key.Close();
                }
                catch { }

                VsyncIdleTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                VsyncIdleTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("VsyncIdleTimeout", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler");
                key.SetValue("VsyncIdleTimeout", 0);
                key.Close();

                VsyncIdleTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                VsyncIdleTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void kboost_Click(object sender, EventArgs e)
        {
            if (Settings.GetValue("kboost") != null)
            {
                Settings.DeleteValue("kboost", false);
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                    key.DeleteValue("PowerMizerEnable");
                    key.DeleteValue("PerfLevelSrc");
                    key.DeleteValue("PowerMizerLevel");
                    key.DeleteValue("PowerMizerLevelAC");
                    key.Close();
                }
                catch { }

                VsyncIdleTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(10)))));
                VsyncIdleTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            }
            else
            {
                Settings.SetValue("kboost", "1", RegistryValueKind.DWord);

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000");
                key.SetValue("PowerMizerEnable", 1);
                key.SetValue("PerfLevelSrc", 8738);
                key.SetValue("PowerMizerLevel", 1);
                key.SetValue("PowerMizerLevelAC", 1);
                key.Close();

                kboost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(10)))));
                kboost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }

        private void BuffersInFlight_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void apply_Click(object sender, EventArgs e)
        {
           RegistryKey  test = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\services\nvlddmkm", true);  
            try
            {
                Microsoft.Win32.RegistryKey key;
                test.SetValue("BuffersInFlight", box.Text, RegistryValueKind.DWord);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panel2.Visible = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PowerMizer_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Nvidia_PowerMizer.exe"))
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Nvidia_PowerMizer.exe");
            }
            else
            {
                webc.DownloadFile("https://cdn.discordapp.com/attachments/886941868590497804/902242026135912508/Nvidia_PowerMizer.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Nvidia_PowerMizer.exe");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Nvidia_PowerMizer.exe");
            }
        }

        private void Inspector_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\nvidiaProfileInspector.exe"))
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\nvidiaProfileInspector.exe");
            }
            else
            {
                webc.DownloadFile("https://cdn.discordapp.com/attachments/846056787655917602/866494898056331314/nvidiaProfileInspector.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\nvidiaProfileInspector.exe");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\nvidiaProfileInspector.exe");
            }
        }

        private void amit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/amitxvv/Debloated-Nvidia-Drivers");
        }

        private void ddu_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU\Display Driver Uninstaller.exe"))
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU\Display Driver Uninstaller.exe");
            }
            else
            {
                webc.DownloadFile("https://cdn.discordapp.com/attachments/846056787655917602/884566935206002688/DDU.zip", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU.zip");




                string startPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU.zip";
                string zipPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU.zip";
                string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd";
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\DDU\Display Driver Uninstaller.exe");
            }
        }

        private void oc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/14ma-_Os3rNzio85yBemD-YSpF_1z75mZJz1UdzmW8GE/edit");
        }

        private void gpuz_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\GPUZ.exe"))
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\GPUZ.exe");
            }
            else
            {
                webc.DownloadFile("https://cdn.discordapp.com/attachments/846056787655917602/852554005443903518/GPUZ.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\GPUZ.exe");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\GPUZ.exe");
            }
        }

        private void scl_Click(object sender, EventArgs e)
        {
            WebClient webc = new WebClient();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Real_Display_scaling.bat"))
            {
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Real_Display_scaling.bat");
            }
            else
            {
                webc.DownloadFile("https://cdn.discordapp.com/attachments/839611970583134268/882325917840592896/Real_Display_scaling.bat", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Real_Display_scaling.bat");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\nvd\Real_Display_scaling.bat");
            }
        }

        private void close2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
