namespace Subnet_Calculator
{
    partial class FrmMain
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
            this.lblNetworkClass = new System.Windows.Forms.Label();
            this.lblSubnetBits = new System.Windows.Forms.Label();
            this.lblDesiredSubnet = new System.Windows.Forms.Label();
            this.txtDesiredSubnet = new System.Windows.Forms.TextBox();
            this.lblHostBits = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboSubnetBits = new System.Windows.Forms.ComboBox();
            this.cboHostBits = new System.Windows.Forms.ComboBox();
            this.cboMaskBits = new System.Windows.Forms.ComboBox();
            this.lblMaskBits = new System.Windows.Forms.Label();
            this.cboMaxSubnets = new System.Windows.Forms.ComboBox();
            this.lblMaximumSubnets = new System.Windows.Forms.Label();
            this.cboMaxHosts = new System.Windows.Forms.ComboBox();
            this.lblHostPerSubnet = new System.Windows.Forms.Label();
            this.txtNWAddress = new System.Windows.Forms.TextBox();
            this.lblSubnetInfo = new System.Windows.Forms.Label();
            this.lblNWAddress = new System.Windows.Forms.Label();
            this.lblBCAddress = new System.Windows.Forms.Label();
            this.lblAddressRange = new System.Windows.Forms.Label();
            this.txtBCAddress = new System.Windows.Forms.TextBox();
            this.txtNWRange = new System.Windows.Forms.TextBox();
            this.txtBitmap = new System.Windows.Forms.TextBox();
            this.lblBitmap = new System.Windows.Forms.Label();
            this.lblSubnetError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.lblNetworkMask = new System.Windows.Forms.Label();
            this.cboNetworkMask = new System.Windows.Forms.ComboBox();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.txtBCBinary = new System.Windows.Forms.TextBox();
            this.txtSNBinary = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNWMBinary = new System.Windows.Forms.TextBox();
            this.txtSNBBinary = new System.Windows.Forms.TextBox();
            this.txtHBBinary = new System.Windows.Forms.TextBox();
            this.txtMBBinary = new System.Windows.Forms.TextBox();
            this.txtDSNBinary = new System.Windows.Forms.TextBox();
            this.txtNWBinary = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetworkClass
            // 
            this.lblNetworkClass.AutoSize = true;
            this.lblNetworkClass.Location = new System.Drawing.Point(39, 35);
            this.lblNetworkClass.Name = "lblNetworkClass";
            this.lblNetworkClass.Size = new System.Drawing.Size(78, 13);
            this.lblNetworkClass.TabIndex = 0;
            this.lblNetworkClass.Text = "Network Class:";
            // 
            // lblSubnetBits
            // 
            this.lblSubnetBits.AutoSize = true;
            this.lblSubnetBits.Location = new System.Drawing.Point(53, 115);
            this.lblSubnetBits.Name = "lblSubnetBits";
            this.lblSubnetBits.Size = new System.Drawing.Size(64, 13);
            this.lblSubnetBits.TabIndex = 0;
            this.lblSubnetBits.Text = "Subnet Bits:";
            // 
            // lblDesiredSubnet
            // 
            this.lblDesiredSubnet.AutoSize = true;
            this.lblDesiredSubnet.Location = new System.Drawing.Point(34, 250);
            this.lblDesiredSubnet.Name = "lblDesiredSubnet";
            this.lblDesiredSubnet.Size = new System.Drawing.Size(83, 13);
            this.lblDesiredSubnet.TabIndex = 0;
            this.lblDesiredSubnet.Text = "Desired Subnet:";
            // 
            // txtDesiredSubnet
            // 
            this.txtDesiredSubnet.Location = new System.Drawing.Point(123, 247);
            this.txtDesiredSubnet.Name = "txtDesiredSubnet";
            this.txtDesiredSubnet.Size = new System.Drawing.Size(100, 20);
            this.txtDesiredSubnet.TabIndex = 5;
            this.txtDesiredSubnet.TextChanged += new System.EventHandler(this.ComponentUpdate);
            this.txtDesiredSubnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblHostBits
            // 
            this.lblHostBits.AutoSize = true;
            this.lblHostBits.Location = new System.Drawing.Point(65, 142);
            this.lblHostBits.Name = "lblHostBits";
            this.lblHostBits.Size = new System.Drawing.Size(52, 13);
            this.lblHostBits.TabIndex = 0;
            this.lblHostBits.Text = "Host Bits:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(56, 62);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblIPAddress.TabIndex = 0;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboClass.Location = new System.Drawing.Point(123, 32);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(64, 21);
            this.cboClass.TabIndex = 1;
            this.cboClass.TabStop = false;
            this.cboClass.Text = "A";
            this.cboClass.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // cboSubnetBits
            // 
            this.cboSubnetBits.FormattingEnabled = true;
            this.cboSubnetBits.Location = new System.Drawing.Point(123, 112);
            this.cboSubnetBits.Name = "cboSubnetBits";
            this.cboSubnetBits.Size = new System.Drawing.Size(100, 21);
            this.cboSubnetBits.TabIndex = 0;
            this.cboSubnetBits.TabStop = false;
            this.cboSubnetBits.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboSubnetBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // cboHostBits
            // 
            this.cboHostBits.FormattingEnabled = true;
            this.cboHostBits.Location = new System.Drawing.Point(123, 139);
            this.cboHostBits.Name = "cboHostBits";
            this.cboHostBits.Size = new System.Drawing.Size(100, 21);
            this.cboHostBits.TabIndex = 0;
            this.cboHostBits.TabStop = false;
            this.cboHostBits.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboHostBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // cboMaskBits
            // 
            this.cboMaskBits.FormattingEnabled = true;
            this.cboMaskBits.Location = new System.Drawing.Point(123, 166);
            this.cboMaskBits.Name = "cboMaskBits";
            this.cboMaskBits.Size = new System.Drawing.Size(100, 21);
            this.cboMaskBits.TabIndex = 0;
            this.cboMaskBits.TabStop = false;
            this.cboMaskBits.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboMaskBits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblMaskBits
            // 
            this.lblMaskBits.AutoSize = true;
            this.lblMaskBits.Location = new System.Drawing.Point(61, 169);
            this.lblMaskBits.Name = "lblMaskBits";
            this.lblMaskBits.Size = new System.Drawing.Size(56, 13);
            this.lblMaskBits.TabIndex = 0;
            this.lblMaskBits.Text = "Mask Bits:";
            // 
            // cboMaxSubnets
            // 
            this.cboMaxSubnets.FormattingEnabled = true;
            this.cboMaxSubnets.Location = new System.Drawing.Point(123, 193);
            this.cboMaxSubnets.Name = "cboMaxSubnets";
            this.cboMaxSubnets.Size = new System.Drawing.Size(100, 21);
            this.cboMaxSubnets.TabIndex = 0;
            this.cboMaxSubnets.TabStop = false;
            this.cboMaxSubnets.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboMaxSubnets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblMaximumSubnets
            // 
            this.lblMaximumSubnets.AutoSize = true;
            this.lblMaximumSubnets.Location = new System.Drawing.Point(21, 196);
            this.lblMaximumSubnets.Name = "lblMaximumSubnets";
            this.lblMaximumSubnets.Size = new System.Drawing.Size(96, 13);
            this.lblMaximumSubnets.TabIndex = 0;
            this.lblMaximumSubnets.Text = "Maximum Subnets:";
            // 
            // cboMaxHosts
            // 
            this.cboMaxHosts.FormattingEnabled = true;
            this.cboMaxHosts.Location = new System.Drawing.Point(123, 220);
            this.cboMaxHosts.Name = "cboMaxHosts";
            this.cboMaxHosts.Size = new System.Drawing.Size(100, 21);
            this.cboMaxHosts.TabIndex = 0;
            this.cboMaxHosts.TabStop = false;
            this.cboMaxHosts.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboMaxHosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblHostPerSubnet
            // 
            this.lblHostPerSubnet.AutoSize = true;
            this.lblHostPerSubnet.Location = new System.Drawing.Point(25, 224);
            this.lblHostPerSubnet.Name = "lblHostPerSubnet";
            this.lblHostPerSubnet.Size = new System.Drawing.Size(92, 13);
            this.lblHostPerSubnet.TabIndex = 0;
            this.lblHostPerSubnet.Text = "Hosts per Subnet:";
            // 
            // txtNWAddress
            // 
            this.txtNWAddress.Enabled = false;
            this.txtNWAddress.Location = new System.Drawing.Point(123, 303);
            this.txtNWAddress.Name = "txtNWAddress";
            this.txtNWAddress.Size = new System.Drawing.Size(100, 20);
            this.txtNWAddress.TabIndex = 0;
            this.txtNWAddress.TabStop = false;
            // 
            // lblSubnetInfo
            // 
            this.lblSubnetInfo.AutoSize = true;
            this.lblSubnetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnetInfo.Location = new System.Drawing.Point(8, 279);
            this.lblSubnetInfo.Name = "lblSubnetInfo";
            this.lblSubnetInfo.Size = new System.Drawing.Size(150, 20);
            this.lblSubnetInfo.TabIndex = 0;
            this.lblSubnetInfo.Text = "Subnet Information:";
            // 
            // lblNWAddress
            // 
            this.lblNWAddress.AutoSize = true;
            this.lblNWAddress.Location = new System.Drawing.Point(26, 306);
            this.lblNWAddress.Name = "lblNWAddress";
            this.lblNWAddress.Size = new System.Drawing.Size(91, 13);
            this.lblNWAddress.TabIndex = 0;
            this.lblNWAddress.Text = "Network Address:";
            // 
            // lblBCAddress
            // 
            this.lblBCAddress.AutoSize = true;
            this.lblBCAddress.Location = new System.Drawing.Point(18, 332);
            this.lblBCAddress.Name = "lblBCAddress";
            this.lblBCAddress.Size = new System.Drawing.Size(99, 13);
            this.lblBCAddress.TabIndex = 0;
            this.lblBCAddress.Text = "Broadcast Address:";
            // 
            // lblAddressRange
            // 
            this.lblAddressRange.AutoSize = true;
            this.lblAddressRange.Location = new System.Drawing.Point(34, 385);
            this.lblAddressRange.Name = "lblAddressRange";
            this.lblAddressRange.Size = new System.Drawing.Size(83, 13);
            this.lblAddressRange.TabIndex = 0;
            this.lblAddressRange.Text = "Address Range:";
            // 
            // txtBCAddress
            // 
            this.txtBCAddress.Enabled = false;
            this.txtBCAddress.Location = new System.Drawing.Point(123, 329);
            this.txtBCAddress.Name = "txtBCAddress";
            this.txtBCAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBCAddress.TabIndex = 0;
            this.txtBCAddress.TabStop = false;
            // 
            // txtNWRange
            // 
            this.txtNWRange.Enabled = false;
            this.txtNWRange.Location = new System.Drawing.Point(123, 381);
            this.txtNWRange.Name = "txtNWRange";
            this.txtNWRange.Size = new System.Drawing.Size(256, 20);
            this.txtNWRange.TabIndex = 0;
            this.txtNWRange.TabStop = false;
            // 
            // txtBitmap
            // 
            this.txtBitmap.Enabled = false;
            this.txtBitmap.Location = new System.Drawing.Point(123, 407);
            this.txtBitmap.Name = "txtBitmap";
            this.txtBitmap.Size = new System.Drawing.Size(256, 20);
            this.txtBitmap.TabIndex = 0;
            this.txtBitmap.TabStop = false;
            // 
            // lblBitmap
            // 
            this.lblBitmap.AutoSize = true;
            this.lblBitmap.Location = new System.Drawing.Point(41, 411);
            this.lblBitmap.Name = "lblBitmap";
            this.lblBitmap.Size = new System.Drawing.Size(79, 13);
            this.lblBitmap.TabIndex = 0;
            this.lblBitmap.Text = "Subnet Bitmap:";
            // 
            // lblSubnetError
            // 
            this.lblSubnetError.AutoSize = true;
            this.lblSubnetError.Location = new System.Drawing.Point(257, 250);
            this.lblSubnetError.Name = "lblSubnetError";
            this.lblSubnetError.Size = new System.Drawing.Size(0, 13);
            this.lblSubnetError.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Network Information:";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(123, 59);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(32, 20);
            this.txtIP1.TabIndex = 1;
            this.txtIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP1.TextChanged += new System.EventHandler(this.ComponentUpdate);
            this.txtIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(161, 59);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(32, 20);
            this.txtIP2.TabIndex = 2;
            this.txtIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP2.TextChanged += new System.EventHandler(this.ComponentUpdate);
            this.txtIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // txtIP3
            // 
            this.txtIP3.Location = new System.Drawing.Point(199, 59);
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(32, 20);
            this.txtIP3.TabIndex = 3;
            this.txtIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP3.TextChanged += new System.EventHandler(this.ComponentUpdate);
            this.txtIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // txtIP4
            // 
            this.txtIP4.Location = new System.Drawing.Point(237, 59);
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(32, 20);
            this.txtIP4.TabIndex = 4;
            this.txtIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP4.TextChanged += new System.EventHandler(this.ComponentUpdate);
            this.txtIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblNetworkMask
            // 
            this.lblNetworkMask.AutoSize = true;
            this.lblNetworkMask.Location = new System.Drawing.Point(38, 88);
            this.lblNetworkMask.Name = "lblNetworkMask";
            this.lblNetworkMask.Size = new System.Drawing.Size(79, 13);
            this.lblNetworkMask.TabIndex = 37;
            this.lblNetworkMask.Text = "Network Mask:";
            // 
            // cboNetworkMask
            // 
            this.cboNetworkMask.FormattingEnabled = true;
            this.cboNetworkMask.Items.AddRange(new object[] {
            "255.0.0.0",
            "255.255.0.0",
            "255.255.255.0"});
            this.cboNetworkMask.Location = new System.Drawing.Point(123, 85);
            this.cboNetworkMask.Name = "cboNetworkMask";
            this.cboNetworkMask.Size = new System.Drawing.Size(100, 21);
            this.cboNetworkMask.TabIndex = 0;
            this.cboNetworkMask.TabStop = false;
            this.cboNetworkMask.SelectionChangeCommitted += new System.EventHandler(this.ComponentUpdate);
            this.cboNetworkMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComponentKeyUpdate);
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(47, 358);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(73, 13);
            this.lblSubnetMask.TabIndex = 39;
            this.lblSubnetMask.Text = "Subnet Mask:";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Enabled = false;
            this.txtSubnetMask.Location = new System.Drawing.Point(123, 355);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(100, 20);
            this.txtSubnetMask.TabIndex = 0;
            this.txtSubnetMask.TabStop = false;
            // 
            // txtBCBinary
            // 
            this.txtBCBinary.Enabled = false;
            this.txtBCBinary.Location = new System.Drawing.Point(1, 245);
            this.txtBCBinary.Name = "txtBCBinary";
            this.txtBCBinary.Size = new System.Drawing.Size(230, 20);
            this.txtBCBinary.TabIndex = 0;
            this.txtBCBinary.Text = "10101010 . 10101010 . 11111100 . 10011010";
            this.txtBCBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSNBinary
            // 
            this.txtSNBinary.Enabled = false;
            this.txtSNBinary.Location = new System.Drawing.Point(1, 270);
            this.txtSNBinary.Name = "txtSNBinary";
            this.txtSNBinary.Size = new System.Drawing.Size(230, 20);
            this.txtSNBinary.TabIndex = 0;
            this.txtSNBinary.TabStop = false;
            this.txtSNBinary.Text = "10101010 . 10101010 . 11111100 . 10011010";
            this.txtSNBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 20);
            this.textBox3.TabIndex = 49;
            this.textBox3.Text = "10101010 . 10101010 . 11111100 . 10011010";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtNWMBinary);
            this.panel1.Controls.Add(this.txtSNBBinary);
            this.panel1.Controls.Add(this.txtHBBinary);
            this.panel1.Controls.Add(this.txtMBBinary);
            this.panel1.Controls.Add(this.txtDSNBinary);
            this.panel1.Controls.Add(this.txtNWBinary);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtBCBinary);
            this.panel1.Controls.Add(this.txtSNBinary);
            this.panel1.Location = new System.Drawing.Point(229, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 290);
            this.panel1.TabIndex = 50;
            this.panel1.Visible = false;
            // 
            // txtNWMBinary
            // 
            this.txtNWMBinary.Enabled = false;
            this.txtNWMBinary.Location = new System.Drawing.Point(1, 0);
            this.txtNWMBinary.Name = "txtNWMBinary";
            this.txtNWMBinary.Size = new System.Drawing.Size(230, 20);
            this.txtNWMBinary.TabIndex = 0;
            this.txtNWMBinary.TabStop = false;
            this.txtNWMBinary.Text = "10101010 . 10101010 . 11111100 . 10011010";
            this.txtNWMBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSNBBinary
            // 
            this.txtSNBBinary.Enabled = false;
            this.txtSNBBinary.Location = new System.Drawing.Point(0, 27);
            this.txtSNBBinary.Name = "txtSNBBinary";
            this.txtSNBBinary.Size = new System.Drawing.Size(100, 20);
            this.txtSNBBinary.TabIndex = 0;
            this.txtSNBBinary.TabStop = false;
            this.txtSNBBinary.Text = "11001100";
            this.txtSNBBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHBBinary
            // 
            this.txtHBBinary.Enabled = false;
            this.txtHBBinary.Location = new System.Drawing.Point(0, 54);
            this.txtHBBinary.Name = "txtHBBinary";
            this.txtHBBinary.Size = new System.Drawing.Size(100, 20);
            this.txtHBBinary.TabIndex = 0;
            this.txtHBBinary.TabStop = false;
            this.txtHBBinary.Text = "11001100";
            this.txtHBBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMBBinary
            // 
            this.txtMBBinary.Enabled = false;
            this.txtMBBinary.Location = new System.Drawing.Point(0, 81);
            this.txtMBBinary.Name = "txtMBBinary";
            this.txtMBBinary.Size = new System.Drawing.Size(100, 20);
            this.txtMBBinary.TabIndex = 0;
            this.txtMBBinary.TabStop = false;
            this.txtMBBinary.Text = "11001100";
            this.txtMBBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDSNBinary
            // 
            this.txtDSNBinary.Enabled = false;
            this.txtDSNBinary.Location = new System.Drawing.Point(0, 162);
            this.txtDSNBinary.Name = "txtDSNBinary";
            this.txtDSNBinary.Size = new System.Drawing.Size(100, 20);
            this.txtDSNBinary.TabIndex = 0;
            this.txtDSNBinary.Text = "11001100";
            this.txtDSNBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNWBinary
            // 
            this.txtNWBinary.Enabled = false;
            this.txtNWBinary.Location = new System.Drawing.Point(1, 218);
            this.txtNWBinary.Name = "txtNWBinary";
            this.txtNWBinary.Size = new System.Drawing.Size(230, 20);
            this.txtNWBinary.TabIndex = 0;
            this.txtNWBinary.TabStop = false;
            this.txtNWBinary.Text = "10101010 . 10101010 . 11111100 . 10011010";
            this.txtNWBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(307, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Binary";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.BinaryChecked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.lblSubnetMask);
            this.Controls.Add(this.lblNetworkMask);
            this.Controls.Add(this.cboNetworkMask);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubnetError);
            this.Controls.Add(this.txtBitmap);
            this.Controls.Add(this.lblBitmap);
            this.Controls.Add(this.txtNWRange);
            this.Controls.Add(this.txtBCAddress);
            this.Controls.Add(this.lblAddressRange);
            this.Controls.Add(this.lblBCAddress);
            this.Controls.Add(this.lblNWAddress);
            this.Controls.Add(this.txtNWAddress);
            this.Controls.Add(this.lblSubnetInfo);
            this.Controls.Add(this.cboMaxHosts);
            this.Controls.Add(this.lblHostPerSubnet);
            this.Controls.Add(this.cboMaxSubnets);
            this.Controls.Add(this.lblMaximumSubnets);
            this.Controls.Add(this.cboMaskBits);
            this.Controls.Add(this.lblMaskBits);
            this.Controls.Add(this.cboHostBits);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblHostBits);
            this.Controls.Add(this.cboSubnetBits);
            this.Controls.Add(this.txtDesiredSubnet);
            this.Controls.Add(this.lblDesiredSubnet);
            this.Controls.Add(this.lblSubnetBits);
            this.Controls.Add(this.lblNetworkClass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "FrmMain";
            this.Text = "Ben\'s Subnet Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNetworkClass;
        private System.Windows.Forms.Label lblSubnetBits;
        private System.Windows.Forms.Label lblDesiredSubnet;
        private System.Windows.Forms.TextBox txtDesiredSubnet;
        private System.Windows.Forms.Label lblHostBits;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboSubnetBits;
        private System.Windows.Forms.ComboBox cboHostBits;
        private System.Windows.Forms.ComboBox cboMaskBits;
        private System.Windows.Forms.Label lblMaskBits;
        private System.Windows.Forms.ComboBox cboMaxSubnets;
        private System.Windows.Forms.Label lblMaximumSubnets;
        private System.Windows.Forms.ComboBox cboMaxHosts;
        private System.Windows.Forms.Label lblHostPerSubnet;
        private System.Windows.Forms.TextBox txtNWAddress;
        private System.Windows.Forms.Label lblSubnetInfo;
        private System.Windows.Forms.Label lblNWAddress;
        private System.Windows.Forms.Label lblBCAddress;
        private System.Windows.Forms.Label lblAddressRange;
        private System.Windows.Forms.TextBox txtBCAddress;
        private System.Windows.Forms.TextBox txtNWRange;
        private System.Windows.Forms.TextBox txtBitmap;
        private System.Windows.Forms.Label lblBitmap;
        private System.Windows.Forms.Label lblSubnetError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.Label lblNetworkMask;
        private System.Windows.Forms.ComboBox cboNetworkMask;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.TextBox txtBCBinary;
        private System.Windows.Forms.TextBox txtSNBinary;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNWBinary;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtDSNBinary;
        private System.Windows.Forms.TextBox txtNWMBinary;
        private System.Windows.Forms.TextBox txtSNBBinary;
        private System.Windows.Forms.TextBox txtHBBinary;
        private System.Windows.Forms.TextBox txtMBBinary;
    }
}

