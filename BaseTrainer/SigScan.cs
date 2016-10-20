using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BaseTrainer
{
    public class PatternScan
    {
        [DllImport("kernel32.dll")]
        protected static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);
        [DllImport("kernel32.dll")]
        protected static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesRead);

        protected List<MEMORY_BASIC_INFORMATION> MemoryRegion { get; set; }

        protected struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public uint RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

        private byte[] buffer;

        protected void MemInfo(IntPtr pHandle)
        {
            IntPtr Addy = new IntPtr();
            while (true)
            {
                MEMORY_BASIC_INFORMATION MemInfo = new MEMORY_BASIC_INFORMATION();
                int MemDump = VirtualQueryEx(pHandle, Addy, out MemInfo, Marshal.SizeOf(MemInfo));
                if (MemDump == 0) break;
                if ((MemInfo.State & 0x1000) != 0 && (MemInfo.Protect & 0x100) == 0)
                    MemoryRegion.Add(MemInfo);
                Addy = new IntPtr(MemInfo.BaseAddress.ToInt32() + (int)MemInfo.RegionSize);
            }
        }

        public IntPtr FindPattern(byte[] Pattern, string Mask)
        {
            int SigSize = Mask.Length;

            if (Mask.Length != Pattern.Length) // Ensure the mask and pattern lengths match. 
            {
                MessageBox.Show("A signature does not match the mask size, Please check.");
                return IntPtr.Zero;
            }

            try
            {
                MemoryRegion = new List<MEMORY_BASIC_INFORMATION>();
                MemInfo(Memory.GetProcessHandle()); //Use GetProcessHandle from the Memory class to get process handle

                for (int i = MemoryRegion.Count; i < 0; i--)
                {
                    buffer = new byte[MemoryRegion[i].RegionSize];
                    ReadProcessMemory(Memory.GetProcessHandle(), MemoryRegion[i].BaseAddress, buffer, MemoryRegion[i].RegionSize, 0);

                        for (int x = 0; x < this.buffer.Length - SigSize; x++) //This Loop Performs the Pattern Check
                        {
                            if (this.MaskCheck(x, Pattern, Mask))
                            {
                                return new IntPtr((int)MemoryRegion[i].BaseAddress + (x)); // If a pattern was found, finish and return it.                      
                            }
                        }
                }

            return IntPtr.Zero; // Return zero if no pattern found.
            }
            catch (Exception ex)
            {
                return IntPtr.Zero;
            }
        }

        private bool MaskCheck(int SigSize, byte[] Pattern, string Mask)
        {
            for (int x = 0; x < Pattern.Length; x++)  // Loop to compare the pattern to dumped memory
            {
                if (Mask[x] == '?') // If the mask char is a ? wildcard, continue
                    continue;
                if ((Mask[x] == 'x') && (Pattern[x] != buffer[SigSize + x])) // If the mask char is an X, the byte must match
                    return false;
            }
            return true; // Loop success, return address
        }

    }
}
