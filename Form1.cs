using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Speech;
using System.Speech.Synthesis;

namespace PC_Control
{
    public partial class pccontrol : Form
    {
        public pccontrol()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer(); /* SYNTEZATOR MOWY */
            synth.Speak(" ");

            String t1 = Environment.MachineName;
            MachineName.Text = t1;

            String t2 = Environment.UserName;
            userName.Text = t2;

            int t3 = Environment.ProcessorCount;
            ProcessorCount.Text = Convert.ToString(t3);

            bool t4 = Environment.Is64BitOperatingSystem;
            wersja.Text = Convert.ToString(t4);

            bool t5 = Environment.Is64BitProcess;
            bitProcess.Text = Convert.ToString(t5);

            String t6 = Environment.OSVersion.Platform.ToString();
            systemPlatform.Text = t6;

            String t7 = Environment.OSVersion.ToString();
            versionWord.Text = t7;

            String t8 = Environment.OSVersion.Version.ToString();
            version.Text = t8;

            /* HARDWARE INFORMATION - Osobny plik Class HardwareInfo.cs */
            lblCM.Text = HardwareInfo.GetCPUManufacturer();
            lblPid.Text = HardwareInfo.GetProcessorId();
            lblCS.Text = HardwareInfo.GetCpuSpeedInGHz() + " Ghz".ToString();
            lblHDD.Text = HardwareInfo.GetHDDSerialNo();
            lblBM.Text = HardwareInfo.GetBoardMaker();
            lblBios.Text = HardwareInfo.GetBIOSmaker();
            lblPM.Text = HardwareInfo.GetPhysicalMemory();

            
        }

#region Procesy ruchome
        /* INFORMACJE BIEŻĄCE */
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");

        private void timer1_Tick(object sender, EventArgs e) // Informacje Bieżące
        {
            label10.Text = /*"CPU:" + "  " +*/ (int)perfCPUCounter.NextValue() + "  " + "%";
            label14.Text = /*"Available Memory:" + "  " +*/ (int)perfMemCounter.NextValue() + "   " + " MB";
            label18.Text = /*"System Up Time" + "  " +*/ (int)perfSystemCounter.NextValue() / 60 / 60 + " godz. " + label22.Text;
            label22.Text = /*"System Up Time" + "  " +*/ (int)perfSystemCounter.NextValue() % 3600 / 60 + " min.";
        }
        #endregion

        
    }
}
