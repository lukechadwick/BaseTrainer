namespace BaseTrainer
{
    partial class Trainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FindProcess = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.RunSigScan = new System.ComponentModel.BackgroundWorker();
            this.btnWriteByte = new System.Windows.Forms.Button();
            this.btnWriteFloat = new System.Windows.Forms.Button();
            this.btnWriteInteger = new System.Windows.Forms.Button();
            this.btnWriteDouble = new System.Windows.Forms.Button();
            this.btnWriteString = new System.Windows.Forms.Button();
            this.btnReadString = new System.Windows.Forms.Button();
            this.btnReadDouble = new System.Windows.Forms.Button();
            this.btnReadInteger = new System.Windows.Forms.Button();
            this.btnReadFloat = new System.Windows.Forms.Button();
            this.btnReadBytes = new System.Windows.Forms.Button();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.btnGetBaseAddress = new System.Windows.Forms.Button();
            this.btnGetPointerAddress = new System.Windows.Forms.Button();
            this.txtPointer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSigScan = new System.Windows.Forms.Button();
            this.btnGetDLLBaseAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindProcess
            // 
            this.FindProcess.Enabled = true;
            this.FindProcess.Interval = 1000;
            this.FindProcess.Tick += new System.EventHandler(this.FindProcess_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Cyan;
            this.txtStatus.Location = new System.Drawing.Point(3, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(259, 20);
            this.txtStatus.TabIndex = 128;
            this.txtStatus.Text = "Loading...";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RunSigScan
            // 
            this.RunSigScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunSigScan_DoWork);
            // 
            // btnWriteByte
            // 
            this.btnWriteByte.Location = new System.Drawing.Point(3, 24);
            this.btnWriteByte.Name = "btnWriteByte";
            this.btnWriteByte.Size = new System.Drawing.Size(126, 27);
            this.btnWriteByte.TabIndex = 129;
            this.btnWriteByte.Text = "Write Bytes Example";
            this.btnWriteByte.UseVisualStyleBackColor = true;
            this.btnWriteByte.Click += new System.EventHandler(this.btnWriteByte_Click);
            // 
            // btnWriteFloat
            // 
            this.btnWriteFloat.Location = new System.Drawing.Point(3, 51);
            this.btnWriteFloat.Name = "btnWriteFloat";
            this.btnWriteFloat.Size = new System.Drawing.Size(126, 27);
            this.btnWriteFloat.TabIndex = 130;
            this.btnWriteFloat.Text = "Write Float Example";
            this.btnWriteFloat.UseVisualStyleBackColor = true;
            this.btnWriteFloat.Click += new System.EventHandler(this.btnWriteFloat_Click);
            // 
            // btnWriteInteger
            // 
            this.btnWriteInteger.Location = new System.Drawing.Point(3, 78);
            this.btnWriteInteger.Name = "btnWriteInteger";
            this.btnWriteInteger.Size = new System.Drawing.Size(126, 27);
            this.btnWriteInteger.TabIndex = 131;
            this.btnWriteInteger.Text = "Write Integer Example";
            this.btnWriteInteger.UseVisualStyleBackColor = true;
            this.btnWriteInteger.Click += new System.EventHandler(this.btnWriteInteger_Click);
            // 
            // btnWriteDouble
            // 
            this.btnWriteDouble.Location = new System.Drawing.Point(3, 105);
            this.btnWriteDouble.Name = "btnWriteDouble";
            this.btnWriteDouble.Size = new System.Drawing.Size(126, 27);
            this.btnWriteDouble.TabIndex = 132;
            this.btnWriteDouble.Text = "Write Double Example";
            this.btnWriteDouble.UseVisualStyleBackColor = true;
            this.btnWriteDouble.Click += new System.EventHandler(this.btnWriteDouble_Click);
            // 
            // btnWriteString
            // 
            this.btnWriteString.Location = new System.Drawing.Point(3, 132);
            this.btnWriteString.Name = "btnWriteString";
            this.btnWriteString.Size = new System.Drawing.Size(126, 27);
            this.btnWriteString.TabIndex = 133;
            this.btnWriteString.Text = "Write String Example";
            this.btnWriteString.UseVisualStyleBackColor = true;
            this.btnWriteString.Click += new System.EventHandler(this.btnWriteString_Click);
            // 
            // btnReadString
            // 
            this.btnReadString.Location = new System.Drawing.Point(136, 132);
            this.btnReadString.Name = "btnReadString";
            this.btnReadString.Size = new System.Drawing.Size(126, 27);
            this.btnReadString.TabIndex = 138;
            this.btnReadString.Text = "Read String Example";
            this.btnReadString.UseVisualStyleBackColor = true;
            this.btnReadString.Click += new System.EventHandler(this.btnReadString_Click);
            // 
            // btnReadDouble
            // 
            this.btnReadDouble.Location = new System.Drawing.Point(136, 105);
            this.btnReadDouble.Name = "btnReadDouble";
            this.btnReadDouble.Size = new System.Drawing.Size(126, 27);
            this.btnReadDouble.TabIndex = 137;
            this.btnReadDouble.Text = "Read Double Example";
            this.btnReadDouble.UseVisualStyleBackColor = true;
            this.btnReadDouble.Click += new System.EventHandler(this.btnReadDouble_Click);
            // 
            // btnReadInteger
            // 
            this.btnReadInteger.Location = new System.Drawing.Point(136, 78);
            this.btnReadInteger.Name = "btnReadInteger";
            this.btnReadInteger.Size = new System.Drawing.Size(126, 27);
            this.btnReadInteger.TabIndex = 136;
            this.btnReadInteger.Text = "Read Integer Example";
            this.btnReadInteger.UseVisualStyleBackColor = true;
            this.btnReadInteger.Click += new System.EventHandler(this.btnReadInteger_Click);
            // 
            // btnReadFloat
            // 
            this.btnReadFloat.Location = new System.Drawing.Point(136, 51);
            this.btnReadFloat.Name = "btnReadFloat";
            this.btnReadFloat.Size = new System.Drawing.Size(126, 27);
            this.btnReadFloat.TabIndex = 135;
            this.btnReadFloat.Text = "Read Float Example";
            this.btnReadFloat.UseVisualStyleBackColor = true;
            this.btnReadFloat.Click += new System.EventHandler(this.btnReadFloat_Click);
            // 
            // btnReadBytes
            // 
            this.btnReadBytes.Location = new System.Drawing.Point(136, 24);
            this.btnReadBytes.Name = "btnReadBytes";
            this.btnReadBytes.Size = new System.Drawing.Size(126, 27);
            this.btnReadBytes.TabIndex = 134;
            this.btnReadBytes.Text = "Read Bytes Example";
            this.btnReadBytes.UseVisualStyleBackColor = true;
            this.btnReadBytes.Click += new System.EventHandler(this.btnReadBytes_Click);
            // 
            // txtExample
            // 
            this.txtExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExample.ForeColor = System.Drawing.Color.Cyan;
            this.txtExample.Location = new System.Drawing.Point(136, 163);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(126, 20);
            this.txtExample.TabIndex = 169;
            this.txtExample.Text = "Read Example";
            this.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBaseAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseAddress.ForeColor = System.Drawing.Color.Cyan;
            this.txtBaseAddress.Location = new System.Drawing.Point(3, 219);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.ReadOnly = true;
            this.txtBaseAddress.Size = new System.Drawing.Size(83, 20);
            this.txtBaseAddress.TabIndex = 171;
            this.txtBaseAddress.Text = "Base Address";
            this.txtBaseAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetBaseAddress
            // 
            this.btnGetBaseAddress.Location = new System.Drawing.Point(3, 191);
            this.btnGetBaseAddress.Name = "btnGetBaseAddress";
            this.btnGetBaseAddress.Size = new System.Drawing.Size(126, 27);
            this.btnGetBaseAddress.TabIndex = 172;
            this.btnGetBaseAddress.Text = "Get Base Address";
            this.btnGetBaseAddress.UseVisualStyleBackColor = true;
            this.btnGetBaseAddress.Click += new System.EventHandler(this.btnGetBaseAddress_Click);
            // 
            // btnGetPointerAddress
            // 
            this.btnGetPointerAddress.Location = new System.Drawing.Point(136, 191);
            this.btnGetPointerAddress.Name = "btnGetPointerAddress";
            this.btnGetPointerAddress.Size = new System.Drawing.Size(126, 27);
            this.btnGetPointerAddress.TabIndex = 174;
            this.btnGetPointerAddress.Text = "Get Pointer Address";
            this.btnGetPointerAddress.UseVisualStyleBackColor = true;
            this.btnGetPointerAddress.Click += new System.EventHandler(this.btnGetPointerAddress_Click);
            // 
            // txtPointer
            // 
            this.txtPointer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPointer.ForeColor = System.Drawing.Color.Cyan;
            this.txtPointer.Location = new System.Drawing.Point(136, 219);
            this.txtPointer.Name = "txtPointer";
            this.txtPointer.ReadOnly = true;
            this.txtPointer.Size = new System.Drawing.Size(126, 20);
            this.txtPointer.TabIndex = 173;
            this.txtPointer.Text = "Pointer Address";
            this.txtPointer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-11, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(320, 1);
            this.label12.TabIndex = 175;
            this.label12.Text = "                                                                                 " +
    "                                                                      ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 240);
            this.label1.TabIndex = 176;
            this.label1.Text = "                                                                                 " +
    "                                                                      ";
            // 
            // btnSigScan
            // 
            this.btnSigScan.Location = new System.Drawing.Point(3, 159);
            this.btnSigScan.Name = "btnSigScan";
            this.btnSigScan.Size = new System.Drawing.Size(126, 27);
            this.btnSigScan.TabIndex = 177;
            this.btnSigScan.Text = "Find Pattern (SigScan)";
            this.btnSigScan.UseVisualStyleBackColor = true;
            this.btnSigScan.Click += new System.EventHandler(this.btnSigScan_Click);
            // 
            // btnGetDLLBaseAddress
            // 
            this.btnGetDLLBaseAddress.Location = new System.Drawing.Point(86, 218);
            this.btnGetDLLBaseAddress.Name = "btnGetDLLBaseAddress";
            this.btnGetDLLBaseAddress.Size = new System.Drawing.Size(43, 22);
            this.btnGetDLLBaseAddress.TabIndex = 178;
            this.btnGetDLLBaseAddress.Text = "DLL";
            this.btnGetDLLBaseAddress.UseVisualStyleBackColor = true;
            this.btnGetDLLBaseAddress.Click += new System.EventHandler(this.btnGetDLLBaseAddress_Click);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 241);
            this.Controls.Add(this.btnGetDLLBaseAddress);
            this.Controls.Add(this.btnSigScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGetPointerAddress);
            this.Controls.Add(this.txtPointer);
            this.Controls.Add(this.btnGetBaseAddress);
            this.Controls.Add(this.txtBaseAddress);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.btnReadString);
            this.Controls.Add(this.btnReadDouble);
            this.Controls.Add(this.btnReadInteger);
            this.Controls.Add(this.btnReadFloat);
            this.Controls.Add(this.btnReadBytes);
            this.Controls.Add(this.btnWriteString);
            this.Controls.Add(this.btnWriteDouble);
            this.Controls.Add(this.btnWriteInteger);
            this.Controls.Add(this.btnWriteFloat);
            this.Controls.Add(this.btnWriteByte);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Trainer";
            this.Text = "C# Base Trainer 1.3 - *M*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FindProcess;
        private System.Windows.Forms.TextBox txtStatus;
        private System.ComponentModel.BackgroundWorker RunSigScan;
        private System.Windows.Forms.Button btnWriteByte;
        private System.Windows.Forms.Button btnWriteFloat;
        private System.Windows.Forms.Button btnWriteInteger;
        private System.Windows.Forms.Button btnWriteDouble;
        private System.Windows.Forms.Button btnWriteString;
        private System.Windows.Forms.Button btnReadString;
        private System.Windows.Forms.Button btnReadDouble;
        private System.Windows.Forms.Button btnReadInteger;
        private System.Windows.Forms.Button btnReadFloat;
        private System.Windows.Forms.Button btnReadBytes;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.Button btnGetBaseAddress;
        private System.Windows.Forms.Button btnGetPointerAddress;
        private System.Windows.Forms.TextBox txtPointer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSigScan;
        private System.Windows.Forms.Button btnGetDLLBaseAddress;
    }
}

