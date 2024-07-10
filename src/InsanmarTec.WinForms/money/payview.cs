using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanmarTec.WinForms.money
{
    public partial class payview : Form
    {
        public payview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payviewA tarjeta = new payviewA();
            tarjeta.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void payview_Load(object sender, EventArgs e)
        {

        }
    }
}
