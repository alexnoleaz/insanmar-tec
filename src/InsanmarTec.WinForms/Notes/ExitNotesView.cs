using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Notes
{
    public partial class ExitNotesView : Form, ITransientDependency
    {
        public ExitNotesView()
        {
            InitializeComponent();
        }
    }
}
