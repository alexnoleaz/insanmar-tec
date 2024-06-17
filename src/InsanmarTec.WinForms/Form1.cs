using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.WinForms
{
    public partial class Form1 : Form, ITransientDependency
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
