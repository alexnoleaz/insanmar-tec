using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.buys
{
    public partial class PurchaseOrdersView : Form, ITransientDependency
    {
        public PurchaseOrdersView()
        {
            InitializeComponent();
        }
    }
}
