using InsanmarTec.Application.Customers.Dtos;
using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Customers.Features
{
    public class CustomerGetter : ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IObjectMapper _objectMapper;

        public CustomerGetter(ICustomerRepository customerRepository, IObjectMapper objectMapper)
        {
            _customerRepository = customerRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<CustomerDto>> Execute(EntityDto input)
        {
            try
            {
                var customerDb = await _customerRepository.GetAsync(input.Id);
                var customerDto = _objectMapper.Map<CustomerDto>(customerDb);

                return Result<CustomerDto>.Success(customerDto);
            }
            catch (EntityNotFoundException ex)
            {
                return Result<CustomerDto>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result<CustomerDto>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
