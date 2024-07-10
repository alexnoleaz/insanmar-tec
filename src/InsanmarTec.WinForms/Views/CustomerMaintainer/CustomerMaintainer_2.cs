using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanmarTec.WinForms.Views.CustomerMaintainer
{
    public partial class CustomerMaintainer_2 : Form
    {
        public CustomerMaintainer_2()
        {
            InitializeComponent();
        }

        private void datGrViCLI2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Método para agregar datos al DataGridView
        public void AddCustomerData(string dni, string nombreCompleto, string telefono1, string telefonoAdicional, string direccion, string tipoCliente, string correoElectronico, DateTime fechaNacimiento, DateTime fechaCumple)
        {
            datGrViCLI2.Rows.Add(dni, nombreCompleto, telefono1, telefonoAdicional, direccion, tipoCliente, correoElectronico, fechaNacimiento.ToShortDateString(), fechaCumple.ToShortDateString());
        }
    }
}
