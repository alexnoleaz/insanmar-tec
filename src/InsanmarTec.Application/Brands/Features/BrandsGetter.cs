﻿using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared;
using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Application.Brands.Features
{
    public class BrandsGetter : ITransientDependency
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IObjectMapper _objectMapper;

        public BrandsGetter(IBrandRepository brandRepository, IObjectMapper objectMapper)
        {
            _brandRepository = brandRepository;
            _objectMapper = objectMapper;
        }

        public async Task<Result<IEnumerable<BrandDto>>> Execute()
        {
            try
            {
                var brandsDb = await _brandRepository.GetAllAsync();
                var brandsDto = _objectMapper.Map<List<BrandDto>>(brandsDb);

                return Result<IEnumerable<BrandDto>>.Success(brandsDto);
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<BrandDto>>.Failure(
                    $"Ocurrió un error al ejecutar la operación: {ex.Message}"
                );
            }
        }
    }
}
