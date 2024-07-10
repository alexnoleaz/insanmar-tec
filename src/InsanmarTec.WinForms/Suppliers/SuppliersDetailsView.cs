using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Views
{
    public partial class SuppliersDetailsView : Form, ITransientDependency
    {
        private DateTime fechaSeleccionada;


        public SuppliersDetailsView()
        {
            InitializeComponent();
        }

        private void ProviderMaintainer_Load(object sender, EventArgs e)
        {

        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de enviarlos
            if (!ValidarDatos())
            {
                return; // Si los datos no son válidos, no hacemos nada
            }

            // Obtener los valores de los campos

            // Si no se ha creado la instancia de ProviderMaintainer_2, la creamos

            // Agregar proveedor al formulario ProviderMaintainer_2

            // Limpiar campos después de grabar
            LimpiarCampos();
        }

        private bool ValidarDatos()
        {
            // Implementa tu lógica de validación aquí
            // Por ejemplo, asegúrate de que los campos obligatorios estén completos y sean válidos
            // Retorna true si los datos son válidos, false si no lo son
            // Aquí puedes agregar tu lógica de validación específica
            return true;
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los TextBox y ComboBox

            // Limpiar fecha seleccionada
            fechaSeleccionada = DateTime.MinValue; // o cualquier valor inicial que prefieras
        }

        private void telef_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!IsNumeric(textBox.Text))
            {
                MessageBox.Show("Error: ¡Solo se permiten números!", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpiar el campo y colocar el cursor al inicio
                textBox.Text = "";
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
            }
        }

        private void ruc1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!IsNumeric(textBox.Text))
            {
                MessageBox.Show("Error: ¡Solo se permiten números!", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpiar el campo y colocar el cursor al inicio
                textBox.Text = "";
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
            }

        }

        private void codprov_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!IsNumeric(textBox.Text))
            {
                MessageBox.Show("Error: ¡Solo se permiten números!", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpiar el campo y colocar el cursor al inicio
                textBox.Text = "";
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
            }
        }

        private void nomcomp_TextChanged(object sender, EventArgs e)
        {

        }

        private void direc_TextChanged(object sender, EventArgs e)
        {

        }

        private void rubro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void razsoci_TextChanged(object sender, EventArgs e)
        {

        }

        private void corelec_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void datTimPickProv_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
