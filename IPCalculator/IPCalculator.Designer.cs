namespace IPCalculatorNS
{
    partial class IPCalculator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ipTextBox1 = new System.Windows.Forms.TextBox();
            this.ipTextBox2 = new System.Windows.Forms.TextBox();
            this.ipTextBox3 = new System.Windows.Forms.TextBox();
            this.ipTextBox4 = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.binaryTextBox1 = new System.Windows.Forms.TextBox();
            this.binaryTextBox2 = new System.Windows.Forms.TextBox();
            this.binaryTextBox3 = new System.Windows.Forms.TextBox();
            this.binaryTextBox4 = new System.Windows.Forms.TextBox();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.ipDotLeft = new System.Windows.Forms.Label();
            this.ipDotCenter = new System.Windows.Forms.Label();
            this.ipDotRight = new System.Windows.Forms.Label();
            this.subnetSlider = new System.Windows.Forms.TrackBar();
            this.subnetSuffixLabel = new System.Windows.Forms.Label();
            this.network = new System.Windows.Forms.Label();
            this.broadcast = new System.Windows.Forms.Label();
            this.networkAddress = new System.Windows.Forms.Label();
            this.networkInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastAddress = new System.Windows.Forms.Label();
            this.binaryDotLeft = new System.Windows.Forms.Label();
            this.binaryDotCenter = new System.Windows.Forms.Label();
            this.binaryDotRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subnetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.Location = new System.Drawing.Point(63, 95);
            this.ipTextBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ipTextBox1.MaxLength = 3;
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.Size = new System.Drawing.Size(77, 47);
            this.ipTextBox1.TabIndex = 0;
            this.ipTextBox1.Text = "0";
            this.ipTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipTextBox1_KeyUp);
            // 
            // ipTextBox2
            // 
            this.ipTextBox2.Location = new System.Drawing.Point(366, 95);
            this.ipTextBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ipTextBox2.MaxLength = 3;
            this.ipTextBox2.Name = "ipTextBox2";
            this.ipTextBox2.Size = new System.Drawing.Size(77, 47);
            this.ipTextBox2.TabIndex = 1;
            this.ipTextBox2.Text = "0";
            this.ipTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipTextBox2_KeyUp);
            // 
            // ipTextBox3
            // 
            this.ipTextBox3.Location = new System.Drawing.Point(668, 95);
            this.ipTextBox3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ipTextBox3.MaxLength = 3;
            this.ipTextBox3.Name = "ipTextBox3";
            this.ipTextBox3.Size = new System.Drawing.Size(77, 47);
            this.ipTextBox3.TabIndex = 2;
            this.ipTextBox3.Text = "0";
            this.ipTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipTextBox3_KeyUp);
            // 
            // ipTextBox4
            // 
            this.ipTextBox4.Location = new System.Drawing.Point(972, 95);
            this.ipTextBox4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ipTextBox4.MaxLength = 3;
            this.ipTextBox4.Name = "ipTextBox4";
            this.ipTextBox4.Size = new System.Drawing.Size(77, 47);
            this.ipTextBox4.TabIndex = 3;
            this.ipTextBox4.Text = "0";
            this.ipTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ipTextBox4_KeyUp);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(17, 32);
            this.ipAddressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(162, 41);
            this.ipAddressLabel.TabIndex = 4;
            this.ipAddressLabel.Text = "IP-Address";
            // 
            // binaryTextBox1
            // 
            this.binaryTextBox1.Location = new System.Drawing.Point(17, 253);
            this.binaryTextBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.binaryTextBox1.MaxLength = 8;
            this.binaryTextBox1.Name = "binaryTextBox1";
            this.binaryTextBox1.Size = new System.Drawing.Size(162, 47);
            this.binaryTextBox1.TabIndex = 5;
            this.binaryTextBox1.Text = "00000000";
            this.binaryTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.binaryTextBox1_KeyUp);
            // 
            // binaryTextBox2
            // 
            this.binaryTextBox2.Location = new System.Drawing.Point(320, 253);
            this.binaryTextBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.binaryTextBox2.MaxLength = 8;
            this.binaryTextBox2.Name = "binaryTextBox2";
            this.binaryTextBox2.Size = new System.Drawing.Size(162, 47);
            this.binaryTextBox2.TabIndex = 6;
            this.binaryTextBox2.Text = "00000000";
            this.binaryTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.binaryTextBox2_KeyUp);
            // 
            // binaryTextBox3
            // 
            this.binaryTextBox3.Location = new System.Drawing.Point(624, 253);
            this.binaryTextBox3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.binaryTextBox3.MaxLength = 8;
            this.binaryTextBox3.Name = "binaryTextBox3";
            this.binaryTextBox3.Size = new System.Drawing.Size(162, 47);
            this.binaryTextBox3.TabIndex = 7;
            this.binaryTextBox3.Text = "00000000";
            this.binaryTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.binaryTextBox3_KeyUp);
            // 
            // binaryTextBox4
            // 
            this.binaryTextBox4.Location = new System.Drawing.Point(926, 253);
            this.binaryTextBox4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.binaryTextBox4.MaxLength = 8;
            this.binaryTextBox4.Name = "binaryTextBox4";
            this.binaryTextBox4.Size = new System.Drawing.Size(162, 47);
            this.binaryTextBox4.TabIndex = 8;
            this.binaryTextBox4.Text = "00000000";
            this.binaryTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.binaryTextBox4_KeyUp);
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(17, 192);
            this.binaryLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(99, 41);
            this.binaryLabel.TabIndex = 9;
            this.binaryLabel.Text = "Binary";
            // 
            // ipDotLeft
            // 
            this.ipDotLeft.AutoSize = true;
            this.ipDotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipDotLeft.Location = new System.Drawing.Point(230, 95);
            this.ipDotLeft.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ipDotLeft.Name = "ipDotLeft";
            this.ipDotLeft.Size = new System.Drawing.Size(34, 52);
            this.ipDotLeft.TabIndex = 10;
            this.ipDotLeft.Text = ".";
            // 
            // ipDotCenter
            // 
            this.ipDotCenter.AutoSize = true;
            this.ipDotCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipDotCenter.Location = new System.Drawing.Point(544, 95);
            this.ipDotCenter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ipDotCenter.Name = "ipDotCenter";
            this.ipDotCenter.Size = new System.Drawing.Size(34, 52);
            this.ipDotCenter.TabIndex = 11;
            this.ipDotCenter.Text = ".";
            // 
            // ipDotRight
            // 
            this.ipDotRight.AutoSize = true;
            this.ipDotRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipDotRight.Location = new System.Drawing.Point(847, 95);
            this.ipDotRight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ipDotRight.Name = "ipDotRight";
            this.ipDotRight.Size = new System.Drawing.Size(34, 52);
            this.ipDotRight.TabIndex = 12;
            this.ipDotRight.Text = ".";
            // 
            // subnetSlider
            // 
            this.subnetSlider.LargeChange = 8;
            this.subnetSlider.Location = new System.Drawing.Point(17, 337);
            this.subnetSlider.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.subnetSlider.Maximum = 30;
            this.subnetSlider.Name = "subnetSlider";
            this.subnetSlider.Size = new System.Drawing.Size(1040, 114);
            this.subnetSlider.TabIndex = 13;
            this.subnetSlider.Scroll += new System.EventHandler(this.subnetSlider_Scroll);
            // 
            // subnetSuffixLabel
            // 
            this.subnetSuffixLabel.AutoSize = true;
            this.subnetSuffixLabel.Location = new System.Drawing.Point(1046, 369);
            this.subnetSuffixLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.subnetSuffixLabel.Name = "subnetSuffixLabel";
            this.subnetSuffixLabel.Size = new System.Drawing.Size(46, 41);
            this.subnetSuffixLabel.TabIndex = 14;
            this.subnetSuffixLabel.Text = "/0";
            // 
            // network
            // 
            this.network.AutoSize = true;
            this.network.Location = new System.Drawing.Point(17, 501);
            this.network.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(131, 41);
            this.network.TabIndex = 15;
            this.network.Text = "Network";
            // 
            // broadcast
            // 
            this.broadcast.AutoSize = true;
            this.broadcast.Location = new System.Drawing.Point(17, 565);
            this.broadcast.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.broadcast.Name = "broadcast";
            this.broadcast.Size = new System.Drawing.Size(148, 41);
            this.broadcast.TabIndex = 16;
            this.broadcast.Text = "Broadcast";
            // 
            // networkAddress
            // 
            this.networkAddress.AutoSize = true;
            this.networkAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkInfoBindingSource, "NetworkAddress", true));
            this.networkAddress.Location = new System.Drawing.Point(182, 501);
            this.networkAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.networkAddress.Name = "networkAddress";
            this.networkAddress.Size = new System.Drawing.Size(103, 41);
            this.networkAddress.TabIndex = 17;
            this.networkAddress.Text = "0.0.0.0";
            // 
            // networkInfoBindingSource
            // 
            this.networkInfoBindingSource.DataSource = typeof(IPCalculatorNS.NetworkInfo);
            // 
            // broadcastAddress
            // 
            this.broadcastAddress.AutoSize = true;
            this.broadcastAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkInfoBindingSource, "BroadcastAddress", true));
            this.broadcastAddress.Location = new System.Drawing.Point(182, 561);
            this.broadcastAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.broadcastAddress.Name = "broadcastAddress";
            this.broadcastAddress.Size = new System.Drawing.Size(231, 41);
            this.broadcastAddress.TabIndex = 18;
            this.broadcastAddress.Text = "255.255.255.255";
            // 
            // binaryDotLeft
            // 
            this.binaryDotLeft.AutoSize = true;
            this.binaryDotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binaryDotLeft.Location = new System.Drawing.Point(230, 253);
            this.binaryDotLeft.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.binaryDotLeft.Name = "binaryDotLeft";
            this.binaryDotLeft.Size = new System.Drawing.Size(34, 52);
            this.binaryDotLeft.TabIndex = 19;
            this.binaryDotLeft.Text = ".";
            // 
            // binaryDotCenter
            // 
            this.binaryDotCenter.AutoSize = true;
            this.binaryDotCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binaryDotCenter.Location = new System.Drawing.Point(544, 253);
            this.binaryDotCenter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.binaryDotCenter.Name = "binaryDotCenter";
            this.binaryDotCenter.Size = new System.Drawing.Size(34, 52);
            this.binaryDotCenter.TabIndex = 20;
            this.binaryDotCenter.Text = ".";
            // 
            // binaryDotRight
            // 
            this.binaryDotRight.AutoSize = true;
            this.binaryDotRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binaryDotRight.Location = new System.Drawing.Point(847, 253);
            this.binaryDotRight.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.binaryDotRight.Name = "binaryDotRight";
            this.binaryDotRight.Size = new System.Drawing.Size(34, 52);
            this.binaryDotRight.TabIndex = 21;
            this.binaryDotRight.Text = ".";
            // 
            // IPCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 643);
            this.Controls.Add(this.binaryDotRight);
            this.Controls.Add(this.binaryDotCenter);
            this.Controls.Add(this.binaryDotLeft);
            this.Controls.Add(this.broadcastAddress);
            this.Controls.Add(this.networkAddress);
            this.Controls.Add(this.broadcast);
            this.Controls.Add(this.network);
            this.Controls.Add(this.subnetSuffixLabel);
            this.Controls.Add(this.subnetSlider);
            this.Controls.Add(this.ipDotRight);
            this.Controls.Add(this.ipDotCenter);
            this.Controls.Add(this.ipDotLeft);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.binaryTextBox4);
            this.Controls.Add(this.binaryTextBox3);
            this.Controls.Add(this.binaryTextBox2);
            this.Controls.Add(this.binaryTextBox1);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.ipTextBox4);
            this.Controls.Add(this.ipTextBox3);
            this.Controls.Add(this.ipTextBox2);
            this.Controls.Add(this.ipTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "IPCalculator";
            this.Text = "IPCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.subnetSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox1;
        private System.Windows.Forms.TextBox ipTextBox2;
        private System.Windows.Forms.TextBox ipTextBox3;
        private System.Windows.Forms.TextBox ipTextBox4;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox binaryTextBox1;
        private System.Windows.Forms.TextBox binaryTextBox2;
        private System.Windows.Forms.TextBox binaryTextBox3;
        private System.Windows.Forms.TextBox binaryTextBox4;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label ipDotLeft;
        private System.Windows.Forms.Label ipDotCenter;
        private System.Windows.Forms.Label ipDotRight;
        private System.Windows.Forms.TrackBar subnetSlider;
        private System.Windows.Forms.Label subnetSuffixLabel;
        private System.Windows.Forms.Label network;
        private System.Windows.Forms.Label broadcast;
        private System.Windows.Forms.Label networkAddress;
        private System.Windows.Forms.Label broadcastAddress;
        private System.Windows.Forms.Label binaryDotLeft;
        private System.Windows.Forms.Label binaryDotCenter;
        private System.Windows.Forms.Label binaryDotRight;
        private System.Windows.Forms.BindingSource networkInfoBindingSource;
    }
}

