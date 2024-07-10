using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms.Notes
{
    public partial class EntryNotesView : Form, ITransientDependency
    {
        public EntryNotesView()
        {
            InitializeComponent();
        }
    }
}
