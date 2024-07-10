using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.buys
{
    public partial class PurchasesView : Form, ITransientDependency
    {
        public PurchasesView()
        {
            InitializeComponent();
        }
    }
}
