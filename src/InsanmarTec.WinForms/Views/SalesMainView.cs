using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Notes;
using InsanmarTec.WinForms.Sales;
using InsanmarTec.WinForms.Shared;
using InsanmarTec.WinForms.Views.Customers;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class SalesMainView : MaterialForm, ITransientDependency
    {
        private readonly SalesView _salesView;
        private readonly ExitNotesView _exitNotesView;
        private readonly CustomersView _customersView;

        public SalesMainView(
            SalesView salesView,
            ExitNotesView exitNotesView,
            CustomersView customersView
        )
        {
            InitializeComponent();
            _salesView = salesView;
            _exitNotesView = exitNotesView;
            _customersView = customersView;
        }

        private void OpenView(TabPage tabPage)
        {
            var actions = new Dictionary<Predicate<TabPage>, Action>
            {
                { tp => tp == tpSales, () => ViewHelper.OpenChildForm(tpSales, _salesView) },
                {
                    tp => tp == tpExitNotes,
                    () => ViewHelper.OpenChildForm(tpExitNotes, _exitNotesView)
                },
                {
                    tp => tp == tpCustomers,
                    () => ViewHelper.OpenChildForm(tpCustomers, _customersView)
                }
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

        private void TCSalesOnSelectedIndexChagend(object sender, EventArgs e) =>
            OpenView(tcPurchases.SelectedTab!);

        private void SalesMainViewOnLoad(object sender, EventArgs e) =>
            OpenView(tcPurchases.SelectedTab!);
    }
}
