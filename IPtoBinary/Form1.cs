using System;
using System.Drawing;
using System.Windows.Forms;

namespace IPtoBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //darkMode();
        }

        int dec;
        int bin;

        //IP boxes
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dec = Convert.ToInt16(textBox1.Text);
                if (dec < 256) textBox5.Text = Convert.ToString(dec, 2).PadLeft(8, '0');
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dec = Convert.ToInt16(textBox2.Text);
                if (dec < 256) textBox6.Text = Convert.ToString(dec, 2).PadLeft(8, '0');
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dec = Convert.ToInt16(textBox3.Text);
                if (dec < 256) textBox7.Text = Convert.ToString(dec, 2).PadLeft(8, '0');
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dec = Convert.ToInt16(textBox4.Text);
                if (dec < 256) textBox8.Text = Convert.ToString(dec, 2).PadLeft(8, '0');
                updateAddrLabels();
            }
            catch { }
        }

        //Binary boxes
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bin = Convert.ToInt16(textBox5.Text, 2);
                textBox1.Text = Convert.ToString(bin, 10);
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bin = Convert.ToInt16(textBox6.Text, 2);
                textBox2.Text = Convert.ToString(bin, 10);
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bin = Convert.ToInt16(textBox7.Text, 2);
                textBox3.Text = Convert.ToString(bin, 10);
                updateAddrLabels();
            }
            catch { }
        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bin = Convert.ToInt16(textBox8.Text, 2);
                textBox4.Text = Convert.ToString(bin, 10);
                updateAddrLabels();
            }
            catch { }
        }

        //subnet mask slider
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = "/" + trackBar1.Value.ToString();

            updateAddrLabels();
        }

        //respond to changes
        private void updateAddrLabels()
        {
            string addr = string.Concat(textBox5.Text.PadLeft(8, '0') + textBox6.Text.PadLeft(8, '0') + textBox7.Text.PadLeft(8, '0') + textBox8.Text.PadLeft(8, '0'));
            char[] netaddr = addr.ToCharArray(), brdAddr = addr.ToCharArray();

            if (addr.Length != 32) return;  //do nothing

            for (int i = 31; i >= trackBar1.Value; i--)
            {
                netaddr[i] = (0).ToString()[0];
                brdAddr[i] = (1).ToString()[0];
            }

            string netStr = new string(netaddr);
            string brdStr = new string(brdAddr);

            netStr = netStr.Insert(8, ".");
            brdStr = brdStr.Insert(8, ".");
            netStr = netStr.Insert(17, ".");
            brdStr = brdStr.Insert(17, ".");
            netStr = netStr.Insert(26, ".");
            brdStr = brdStr.Insert(26, ".");

            //octets
            string[] nOct = netStr.Split('.');
            string[] bOct = brdStr.Split('.');

            try
            {
                netStr = Convert.ToString(Convert.ToByte(nOct[0], 2), 10) + "."
                + Convert.ToString(Convert.ToByte(nOct[1], 2), 10) + "."
                + Convert.ToString(Convert.ToByte(nOct[2], 2), 10) + "."
                + Convert.ToString(Convert.ToByte(nOct[3], 2), 10);

                brdStr = Convert.ToString(Convert.ToByte(bOct[0], 2), 10) + "."
                        + Convert.ToString(Convert.ToByte(bOct[1], 2), 10) + "."
                        + Convert.ToString(Convert.ToByte(bOct[2], 2), 10) + "."
                        + Convert.ToString(Convert.ToByte(bOct[3], 2), 10);
            }
            catch { }

            label9.Text = netStr;
            label10.Text = brdStr;
        }

        public void darkMode()
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

                if (ctl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctl).BorderStyle = BorderStyle.None;
                }

                else if (ctl.GetType() == typeof(Button))
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
