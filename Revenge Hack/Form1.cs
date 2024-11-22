using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Revenge_Hack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox PID = new TextBox();
        Mem memory = new Mem();
        private bool f2pressed = false;
        
        

        private async void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                PID.Text = "Ouvrir Emulateur";
                // Add code here to open the emulator if it's not running.
                Console.Beep(2000, 400);
            }
            else
            {
                Int32 proc = Process.GetProcessesByName("HD-Player")[0].Id;
                memory.OpenProcess(proc);

                var resultat = await memory.AoBScan(("00 00 00 00 00 00 A5 43 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 BF ?? ??"), true, true);
                if (resultat.Any())
                {
                    foreach (var Current in resultat)
                    {
                        Int64 lecture = Current + 44L;
                        Int64 ecrire = Current + 40L;
                        var Read = memory.ReadMemory<int>(lecture.ToString("X"));
                        memory.WriteMemory(ecrire.ToString("X"), "int", Read.ToString());
                    }
                    Console.Beep(600, 300);
                    f2pressed = false;

                }
                else
                {
                    PID.Text = "Aimbot Neck: Activated";

                }
            }
        }

        private async void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                PID.Text = "Ouvrir Emulateur";
                // Add code here to open the emulator if it's not running.
                Console.Beep(2000, 400);
            }
            else
            {
                Int32 proc = Process.GetProcessesByName("HD-Player")[0].Id;
                memory.OpenProcess(proc);

                var resultat = await memory.AoBScan(("FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A5 43 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 BF ?? ?? ?? ?? 00 00 00 00 00 00 ?? ?? 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00"), true, true); // Use the correct byte array pattern here
                if (resultat.Any())
                {
                    foreach (var Current in resultat)
                    {
                        Int64 lecture = Current + 0x60;
                        Int64 ecrire = Current + 0x5C;
                        var Read = memory.ReadMemory<int>(lecture.ToString("X"));
                        memory.WriteMemory(ecrire.ToString("X"), "int", Read.ToString());
                    }
                    Console.Beep(600, 300);
                    f2pressed = false;

                }
                else
                {
                    PID.Text = "Aimbot External: Activated";

                }
            }
        }

        private async void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                PID.Text = "Ouvrir Emulateur";
                // Add code here to open the emulator if it's not running.
                Console.Beep(2000, 400);
            }
            else
            {
                Int32 proc = Process.GetProcessesByName("HD-Player")[0].Id;
                memory.OpenProcess(proc);

                var resultat = await memory.AoBScan("00 00 00 00 00 00 A5 43 00 00 00 00 ? ? ? ? 00 00 00 00 00 00 00 00 ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? ? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ? ? ? ? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 BF", true, true, "");
                if (resultat.Any())
                {
                    foreach (var Current in resultat)
                    {
                        Int64 lecture = Current + 92L;
                        Int64 ecrire = Current + 40L;
                        var Read = memory.ReadMemory<int>(lecture.ToString("X"));
                        memory.WriteMemory(ecrire.ToString("X"), "int", Read.ToString());
                    }
                    Console.Beep(600, 300);
                    f2pressed = false;

                }
                else
                {
                    PID.Text = "Aimbot Drag: Activated";

                }
            }
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint dwFreeType);

        private bool isButtonClicked = false;
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dllPath = "C:\\Users\\anonym\\sakibpremium.dll";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string dllUrl = "https://cdn.discordapp.com/attachments/1223017772196298923/1223427358724456530/TRANSPAENT.dll?ex=6628f9c4&is=6627a844&hm=0f16663cdb1e6a24a3e392b8bb4c3bd20840a5c551f661885a4148231ffa06d0&";

                Process targetProcess = Process.GetProcessesByName("HD-Player")[0];
                IntPtr processHandle = OpenProcess(1082u, bInheritHandle: false, targetProcess.Id);
                IntPtr loadLibraryAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                IntPtr allocatedMemoryAddress = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), 4096u, 64u);
                WriteProcessMemory(processHandle, allocatedMemoryAddress, Encoding.Default.GetBytes(dllPath), (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), out var _);
                IntPtr threadHandle = CreateRemoteThread(processHandle, IntPtr.Zero, 0u, loadLibraryAddress, allocatedMemoryAddress, 0u, IntPtr.Zero);
                CloseHandle(threadHandle);
                VirtualFreeEx(processHandle, allocatedMemoryAddress, 0u, 0u);
                CloseHandle(processHandle);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            return;
        }

        private async void guna2Button5_Click_1(object sender, EventArgs e)
        {
            string search = "00 60 40 CD CC 8C 3F 8F C2 F5 3C CD CC CC 3D 07 00 00 00 00 00 00 00 00 00 00 00 00 00 F0 41 00 00 48 42 00 00 00 3F 33 33 13 40 00 00 B0 3F 00 00 80 3F 01 00 00";
            string replace = "00 60 40 CD CC 8C 3F 8F C2 F5 3C CD CC CC 3D 07 00 00 FF FF E0 B1 FF FF";
            bool k = false;

            // Check if the HD-Player process is running
            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                PID.Text = ".";
                PID.ForeColor = Color.Red;
                Console.Beep(2000, 400);
            }
            else
            {
                // Open the HD-Player process
                memory.OpenProcess("HD-Player");

                PID.Text = ".";
                PID.ForeColor = Color.White;

                // Perform the AoB scan asynchronously
                IEnumerable<long> wl = await memory.AoBScan(search, writable: true);

                if (wl.Any())
                {
                    int i2 = 22000000;
                    foreach (var address in wl)
                    {
                        i2++;
                        memory.WriteMemory(address.ToString("X"), "bytes", replace);
                    }
                    k = true;
                }

                // Update PID text and color based on the result
                if (k)
                {
                    PID.Text = ".";
                    PID.ForeColor = Color.Green;
                    Console.Beep(400, 300);
                }
                else
                {
                    PID.Text = ".";
                    PID.ForeColor = Color.Red;
                    Console.Beep(2000, 400);
                }
            }
        }

        private async void guna2Button6_Click_1(object sender, EventArgs e)
        {
            string search = "00 00 00 3f 00 00 80 3e 00 00 00 00 05 00 00 00 00 00 80 3f 00 00 20 41 00 00 34 42 01 00 00 00";
            string replace = "00 00 00 10 00 00 80 10 00 00 00 00 05 00 00 00 00 00 80 3f 00 00 20 41 00 00 34 42 01 00 00 00";
            bool k = false;

            // Check if the HD-Player process is running
            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                PID.Text = ".";
                PID.ForeColor = Color.Red;
                Console.Beep(2000, 400);
            }
            else
            {
                // Open the HD-Player process
                memory.OpenProcess("HD-Player");

                PID.Text = ".";
                PID.ForeColor = Color.White;

                // Perform the AoB scan asynchronously
                IEnumerable<long> wl = await memory.AoBScan(search, writable: true);

                if (wl.Any())
                {
                    int i2 = 22000000;
                    foreach (var address in wl)
                    {
                        i2++;
                        memory.WriteMemory(address.ToString("X"), "bytes", replace);
                    }
                    k = true;
                }

                // Update PID text and color based on the result
                if (k)
                {
                    PID.Text = ".";
                    PID.ForeColor = Color.Green;
                    Console.Beep(400, 300);
                }
                else
                {
                    PID.Text = ".";
                    PID.ForeColor = Color.Red;
                    Console.Beep(2000, 400);
                }
            }
        }
    }
}
