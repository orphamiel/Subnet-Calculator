using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnet_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bit1.Focus();
            outputbox.Text = "Welcome to Orphamiel's Subnet Calculator!\n\n" ;
            outputbox.Text += "Enter your values above and related information will be automatically generated here.";
            outputbox.Text += "\n\n\n\nIf you encounter any bugs, please send a report to orphamiel@yahoo.com";
        }

        private void bit1_TextChanged(object sender, EventArgs e)
        {
            if (bit1.Text.Length >= 3)
            {
                bit2.Focus();
            }
            int bit1int = 0;
            try
            {
                bit1int = int.Parse(bit1.Text);
            }
            catch (System.Exception excep)
            {
                bit1.Text = "";
                bit1.Select(bit1.Text.Length, 0);
            }
            if (bit1int >= 256)
            {
                bit1.Text = "255";
                bit2.Focus();
            }
            calcul();
        }

        private void bit2_TextChanged(object sender, EventArgs e)
        {
            if (bit2.Text.Length >= 3)
            {
                bit3.Focus();
            }
            int bit2int = 0;
            try
            {
                bit2int = int.Parse(bit2.Text);
            }
            catch (System.Exception excep)
            {
                bit2.Text = "";
            }
            if (bit2int >= 256)
            {
                bit2.Text = "255";
                bit3.Focus();
            }
            calcul();
        }

        private void bit3_TextChanged(object sender, EventArgs e)
        {
            if (bit3.Text.Length >= 3)
            {
                bit4.Focus();
            }
            int bit3int = 0;
            try
            {
                bit3int = int.Parse(bit3.Text);
            }
            catch (System.Exception excep)
            {
                bit3.Text = "";
            }
            if (bit3int >= 256)
            {
                bit3.Text = "255";
                bit4.Focus();
            }
            calcul();
        }

        private void bit4_TextChanged(object sender, EventArgs e)
        {
            if (bit4.Text.Length >= 3)
            {
                subnetbit.Focus();
            }
            int bit4int = 0;
            try
            {
                bit4int = int.Parse(bit4.Text);
            }
            catch (System.Exception excep)
            {
                bit4.Text = "";
            }
            if (bit4int >= 256)
            {
                bit4.Text = "255";
                subnetbit.Select(0, 0);
            }
            calcul();
        }

        private void subnetbit_TextChanged(object sender, EventArgs e)
        {
            int subint = 0;
            try
            {
                subint = int.Parse(subnetbit.Text);
            }
            catch (System.Exception excep)
            {
                subnetbit.Text = "";
            }
            if (subint >= 31)
            {
                subnetbit.Text = "31";
                subnetbit.Select(subnetbit.Text.Length, 0);
            }
            calcul();
        }

        private void calcul()
        {
            //Start getting results from textboxes
            int bit1int, bit2int, bit3int, bit4int, subint;
            try
            {
                bit1int = int.Parse(bit1.Text);
            }
            catch
            {
                //if fail or empty make it 0
                bit1int = 0;
            }
            try
            {
                bit2int = int.Parse(bit2.Text);
            }
            catch
            {
                bit2int = 0;
            }
            try
            {
                bit3int = int.Parse(bit3.Text);
            }
            catch
            {
                bit3int = 0;
            }
            try
            {
                bit4int = int.Parse(bit4.Text);
            }
            catch
            {
                bit4int = 0;
            }
            try
            {
                subint = int.Parse(subnetbit.Text);
            }
            catch
            {
                subint = 0;
            }
            // End of getting all results - Make output textbox empty first
            outputbox.Text = "";
            int sub1 = 0;
            int netid = 256;
            int track = -1;
            int tempint = 1;
            //Do calculations here
            if (subint == 0)
            {
                bit1int = 0;
                bit2int = 0;
                bit3int = 0;
                bit4int = 0;
            }
            else if (subint < 8)
            {
                for (int temp = 0; temp < subint; temp++)
                {
                    tempint *= 2;
                }
                sub1 = (256 / tempint);
                while (bit1int < netid)
                {
                    netid -= sub1;
                    track++;
                }
                bit1int = netid;
                bit2int = 0;
                bit3int = 0;
                bit4int = 0;
            }
            else if (subint < 16)
            {
                int tempsubnet = subint - 8;
                for (int temp = 0; temp < tempsubnet; temp++)
                {
                    tempint *= 2;
                }
                sub1 = (256 / tempint);
                while (bit2int < netid)
                {
                    netid -= sub1;
                    track++;
                }
                bit2int = netid;
                bit3int = 0;
                bit4int = 0;
            }
            else if (subint < 24)
            {
                int tempsubnet = subint - 16;
                for (int temp = 0; temp < tempsubnet; temp++)
                {
                    tempint *= 2;
                }
                sub1 = (256 / tempint);
                while (bit3int < netid)
                {
                    netid -= sub1;
                    track++;
                }
                bit3int = netid;
                bit4int = 0;
            }
            else if (subint < 32)
            {
                int tempsubnet = subint - 24;
                for (int temp = 0; temp < tempsubnet; temp++)
                {
                    tempint *= 2;
                }
                sub1 = (256 / tempint);
                while (bit4int < netid)
                {
                    netid -= sub1;
                    track++;
                }
                bit4int = netid;
            }
            else
            {
                //error catching
                bit1int = 999;
                bit2int = 999;
                bit3int = 999;
                bit4int = 999;
            }
            //Output information from calculations
            outputbox.Text = "Network Address is : " + bit1int + "." + bit2int + ".";
            outputbox.Text += "" + bit3int + "." + bit4int + "\n";
            if (subint == 0)
            {
                outputbox.Text += "1st Host Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + ".1" + "\n";
                outputbox.Text += "Broadcast Address is : 255.255.255.255";
                outputbox.Text += "\n \nSubnet Mask is : 0.0.0.0";
                outputbox.Text += "\nWildcard Mask is : 255.255.255.255";
                outputbox.Text += "\n \n" + "Total hosts avaliable : 4294967294";
            }
            else if (subint < 8)
            {
                //something is wrong here. the values are always wrong
                outputbox.Text += "1st Host Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + ".1" + "\n";
                int bit1temp = 256-(track*sub1)-1;
                outputbox.Text += "Broadcast Address is : " + bit1temp ;
                outputbox.Text += ".255.255.255";
                int wildint = sub1 - 1;
                int bit1invert = 256 - wildint - 1;
                outputbox.Text += "\n \nSubnet Mask is : " + bit1invert + ".0.0.0";
                outputbox.Text += "\nWildcard Mask is : "+ wildint +".255.255.255";
                sub1 *= 256 * 256 *256;
                sub1 = sub1 - 2;
                outputbox.Text += "\n \n" + "Total hosts avaliable : " + sub1;
            }
            else if (subint < 16)
            {
                outputbox.Text += "1st Host Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + ".1" + "\n";
                int bit2temp = 256 - (track * sub1) - 1;
                outputbox.Text += "Broadcast Address is : " + bit1int + ".";
                outputbox.Text += bit2temp + ".255.255";
                int wildint = sub1 - 1;
                int bit2invert = 256 - wildint - 1;
                outputbox.Text += "\n \nSubnet Mask is : 255." + bit2invert + ".0.0";
                outputbox.Text += "\nWildcard Mask is : 0." + wildint + ".255.255";
                sub1 *= 256 * 256;
                sub1 = sub1 - 2;
                outputbox.Text += "\n \n" + "Total hosts avaliable : " + sub1;
            }
            else if (subint < 24)
            {
                outputbox.Text += "1st Host Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + ".1" + "\n";
                int bit3temp = 256 - (track * sub1) - 1;
                outputbox.Text += "Broadcast Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3temp + ".255";
                int wildint = sub1 - 1;
                int bit3invert = 256 - wildint - 1;
                outputbox.Text += "\n \nSubnet Mask is : 255.255." + bit3invert + ".0";
                outputbox.Text += "\nWildcard Mask is : 0.0." + wildint + ".255";
                sub1 *= 256;
                sub1 = sub1 - 2;
                outputbox.Text += "\n\n" + "Total hosts avaliable : " + sub1;
            }
            else if (subint < 32)
            {
                bit4int++;
                outputbox.Text += "1st Host Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + "." + bit4int + "\n";
                int bit4temp = 256 - (track * sub1) - 1;
                outputbox.Text += "Broadcast Address is : " + bit1int + "." + bit2int;
                outputbox.Text += "." + bit3int + "." + bit4temp;
                int wildint = sub1 - 1;
                int bit4invert = 256 - wildint - 1;
                outputbox.Text += "\n\nSubnet Mask is : 255.255.255." + bit4invert;                
                outputbox.Text += "\nWildcard Mask is : 0.0.0." + wildint;
                sub1 = sub1 - 2;
                outputbox.Text += "\n\n" + "Total hosts avaliable : " + sub1;
            }
            else
            {
                outputbox.Text = "Error encounered!";
            }

        }
    }
}
