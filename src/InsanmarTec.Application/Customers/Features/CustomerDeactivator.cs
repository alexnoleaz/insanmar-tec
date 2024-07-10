﻿using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Application.Customers.Features
{
    public class CustomerDeactivator : ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerDeactivator(ICustomerRepository customerRepository) =>
            _customerRepository = customerRepository;

        public async Task<Result> Execute(EntityDto input)
        {
            try
            {
                await _customerRepository.Deactivate(input.Id);
                return Result.Success();
            }
            catch (EntityNotFoundException ex)
            {
                return Result.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                return Result.Failure($"Ocurrió un error al ejecutar la operación: {ex.Message}");
            }
        }
    }
}
