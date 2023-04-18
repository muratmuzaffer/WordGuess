using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form7 : Form
    {
        private int sayac = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==1)
            {
                panel1.Visible = false;
                panel2.Visible = true;

            }
            else if (sayac==2)
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else if (sayac==3)
            {
                panel3.Visible = false;
                panel1.Visible = true;
                sayac = 0;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
