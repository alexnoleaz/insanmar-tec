using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.buys;
using InsanmarTec.WinForms.Notes;
using InsanmarTec.WinForms.Shared;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class PurchasesMainView : MaterialForm, ITransientDependency
    {
        private readonly PurchaseOrdersView _purchaseOrdersView;
        private readonly PurchasesView _purchasesView;
        private readonly EntryNotesView _entryNotesView;

        public PurchasesMainView(
            PurchaseOrdersView purchaseOrdersView,
            PurchasesView purchasesView,
            EntryNotesView entryNotesView
        )
        {
            InitializeComponent();
            _purchaseOrdersView = purchaseOrdersView;
            _purchasesView = purchasesView;
            _entryNotesView = entryNotesView;
        }

        private void OpenView(TabPage tabPage)
        {
            var actions = new Dictionary<Predicate<TabPage>, Action>
            {
                {
                    tp => tp == tpPurchases,
                    () => ViewHelper.OpenChildForm(tpPurchases, _purchasesView)
                },
                {
                    tp => tp == tpPurchaseOrders,
                    () => ViewHelper.OpenChildForm(tpPurchaseOrders, _purchaseOrdersView)
                },
                {
                    tp => tp == tpEntryNotes,
                    () => ViewHelper.OpenChildForm(tpEntryNotes, _entryNotesView)
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

        private void PurchasesMainViewOnLoad(object sender, EventArgs e) =>
            OpenView(tcPurchases.SelectedTab!);

        private void TCPurchasesOnSelectedIndexChanged(object sender, EventArgs e) =>
            OpenView(tcPurchases.SelectedTab!);
    }
}
