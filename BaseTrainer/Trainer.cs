using System;
using System.Diagnostics;
using System.Windows.Forms;
//Get Latest source at https://github.com/I-M-I/BaseTrainer

namespace BaseTrainer
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        //The Exe name of your target execuatble, minus the .exe. this is currently targeting League of Legends.exe
        public static string ExeName = "League of Legends";

        //Signatures
        int signature_Health;  //Example signature, when the SigScan worker is run, it will store the result here as an int value     


        private void FindProcess_Tick(object sender, EventArgs e) //Find Process Timer
        {
            if (Process.GetProcessesByName(ExeName).Length != 0) //If there is a league process begin the code to check if a scan is needed                
            {
                    txtStatus.Text = "Trainer Ready"; //Change Status text to Ready
            }
            else
            {
                txtStatus.Text = "Searching for " + ExeName + " Process..."; //Change Status text to Searching

                signature_Health = 0; //Reset Signature, if your target closes its best to set this to zero again so when you re-open your target you can scan for the new signature
            }
        }

        private void RunSigScan_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) //Signature Scan Background Worker
        {
            PatternScan scan = new PatternScan(); //Begin a new scan
            //Signatures to scan for
            signature_Health = scan.FindPattern(new byte[] { 0xEB, 0x80, 0x20, 0x01, 0x10, 0xFF }, "xx??xx").ToInt32(); //Example signature. x's will be checked for and ?'s will be ignored, so in this example we would be searching for EB 80 ?? ?? 10 FF
        } 

        private void btnWriteByte_Click(object sender, EventArgs e) //Write Byte Example
        {
            Memory.WriteBytes(0x401000, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x50, 0x27 });
        }  

        private void btnWriteFloat_Click(object sender, EventArgs e) //Write Float Example
        {
            Memory.WriteFloat(0x401000, 0.12345f);
        }

        private void btnWriteInteger_Click(object sender, EventArgs e) //Write Integer Example
        {
            Memory.WriteInteger(0x401000, 12345, 4); //Writing a 4 byte integer
        }

        private void btnWriteDouble_Click(object sender, EventArgs e) //Write Double Example
        {
            Memory.WriteDouble(0x401000, 1.7977E+3);
        }

        private void btnWriteString_Click(object sender, EventArgs e) //Write String Example
        {
            Memory.WriteString(0x401000, "MyString");
        }

        private void btnReadBytes_Click(object sender, EventArgs e) //Read Bytes Example
        {                      
            byte[] Buffer = Memory.ReadByte(0x401000, 5); //Read 5 bytes to the array named Buffer

            txtExample.Text = BitConverter.ToString(Buffer);
        }

        private void btnReadFloat_Click(object sender, EventArgs e) //Read Float Example
        {
            float Example = Memory.ReadFloat(0x401000);

            txtExample.Text = Example.ToString();
        }

        private void btnReadInteger_Click(object sender, EventArgs e) //Read Integer Example
        {
            int Example = Memory.ReadInteger(0x401000, 4);

            txtExample.Text = Example.ToString();
        }

        private void btnReadDouble_Click(object sender, EventArgs e) //Read Double Example
        {
            double Example = Memory.ReadDouble(0x401000);

            txtExample.Text = Example.ToString();
        }

        private void btnReadString_Click(object sender, EventArgs e) //Read String Example
        {
            String Example = Memory.ReadString(0x401000, 8); //For a string that is 8 charcters long

            txtExample.Text = Example;
        }

        private void btnGetBaseAddress_Click(object sender, EventArgs e) //Get Process Base Address Example
        {
            int baseaddress = Memory.GetBaseAddress(ExeName, "League of Legends.exe");

            txtBaseAddress.Text = "0x" + baseaddress.ToString("X"); // the "X" inside the () shows the number in hexidecimal format, like a memory address
        }

        private void btnGetDLLBaseAddress_Click(object sender, EventArgs e) //Get Process DLL Base Address Example
        {
            int baseaddress = Memory.GetBaseAddress(ExeName, "d3d9.dll");

            txtBaseAddress.Text = "0x" + baseaddress.ToString("X"); // the "X" inside the () shows the number in hexidecimal format, like a memory address
        }

        private void btnGetPointerAddress_Click(object sender, EventArgs e) //Get Pointer Address Example
        {
            int pointer = Memory.GetPointerAddress(0xD0000 + 0x0117DAA4, new int[] { 0x22c, 0x790, 0x29c, 0x7c0 });

            txtPointer.Text = "0x" + pointer.ToString("X");
        }

        private void btnSigScan_Click(object sender, EventArgs e) //Call Signature Scan Worker Example
        {
            txtStatus.Text = "Scanning..."; //Change Status text to scanning
            RunSigScan.RunWorkerAsync();  //Perform Scan, using a worker will perform the scan in another thread so the GUI doesn't lock up while scanning.
        }

    }
}

