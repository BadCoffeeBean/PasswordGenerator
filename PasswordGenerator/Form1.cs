/*
 *  This program allows you to generate password of varying lengths and complexity based on your preference/constraints. 
    As a general rule, always remember to store your password in a place away from hackers or malware as this program does not       guarantee total security from using the obtained password in ANY accounts you use.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PasswordProcessor;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        PasswordProcesses pp = new PasswordProcesses();
        String characters;
        public Form1()
        {
            foreach (Control c in Controls) //fix OS-specific fonts
            {
                c.Font = SystemFonts.MessageBoxFont;
            }
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            characters = ""; // avoids concatenation and forgetfulness

            //check if all options are unchecked or special is checked but no input
            if ((chkLower.Checked == false && chkNum.Checked == false && chkSpecial.Checked == false && chkUpper.Checked == false) || (chkSpecial.Checked && txtSpecial.Text==""))
            {
                MessageBox.Show("Please select at least one constraint or specify characters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Text = "";
            }
                
            else
            {
                //for each time checkboxes are activated, the following characters are added into the caharcter set
                if (chkUpper.Checked)
                    characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (chkLower.Checked)
                    characters += "abcdefghijklmnopqrstuvwxyz";
                if (chkNum.Checked)
                    characters += "0123456789";
                if (chkSpecial.Checked && txtSpecial.Text != "")
                {
                    //using regex here to cut out duplicate special characters (does not remove if recurring at the end or in between)
                    //source: http://stackoverflow.com/a/4430886/2557753
                    Regex r = new Regex("(.)(?<=\\1\\1)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);

                    var x = r.Replace(txtSpecial.Text, String.Empty);
                    characters += x;
                }
                    
                txtPass.Text = pp.createPassword(characters, (int)nudCharCount.Value);
            }

        }

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecial.Checked)
                txtSpecial.Enabled = true;
            else
            {
                txtSpecial.Enabled = false;
                txtSpecial.Text = ""; // clears the textbox if unchecked
            }
                
            
        }

        private void btnCalculateCombi_Click(object sender, EventArgs e)
        {
            if (txtSpecial.Text == "" && chkSpecial.Checked) //empty string
                MessageBox.Show("Please input at least one special character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!chkSpecial.Checked) //if unchecked, then length is 0
                txtCombi.Text = pp.getCombinationsCount(chkUpper.Checked, chkLower.Checked, chkNum.Checked, 0, (long)nudCharCount.Value);
            else
                txtCombi.Text = pp.getCombinationsCount(chkUpper.Checked, chkLower.Checked, chkNum.Checked, (long)txtSpecial.Text.Length, (long)nudCharCount.Value);
        }
    }
}
