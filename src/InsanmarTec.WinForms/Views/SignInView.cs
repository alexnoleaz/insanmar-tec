using InsanmarTec.Application.Auth;
using InsanmarTec.Domain.Shared.Dependency;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class SignInView : Form, ITransientDependency
    {
        private readonly SignInHandler _signInHandler;

        public SignInView(SignInHandler signInHandler)
        {
            InitializeComponent();
            _signInHandler = signInHandler;
        }

        private async void SignInOnClick(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowErrorMessage(txtUsername, "Campo obligatorio.");
                return;
            }

            if (txtPassword.Text == string.Empty || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowErrorMessage(txtPassword, "Campo obligatorio.");
                return;
            }

            var signInDto = new SignInDto
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            DisableOrEnableButton(false);
            var result = await _signInHandler.Execute(signInDto);
            if (!result.IsSuccess)
            {
                MessageBox.Show(
                    result.ErrorMessage?.Split(",")[0],
                    null,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                errorProvider.Clear();
                DisableOrEnableButton(true);
                return;
            }

            var user = result.Value;

            DisableOrEnableButton(false);
            MessageBox.Show("Sesión iniciada correctamente");
            errorProvider.Clear();
            DisableOrEnableButton(true);
        }

        private void DisableOrEnableButton(bool state)
        {
            if (!state)
            {
                btnSignIn.Enabled = false;
                btnSignIn.Text = "Iniciando sesión...";
                return;
            }

            btnSignIn.Enabled = true;
            btnSignIn.Text = "Iniciar sesión";
        }

        private void ShowErrorMessage(MaterialTextBox control, string message)
        {
            errorProvider.SetError(control, message);
            errorProvider.Icon = SystemIcons.Warning;
            control.Focus();
        }

        private void InitializeTextBoxes()
        {
            errorProvider.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
