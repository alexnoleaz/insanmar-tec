using InsanmarTec.Domain.Shared.Dependency;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class SalesView : MaterialForm, ITransientDependency
    {
        public SalesView()
        {
            InitializeComponent();
        }
    }
}
