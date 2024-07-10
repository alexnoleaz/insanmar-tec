using InsanmarTec.Application.Users.Dtos;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Shared;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class MainView : MaterialForm, ITransientDependency
    {
        private UserDto _user = null!;
        private readonly InventoryView _inventoryView;
        private readonly SalesMainView _salesView;
        private readonly PurchasesMainView _puchasesView;
        private readonly SettingsView _settingsView;

        public MainView(
            InventoryView inventoryView,
            SalesMainView salesView,
            PurchasesMainView puchasesView,
            SettingsView settingsView
        )
        {
            InitializeComponent();
            Theme.ApplyColorSchemeToForm(this);
            _inventoryView = inventoryView;
            _salesView = salesView;
            _puchasesView = puchasesView;
            _settingsView = settingsView;
        }

        public UserDto User
        {
            set => _user = value;
        }

        private void OpenView(TabPage tabPage)
        {
            var actions = new Dictionary<Predicate<TabPage>, Action>
            {
                {
                    tp => tp == tpInventory,
                    () => ViewHelper.OpenChildForm(tpInventory, _inventoryView)
                },
                {
                    tp => tp == tpPurchases,
                    () => ViewHelper.OpenChildForm(tpPurchases, _puchasesView)
                },
                {
                    tp => tp == tpSettings,
                    () => ViewHelper.OpenChildForm(tpSettings, _settingsView)
                },
                { tp => tp == tpSales, () => ViewHelper.OpenChildForm(tpSales, _salesView) },
            };

            foreach (var action in actions)
            {
                if (action.Key(tabPage))
                {
                    Text = tabPage.Text;
                    action.Value();
                    break;
                }
            }
        }

        private void TCMainOnSelectedIndexChanged(object sender, EventArgs e) =>
            OpenView(tcMain.SelectedTab!);

        private void MainViewOnLoad(object sender, EventArgs e)
        {
            OpenView(tcMain.SelectedTab!);
            lblUser.Text += $"{_user.FirstName} {_user.LastName}";
        }

        private void MainFormOnClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult is DialogResult.Cancel)
            {
                var result = MessageBox.Show(
                    "¿Desea salir de InsanmarTec?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result is DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
