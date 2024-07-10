using InsanmarTec.Domain.Shared.Dependency;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Views
{
    public partial class SettingsView : MaterialForm, ITransientDependency
    {
        public SettingsView()
        {
            InitializeComponent();
        }
    }
}
