using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Views
{
    public partial class CustomersDetailsView : Form, ITransientDependency
    {
        private ToolTip toolTip;

        public CustomersDetailsView()
        {
            InitializeComponent();

            // Inicializar ToolTip
            toolTip = new ToolTip();

        }

        private void BTNGRABAR_Click(object sender, EventArgs e)
        {            // Capturar los datos de los controles


            // Mostrar o crear el formulario CustomerMaintainer_2 si no está inicializado

            // Pasar los datos al DataGridView en CustomerMaintainer_2

            // Limpiar los controles del formulario CustomerMaintainer_1
            LimpiarControles();
        }

        private void LimpiarControles()
        {
        }

        private void DNI1_TextChanged(object sender, EventArgs e)
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

        private void NOMCOMP_TextChanged(object sender, EventArgs e)
        {
        }

        private void TELE1_TextChanged(object sender, EventArgs e)
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

        private void TELEADI_TextChanged(object sender, EventArgs e)
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

        private void DIREC_TextChanged(object sender, EventArgs e)
        {
        }

        private void datTiPickCUM_ValueChanged(object sender, EventArgs e)
        {
        }

        private void CORELEC_TextChanged(object sender, EventArgs e)
        {
        }

        private void datTiPickFECH_ValueChanged(object sender, EventArgs e)
        {
        }

        private void CMBTIPCLI_SelectedIndexChanged(object sender, EventArgs e)
        {// Lógica a ejecutar cuando se cambie la selección


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
    }


}
