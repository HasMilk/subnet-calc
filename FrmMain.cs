using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnet_Calculator
{
    public partial class FrmMain : Form
    {
        private char Class = 'A';
        private int[] IP = { 10, 0, 0, 1 };
        private int[] NetworkMask = { 255, 0, 0, 0 };
        private int NetworkBits;
        private int SubnetBits = 0;
        private int MaskBits;
        private int HostBits;
        private int MaximumSubnets;
        private int MaximumHosts;
        private int DesiredSubnet = 0;

        private int[] NetworkAddress = new int[4];
        private int[] BroadcastAddress = new int[4];
        private int[] SubnetMask = new int[4];
        private int[] FirstAddress = new int[4];
        private int[] LastAddress = new int[4];
        private String Bitmap;
        private String[] SubnetMasks = { 
                "255.0.0.0", "255.128.0.0", "255.192.0.0", "255.224.0.0", "255.240.0.0", "255.248.0.0", "255.252.0.0", "255.254.0.0",
                "255.255.0.0", "255.255.128.0", "255.255.192.0", "255.255.224.0", "255.255.240.0", "255.255.248.0", "255.255.252.0",  "255.255.254.0",
                "255.255.255.0", "255.255.255.128", "255.255.255.192", "255.255.255.224", "255.255.255.240", "255.255.255.248", "255.255.255.252", "255.255.255.254"
        };

        public FrmMain()
        {
            InitializeComponent();
            Calculate();
            PopulateComponents();
        }

        private void PopulateComponents()
        {
            cboClass.Text = Convert.ToString(Class);

            txtIP1.Text = Convert.ToString(IP[0]);
            txtIP2.Text = Convert.ToString(IP[1]);
            txtIP3.Text = Convert.ToString(IP[2]);
            txtIP4.Text = Convert.ToString(IP[3]);

            cboNetworkMask.Text = DottedDecimal(NetworkMask);
            txtNWMBinary.Text = To8BitBinary(NetworkMask);

            cboSubnetBits.Items.Clear();
            foreach (int item in Enumerable.Range(0, 31 - NetworkBits).ToArray())
                cboSubnetBits.Items.Add(item);
            cboSubnetBits.Text = Convert.ToString(SubnetBits);
            txtSNBBinary.Text = To8BitBinary(SubnetBits);

            cboHostBits.Items.Clear();
            foreach (int item in Enumerable.Range(2, 31 - NetworkBits).ToArray())
                cboHostBits.Items.Insert(0, item);
            cboHostBits.Text = Convert.ToString(HostBits);
            txtHBBinary.Text = To8BitBinary(HostBits);

            cboMaskBits.Items.Clear();
            foreach (int item in Enumerable.Range(NetworkBits, 31 - NetworkBits).ToArray())
                cboMaskBits.Items.Add(item);
            cboMaskBits.Text = Convert.ToString(MaskBits);
            txtMBBinary.Text = To8BitBinary(MaskBits);

            cboMaxSubnets.Items.Clear();
            foreach (int item in Enumerable.Range(0, 31 - NetworkBits).ToArray())
                cboMaxSubnets.Items.Add(Math.Pow(2, item));
            cboMaxSubnets.Text = Convert.ToString(MaximumSubnets);

            cboMaxHosts.Items.Clear();
            foreach (int item in Enumerable.Range(2, 31 - NetworkBits).ToArray())
                cboMaxHosts.Items.Insert(0, Math.Pow(2, item) - 2);
            cboMaxHosts.Text = Convert.ToString(MaximumHosts);

            txtDesiredSubnet.Text = Convert.ToString(DesiredSubnet);
            txtDSNBinary.Text = To8BitBinary(DesiredSubnet);

            txtNWAddress.Text = DottedDecimal(NetworkAddress);
            txtNWBinary.Text = To8BitBinary(NetworkAddress);

            txtBCAddress.Text = DottedDecimal(BroadcastAddress);
            txtBCBinary.Text = To8BitBinary(BroadcastAddress);

            txtSubnetMask.Text = SubnetMasks[NetworkBits + SubnetBits - 8];
            txtNWRange.Text = DottedDecimal(FirstAddress) + " - " + DottedDecimal(LastAddress);
            txtBitmap.Text = Bitmap;
        }

        private void Calculate()
        {
            String IPBinary = AddressToBinary(IP);
            String NetworkMaskBinary = AddressToBinary(NetworkMask);

            NetworkBits = NetworkMaskBinary.IndexOf('0');
            MaskBits = NetworkBits + SubnetBits;
            HostBits = 32 - MaskBits;

            MaximumSubnets = (int) Math.Pow(2, SubnetBits);
            MaximumHosts = (int) Math.Pow(2, HostBits) - 2;

            DesiredSubnet = DesiredSubnet > MaximumSubnets ? MaximumSubnets - 1 : DesiredSubnet;

            String DesiredSubnetBinary = "";
            if (SubnetBits > 0)
            {
                String s = IntToBinary(DesiredSubnet);
                if (s.Length > SubnetBits)
                    s = "0";
                s = String.Concat(Enumerable.Repeat("0", SubnetBits - s.Length));
                DesiredSubnetBinary = s + IntToBinary(DesiredSubnet);
            }

            String NetworkBinary = IPBinary.Substring(0, NetworkBits);
            String BroadcastBinary = NetworkBinary;

            NetworkBinary += DesiredSubnetBinary;
            BroadcastBinary += DesiredSubnetBinary;

            NetworkBinary += String.Concat(Enumerable.Repeat("0", HostBits));
            BroadcastBinary += String.Concat(Enumerable.Repeat("1", HostBits));

            NetworkAddress = BinaryToArray(NetworkBinary);
            BroadcastAddress = BinaryToArray(BroadcastBinary);

            FirstAddress = BinaryToArray(NetworkBinary.Substring(0, 31) + "1");
            LastAddress = BinaryToArray(BroadcastBinary.Substring(0, 31) + "0");

            SetBitmap();

        }

        private void ComponentKeyUpdate(object sender, KeyPressEventArgs e)
        {
            if (((Control)sender).Name.StartsWith("txt") && ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8))
                return;
            else
                e.Handled = true;
        }

        private void ComponentUpdate(object sender, EventArgs e)
        {
            UpdateValues(sender, e);
        }

        private void UpdateValues(object sender, EventArgs e)
        {
            Control control = ((Control)sender);
            if (control.Text == "")
                return;

            // Class / Network Mask
            if (control == cboClass || control == cboNetworkMask)
            {
                int index = control == cboClass ? cboClass.SelectedIndex : cboNetworkMask.SelectedIndex;
                Console.WriteLine(control.Name + ", index: " + index);
                switch (index)
                {
                    case 0:
                        Class = 'A';
                        NetworkMask = new int[] { 255, 0, 0, 0 };
                        break;
                    case 1:
                        Class = 'B';
                        NetworkMask = new int[] { 255, 255, 0, 0 };
                        break;
                    case 2:
                        Class = 'C';
                        NetworkMask = new int[] { 255, 255, 255, 0 };
                        break;
                }
                SubnetBits = 0;
                cboClass.Text = Convert.ToString(Class);
                cboNetworkMask.Text = DottedDecimal(NetworkMask);
                cboSubnetBits.Text = "0";
            }

            // IP Address
            if (control.Name.StartsWith("txtIP"))
            {
                int index = Convert.ToInt32(control.Name.Substring(5, 1));
                int value = Convert.ToInt32(control.Text);
                IP[index - 1] = (value > 255 ? 255 : value);
            }

            // Network Mask
            if (control.Name.Equals("cboNetworkMask"))
            {
                Object[] values = cboNetworkMask.Text.Split('.');
                for (int i = 0; i < values.Length; i++)
                {
                    NetworkMask[i] = Convert.ToInt32(values[i]);
                }
                SetMaskFromBits();
            }

            // Subnet Bits
            if (control == cboSubnetBits)
            {
                SubnetBits = Convert.ToInt32(cboSubnetBits.SelectedItem);
                MaskBits = NetworkBits + SubnetBits;
                HostBits = 32 - MaskBits;
                SetMaskFromBits();
            }

            // Host Bits
            if (control == cboHostBits)
            {
                HostBits = Convert.ToInt32(cboHostBits.SelectedItem);
                MaskBits = 32 - HostBits;
                SubnetBits = MaskBits - NetworkBits;
                SetMaskFromBits();
            }

            // Mask Bits
            if (control == cboMaskBits)
            {
                MaskBits = Convert.ToInt32(cboMaskBits.SelectedItem);
                HostBits = 32 - MaskBits;
                SubnetBits = MaskBits - NetworkBits;
                SetMaskFromBits();
            }

            //Max Subnets
            if (sender.Equals(cboMaxSubnets))
            {
                double value = Convert.ToDouble(cboMaxSubnets.SelectedItem);
                SubnetBits = Convert.ToInt32(Math.Log(value, 2));
                MaskBits = NetworkBits + SubnetBits;
                HostBits = 32 - MaskBits;
                SetMaskFromBits();
            }

            // Max Hosts
            if (sender.Equals(cboMaxHosts))
            {
                double value = Convert.ToDouble(cboMaxHosts.SelectedItem);
                HostBits = Convert.ToInt32(Math.Log(value + 2, 2));
                MaskBits = 32 - HostBits;
                SubnetBits = MaskBits - NetworkBits;
                SetMaskFromBits();
            }

            // Desired Subnet
            if (sender.Equals(txtDesiredSubnet))
            {
                int value = Convert.ToInt32(txtDesiredSubnet.Text);
                DesiredSubnet = value >= MaximumSubnets ? MaximumSubnets - 1 : value;
            }

            Calculate();
            PopulateComponents();
        }

        private void BinaryChecked(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void SetMaskFromBits()
        {
            String SubnetBinary = "";
            SubnetBinary += String.Concat(Enumerable.Repeat('1', MaskBits));
            SubnetBinary += String.Concat(Enumerable.Repeat('0', HostBits));
            SubnetMask = BinaryToArray(SubnetBinary);
        }

        private void SetBitmap()
        {
            String MapString = "";
            MapString += String.Concat(Enumerable.Repeat('n', NetworkBits));
            MapString += String.Concat(Enumerable.Repeat('s', SubnetBits));
            MapString += String.Concat(Enumerable.Repeat('h', HostBits));
            for (int i = 0; i < 3; i++)
            {
                MapString = MapString.Substring(0, i * 9 + 8) + "." + MapString.Substring(i * 9 + 8);
            }
            Bitmap = MapString;
        }

        private String IntToBinary(int value)
        {
            return Convert.ToString(value, 2);
        }

        private int BinaryToInt(String value)
        {
            return Convert.ToInt32(value, 2);
        }

        private String AddressToBinary(int[] values)
        {
            String binary = "", s = "";
            foreach (int value in values)
            {
                s = IntToBinary(value);
                binary += String.Concat(Enumerable.Repeat("0", 8 - s.Length));
                binary += s;
            }
            return binary;
        }

        private int[] BinaryToArray(String s)
        {
            int[] values = new int[4];
            for (int i = 0; i < 4; i++)
            {
                values[i] = BinaryToInt(s.Substring(i * 8, 8));
            }
            return values;
        }

        private String DottedDecimal(int[] values)
        {
            String s = "";
            foreach (int value in values)
                s += "." + value;
            return s.Substring(1);
        }

        private String To8BitBinary(int[] values)
        {
            String binary = "", s = "";
            foreach (int value in values)
                binary += " . " + To8BitBinary(value);
            return binary.Substring(3);
        }

        private String To8BitBinary(int value)
        {
            String binary = "", s = "";
            s = Convert.ToString(value, 2);
            binary += String.Concat(Enumerable.Repeat("0", 8 - s.Length));
            binary += s;
            return binary;
        }

    }
}
