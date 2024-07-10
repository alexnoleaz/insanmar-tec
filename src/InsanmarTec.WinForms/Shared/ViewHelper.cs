using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Shared
{
    public class ViewHelper
    {
        public static void OpenChildForm(TabPage containerChildForm, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            containerChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        public static void ShowErrorMessage(
            MaterialTextBox input,
            ErrorProvider errorProvider,
            string message = "Campo obligatorio."
        )
        {
            errorProvider.SetError(input, message);
            errorProvider.Icon = SystemIcons.Warning;
            input.Focus();
        }

        public static void ShowErrorMessage(string? message) =>
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void ClearInputs(
            ErrorProvider errorProvider,
            IEnumerable<MaterialTextBox>? textBoxes = default
        )
        {
            errorProvider.Clear();
            if (textBoxes is not null)
                foreach (var input in textBoxes)
                    input.Clear();
        }
    }
}
