using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Views.ProductMaintainer
{
    public partial class ProductsView : Form, ITransientDependency
    {
        public ProductsView()
        {
            InitializeComponent();
        }
    }
}
