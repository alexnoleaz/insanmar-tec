using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Brands;
using InsanmarTec.WinForms.Models;
using InsanmarTec.WinForms.Shared;
using InsanmarTec.WinForms.Views.ProductMaintainer;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class InventoryView : MaterialForm, ITransientDependency
    {
        private readonly BrandsView _brandsView;
        private readonly ProductsView _productsView;
        private readonly ModelsView _modelsView;

        public InventoryView(
            BrandsView brandsView,
            ProductsView productsView,
            ModelsView modelsView
        )
        {
            InitializeComponent();
            _brandsView = brandsView;
            _productsView = productsView;
            _modelsView = modelsView;
        }

        private void OpenView(TabPage tabPage)
        {
            var actions = new Dictionary<Predicate<TabPage>, Action>
            {
                { tp => tp == tpBrands, () => ViewHelper.OpenChildForm(tpBrands, _brandsView) },
                {
                    tp => tp == tpProducts,
                    () => ViewHelper.OpenChildForm(tpProducts, _productsView)
                },
                { tp => tp == tpModels, () => ViewHelper.OpenChildForm(tpModels, _modelsView) }
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

        private void TCInventoryOnSelectedIndexChagend(object sender, EventArgs e) =>
            OpenView(tcInventory.SelectedTab!);

        private void InventoryViewOnLoad(object sender, EventArgs e) =>
            OpenView(tcInventory.SelectedTab!);
    }
}
