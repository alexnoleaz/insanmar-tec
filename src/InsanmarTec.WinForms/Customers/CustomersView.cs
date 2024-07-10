using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Application.Customers.Features;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Shared;

namespace InsanmarTec.WinForms.Views.Customers
{
    public partial class CustomersView : Form, ITransientDependency
    {
        private readonly BindingSource _customersListBindingSource;
        private readonly CustomersGetter _customersGetter;
        private readonly CustomerActivator _customerActivator;
        private readonly CustomerDeactivator _customerDeactivator;
        private readonly IServiceProvider _container;
        private readonly string _btnToggleState = "btnToggleState";
        private readonly string _btnEdit = "btnEdit";

        public CustomersView(
            IServiceProvider container,
            CustomersGetter customersGetter,
            CustomerActivator customerActivator,
            CustomerDeactivator customerDeactivator
        )
        {
            InitializeComponent();
            _container = container;
            _customerActivator = customerActivator;
            _customerDeactivator = customerDeactivator;
            _customersGetter = customersGetter;
            _customersListBindingSource = new BindingSource();

            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            await LoadCustomers();
            ConfigureDataGridView();
        }

        private async Task LoadCustomers()
        {
            var result = await GetCustomers();
            if (!result.IsSuccess)
                return;

            _customersListBindingSource.DataSource = result.Value;
        }

        private async Task<Result<IEnumerable<CustomerDto>>> GetCustomers()
        {
            var result = await _customersGetter.Execute();
            if (!result.IsSuccess)
            {
                ViewHelper.ShowErrorMessage(result.ErrorMessage?.Split(",")[0]);
                return Result<IEnumerable<CustomerDto>>.Failure(string.Empty);
            }

            return Result<IEnumerable<CustomerDto>>.Success(result.Value!);
        }

        private void ConfigureDataGridView()
        {
            throw new NotImplementedException();
        }
    }
}
