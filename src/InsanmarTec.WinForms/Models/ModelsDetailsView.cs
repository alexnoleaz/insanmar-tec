using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Models
{
    public partial class ModelsDetailsView : Form, ITransientDependency
    {
        public ModelsDetailsView()
        {
            InitializeComponent();
        }
    }
}
