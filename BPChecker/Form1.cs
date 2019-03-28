using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            int va1 = 0, va2 = 0;
            if (String.IsNullOrEmpty(textBox1.Text))
                label1.Text = "Fill the First Inputs";
            else if (String.IsNullOrEmpty(textBox2.Text))
                label1.Text = "Fill the Second Inputs";
            else
            {
                try
                {
                    va1 = Convert.ToInt32(textBox1.Text);
                    va2 = Convert.ToInt32(textBox2.Text);

                    if (va1 + va2 < 150)
                    {
                        label1.Text = "Hypotension";
                        this.BackColor = Color.LightBlue;
                    }
                    else if (va1 + va2 > 150 && va1 + va2 <= 199)
                    {
                        label1.Text = "Normal";
                        this.BackColor = Color.LightGreen;
                    }
                    else if (va1 + va2 > 200 && va1 + va2 <= 209)
                    {
                        label1.Text = "Elevated";
                        this.BackColor = Color.LightYellow;
                    }
                    else if (va1 + va2 > 210 && va1 + va2 <= 229)
                    {
                        label1.Text = "Stage 1 Hypertension";
                        this.BackColor = Color.Orange;
                    }
                    else if (va1 + va2 > 230 && va1 + va2 <= 299)
                    {
                        label1.Text = "Stage 2 Hypertension";
                        this.BackColor = Color.Red;
                    }
                    else if (va1 + va2 >= 300)
                    {
                        label1.Text = "Hypertensive Crisis";
                        this.BackColor = Color.DarkRed;
                    }
                }
                catch
                {
                    label1.Text = "Feilds have invalid Inputs";
                }
            }
        }
    }
}
