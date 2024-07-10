using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Sales
{
    public partial class SalesView : Form, ITransientDependency
    {
        public SalesView()
        {
            InitializeComponent();
        }
    }
}
