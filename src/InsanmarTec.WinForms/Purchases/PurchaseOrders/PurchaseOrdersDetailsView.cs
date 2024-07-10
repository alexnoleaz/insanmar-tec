using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.buys
{
    public partial class PurchaseOrdersDetailsView : Form, ITransientDependency
    {
        public PurchaseOrdersDetailsView()
        {
            InitializeComponent();
        }
    }
}
