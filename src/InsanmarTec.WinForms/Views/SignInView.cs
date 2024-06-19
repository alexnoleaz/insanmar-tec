using InsanmarTec.Application.Auth;
using InsanmarTec.Domain.Shared.Dependency;

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
            var signInDto = new SignInDto
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            var result = await _signInHandler.Execute(signInDto);
            if (!result.IsSuccess)
            {
                MessageBox.Show(
                    result.ErrorMessage?.Split(",")[0],
                    null,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var user = result.Value;
            DisableOrEnableButton(false);
            await Task.Delay(1000);
            MessageBox.Show("Iniciado correctamente");
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
    }
}
