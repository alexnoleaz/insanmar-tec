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

namespace InsanmarTec.WinForms.Views.ProviderMaintainer
{
    public partial class ProviderMaintainer_2 : Form, ITransientDependency
    {
        public ProviderMaintainer_2()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            // Inicializa tu DataGridView aquí
            datGrViProv.Columns.Add("codigoproveedor", "Código Proveedor");
            datGrViProv.Columns.Add("nombrecompleto", "Nombre Completo");
            datGrViProv.Columns.Add("telefono", "Teléfono");
            datGrViProv.Columns.Add("direccion", "Dirección");
            datGrViProv.Columns.Add("ruc", "RUC");
            datGrViProv.Columns.Add("rubro", "Rubro");
            datGrViProv.Columns.Add("razonsocial", "Razón Social");
            datGrViProv.Columns.Add("correoelectronico", "Correo Electrónico");
            datGrViProv.Columns.Add("fecha", "Fecha");

            // Puedes ajustar las propiedades de las columnas según sea necesario, por ejemplo:
            // datGrViProv.Columns["codigoproveedor"].Width = 100;
            // datGrViProv.Columns["nombrecompleto"].Width = 150;
        }

        public void AgregarProveedor(string codigoProveedor, string nombreCompleto, string telefono, string direccion, string ruc, string rubro, string razonSocial, string correoElectronico, DateTime fecha)
        {
            // Agrega una nueva fila al DataGridView con los datos recibidos
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(datGrViProv);
            row.SetValues(codigoProveedor, nombreCompleto, telefono, direccion, ruc, rubro, razonSocial, correoElectronico, fecha.ToString("yyyy-MM-dd"));
            datGrViProv.Rows.Add(row);
        }

        private void datGrViProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
