using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Customers.Features
{
    public class CustomerCreator : ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IObjectMapper _objectMapper;

        public CustomerCreator(ICustomerRepository customerRepository, IObjectMapper objectMapper)
        {
            _customerRepository = customerRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result> Execute(CreateCustomerDto input)
        {
            var result = CustomerValidator.Validate(input);
            if (!result.IsValid)
                return Result.Failure(string.Join(",", result.Errors));

            try
            {
                var customer = _objectMapper.Map<Customer>(input);
                await _customerRepository.CreateAsync(customer);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
