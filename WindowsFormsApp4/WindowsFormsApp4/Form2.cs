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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 anaform1 = new Form3();
        Form4 anaform2 = new Form4();
        Form5 anaform3 = new Form5();

        private void btnkolay_Click(object sender, EventArgs e)
        {
            anaform1.Visible = true;
            this.Hide();
        }
        private void btnorta_Click(object sender, EventArgs e)
        {
            anaform2.Visible = true;
            this.Hide();
        }
        private void btnzor_Click(object sender, EventArgs e)
        {
            anaform3.Visible = true;
            this.Hide();
        }

        
    }
}
