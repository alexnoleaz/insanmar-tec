using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Views.ProductMaintainer
{
    public partial class ProductsDetailsView : Form, ITransientDependency
    {
        public ProductsDetailsView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
