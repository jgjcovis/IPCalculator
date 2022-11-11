using IPCalculator.Core;
using System.Net;

namespace IPCalculatorNS
{
    public partial class IPCalculator : Form
    {
        private readonly INetworkInfoCalculator calculatorCore;
        private readonly IIPConverter converter;

        public IPCalculator()
        {
            this.converter = new IPConverter();
            this.calculatorCore = new NetworkInfoCalculator(converter);
            InitializeComponent();
            DarkMode();
        }

        //IP boxes
        private void ipTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBinaryTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void ipTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBinaryTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void ipTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBinaryTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void ipTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBinaryTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        //Binary boxes
        private void binaryTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIPTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void binaryTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIPTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void binaryTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIPTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        private void binaryTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIPTextBoxes();
            UpdateNetworkBroadcastLabels();
        }

        //subnet mask slider
        private void subnetSlider_Scroll(object sender, EventArgs e)
        {
            subnetSuffixLabel.Text = "/" + subnetSlider.Value.ToString();
            UpdateNetworkBroadcastLabels();
        }

        private void UpdateBinaryTextBoxes()
        {
            string ipAddress = String.Join(".", ipTextBox1.Text, ipTextBox2.Text, ipTextBox3.Text, ipTextBox4.Text);
            if (IPAddress.TryParse(ipAddress, out _))
            {
                string[] octets = this.converter.ToBinary(ipAddress).Split(".");

                binaryTextBox1.Text = octets[0];
                binaryTextBox2.Text = octets[1];
                binaryTextBox3.Text = octets[2];
                binaryTextBox4.Text = octets[3];
            }
        }

        private void UpdateIPTextBoxes()
        {
            string binaryIPAddress = String.Join(".", binaryTextBox1.Text, binaryTextBox2.Text, binaryTextBox3.Text, binaryTextBox4.Text);
            string noDots = string.Join("", binaryIPAddress.Split("."));
            if (System.Text.RegularExpressions.Regex.IsMatch(noDots, "^[01]{32}$"))
            {
                string[] segments = converter.ToIP(binaryIPAddress).Split(".");

                ipTextBox1.Text = segments[0];
                ipTextBox2.Text = segments[1];
                ipTextBox3.Text = segments[2];
                ipTextBox4.Text = segments[3];
            }
        }

        private void UpdateNetworkBroadcastLabels()
        {
            string ipAddress = String.Join(".", ipTextBox1.Text, ipTextBox2.Text, ipTextBox3.Text, ipTextBox4.Text);
            if (IPAddress.TryParse(ipAddress, out IPAddress? ip))
            {
                NetworkInfo addresses = calculatorCore.Calculate(ipAddress, subnetSlider.Value);

                this.networkInfoBindingSource.DataSource = addresses;

            }
        }

        private void DarkMode()
        {
            Color darkgray = Color.FromArgb(45, 45, 48);
            Color lightgray = Color.FromArgb(62, 62, 66);
            Color textcolor = Color.FromArgb(241, 241, 241);

            this.BackColor = darkgray;

            foreach (Control ctl in Controls)
            {
                ctl.BackColor = lightgray;
                ctl.ForeColor = textcolor;
                //ctl.Font = new Font("Consolas", 8.25f, FontStyle.Regular);

                if (ctl is TextBox)
                {
                    ((TextBox)ctl).BorderStyle = BorderStyle.None;
                }

                else if (ctl is Button)
                {
                    ((Button)ctl).FlatStyle = FlatStyle.Flat;
                    ((Button)ctl).FlatAppearance.BorderSize = 0;
                }

                else
                {
                    ctl.BackColor = darkgray;
                }
            }
        }
    }
}
