using InsanmarTec.Domain.Shared.Dependency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanmarTec.WinForms.Views
{
    public partial class Form1 : Form, ITransientDependency
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
