using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Suppliers
{
    public partial class SuppliersView : Form, ITransientDependency
    {
        public SuppliersView()
        {
            InitializeComponent();
        }
    }
}
