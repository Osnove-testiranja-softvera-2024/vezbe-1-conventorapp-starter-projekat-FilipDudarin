using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Pounds";
            lbl2.Text = "Kilograms";

        }

        private void rBtn2_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Feets";
            lbl2.Text = "Meters";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked)
            {
                double a = Convert.ToInt32(txtBox1.Text);
                double b = (double)(a * 0.45359237);
                b = Math.Round(b, 3);
                txtBox2.Text = b.ToString();
            }
            else {
                double a = Convert.ToInt32(txtBox1.Text);
                double b = (double)(a * 0.3048);
                b = Math.Round(b, 3);
                txtBox2.Text = b.ToString();
            }
        }
    }
}
