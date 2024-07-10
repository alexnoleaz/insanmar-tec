using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Customers.Features
{
    public class CustomersGetter : ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IObjectMapper _objectMapper;

        public CustomersGetter(ICustomerRepository customerRepository, IObjectMapper objectMapper)
        {
            _customerRepository = customerRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<IEnumerable<CustomerDto>>> Execute()
        {
            try
            {
                var customersDb = await _customerRepository.GetAllAsync();
                var customersDto = _objectMapper.Map<List<CustomerDto>>(customersDb);

                return Result<IEnumerable<CustomerDto>>.Success(customersDto);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<CustomerDto>>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
