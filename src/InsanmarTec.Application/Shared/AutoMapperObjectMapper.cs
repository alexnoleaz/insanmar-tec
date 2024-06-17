using AutoMapper;
using InsanmarTec.Domain.Shared;

namespace InsanmarTec.Application.Shared
{
    public class AutoMapperObjectMapper : IObjectMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperObjectMapper(IMapper mapper) => _mapper = mapper;

        public TDestination Map<TDestination>(object source) => _mapper.Map<TDestination>(source);

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination) =>
            _mapper.Map(source, destination);

        public IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source) =>
            _mapper.ProjectTo<TDestination>(source);
    }
}
