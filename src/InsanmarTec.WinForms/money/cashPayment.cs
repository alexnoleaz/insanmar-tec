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
    public partial class cashPayment : Form
    {
        public cashPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cashPaymentA cash = new cashPaymentA ();
            cash.Show();
        }
    }
}
