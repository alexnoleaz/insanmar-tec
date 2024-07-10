using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Brands;
using InsanmarTec.WinForms.Shared;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class InventoryView : MaterialForm, ITransientDependency
    {
        private readonly BrandsView _brandsView;

        public InventoryView(BrandsView brandsView)
        {
            InitializeComponent();
            _brandsView = brandsView;
        }

        private void OpenView(TabPage tabPage)
        {
            var actions = new Dictionary<Predicate<TabPage>, Action>
            {
                { tp => tp == tpBrands, () => ViewHelper.OpenChildForm(tpBrands, _brandsView) },
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

        private void TCInventorySelectedIndexChagend(object sender, EventArgs e)
        {
            OpenView(tcInventory.SelectedTab!);
        }
    }
}
