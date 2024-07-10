using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Models
{
    public partial class ModelsView : Form, ITransientDependency
    {
        public ModelsView()
        {
            InitializeComponent();
        }
    }
}
