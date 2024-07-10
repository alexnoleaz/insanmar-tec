using InsanmarTec.Application.Auth;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Shared;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace InsanmarTec.WinForms.Views
{
    public partial class SignInView : Form, ITransientDependency
    {
        private readonly SignInHandler _signInHandler;
        private readonly IServiceProvider _container;

        public SignInView(SignInHandler signInHandler, IServiceProvider container)
        {
            InitializeComponent();
            _signInHandler = signInHandler;
            _container = container;
        }

        private async void SignInOnClick(object sender, EventArgs e)
        {
            ViewHelper.ClearInputs(errorProvider);

            if (txtUsername.Text == string.Empty || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ViewHelper.ShowErrorMessage(txtUsername, errorProvider);
                return;
            }

            if (txtPassword.Text == string.Empty || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ViewHelper.ShowErrorMessage(txtPassword, errorProvider);
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
                ShowErrorMessage("Nombre de usuario o contraseña incorrecta.");
                ViewHelper.ClearInputs(errorProvider, [txtPassword]);
                DisableOrEnableButton(true);
                return;
            }

            var user = result.Value;
            DisableOrEnableButton(false);

            var mainView = _container.GetRequiredService<MainView>();
            mainView.User = user!;

            Hide();
            if (mainView.ShowDialog() is DialogResult.Cancel)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }

            Show();
            ViewHelper.ClearInputs(errorProvider, [txtUsername, txtPassword]);
            txtUsername.Focus();
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

        private void ShowErrorMessage(string message) => lblMessage.Text = message;
    }
}
