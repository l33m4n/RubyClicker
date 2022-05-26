using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;

namespace Autoclicker_C
{
    public partial class form1 : MaterialForm
    {
        //DLLS for clicker
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);


        public form1()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red500,
                Primary.Red500, Accent.LightBlue200,
                TextShade.WHITE
            );

            
        }
        //write cps to label
        private void CPSTrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = (CPSTrackbar1.Value.ToString() + " CPS");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        //change text of button on click
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Enable"))
            {
                btnToggle.Text = "Disable";
            }
            else if (btnToggle.Text.Contains("Disable"))
            {
                btnToggle.Text = "Enable";
            }
        }
        //if button clicked start autoclicker and change text
        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable"))
            {
                Autoclicker.Start();
            }
            else
            {
                Autoclicker.Stop();
            }

            if (btnToggle.Text.Contains("Disable"))
            {
                btnToggle.ForeColor = Color.White;
                btnToggle.FillColor = Color.Red;
            }
            else if (btnToggle.Text.Contains("Enable"))
            {
                btnToggle.ForeColor = Color.White;
                btnToggle.FillColor = Color.LightCoral;
            }
        }
        int min;
        int max;
        IntPtr hWnd;
        //pull active windows 
        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }


        //randomize click speed
        private void Random_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable"))
            {
                min = CPSTrackbar1.Value - randomtrackbar.Value;
                max = CPSTrackbar1.Value + randomtrackbar.Value;
                Random rand = new Random();
                randomTB.Value = (rand.Next(min, max));
            }
        }

        private void randomTB_Scroll(object sender, ScrollEventArgs e)
        {

        }




        private async void Autoclicker_Tick(object sender, EventArgs e)
        {
            try
            {
                Autoclicker.Interval = 1000 / randomTB.Value;
            }
            catch { }
            if (btnToggle.Text.Contains("Disable"))
            {
                //find javaw
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }
                //if javaw found start clicker 

                if (currentwindow.Contains("javaw"))
                {
                    //Left MB clicker
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0202, 0, 0);
                    }
                    //Right MB clicker
                    if (RMBclick.Checked)
                        if (MouseButtons == MouseButtons.Right)
                        {
                            PostMessage(hWnd, 0x0204, 0, 0);
                            await Task.Delay(30);
                            PostMessage(hWnd, 0x0205, 0, 0);
                        }
                
                }
            }
        }
        //change keybind button to ... on click
        private void bindBtn_Click(object sender, EventArgs e)
        {
            bindBtn.Text = "...";
        }

        KeysConverter Key = new KeysConverter();
        //listen for keys, and activate on button press
        private void Binding_Tick(object sender, EventArgs e)
        {
            if (bindBtn.Text != "none" && bindBtn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {

                  
                    if (btnToggle.Text.Contains("Enable"))
                    {
                        btnToggle.Text = "Disable";
                    }
                    else if (btnToggle.Text.Contains("Disable"))
                    {
                        btnToggle.FillColor = Color.LightCoral;
                        btnToggle.Text = "Enable";
                    }
                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(20);
                    }

                    return;
                }
            }
        }
        //write keybind to button
        private void bindBtn_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keydata = e.KeyData.ToString();
                if (!keydata.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        bindBtn.Text = "none";
                    }
                    else
                    {
                        bindBtn.Text = keydata;
                    }
                }
            }
            KeysConverter Key = new KeysConverter();
        }
        private void randomtrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            randometer.Text = (randomtrackbar.Value.ToString());
        }


        private void CPSvalue2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            //Delete ruby.exe.pf from prefetch
            String recent = Environment.ExpandEnvironmentVariables("%USERPROFILE%") + "\\Recent";
            String prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + "\\Prefetch";



            new List<string>(Directory.GetFiles(prefetch)).ForEach(file => {
                if (file.IndexOf("RUBY.exe", StringComparison.OrdinalIgnoreCase) >= 0)
                    File.Delete(file);
            });



            //Delete registry entries from recent files 
            //        string key1 = @"SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache";
            //        string key2 = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store";
            //        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(key1, true))
            //       {
            //      if (key == null) 
            //      {
            //      Console.WriteLine("Key was found!");
            //      Console.WriteLine(key.GetValue("Ruby.exe"));

            // Key doesn't exist. Do whatever you want to handle
            // this case
            //   }
            //      else
            //      {
            //      Console.WriteLine("Key was not found!");
            // key.DeleteValue(String.EndsWith("Ruby.exe"));
            // Console.WriteLine(key);
            //  }
            //   }
            //    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(key2, true))
            //    {
            //    if (key == null)
            //     {
            //// Key doesn't exist. Do whatever you want to handle
            // this case
            //}
            //    else
            //    {
            // key.DeleteValue($"Ruby.exe");
            // key.DeleteSubKeyTree("Ruby.exe");
            //     Thread.Sleep(1000);
            //     }
            //    }



            //Spawn CMD window to delete file and close app
            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe"
               
            });
            //delete prefetch file 
            const string strCmdText = "/C cd C:\\windows\\prefetch&timeout /t 10 >NUL && del *ruby*";
            Process.Start("CMD.exe", strCmdText);


            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C cd " + recent + "&timeout /t 10 >NUL && del *ruby*",
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe"
               
            });

            Thread.Sleep(100);
            Application.Exit();
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = (CPSTrackbar1.Value.ToString() + " CPS");
        }

        private void siticoneMaterialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
