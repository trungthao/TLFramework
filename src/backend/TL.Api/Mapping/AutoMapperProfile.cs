using AutoMapper;
using TL.Domain.Models;
using TL.Domain.Entities;

namespace TL.API.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SaveTestRequest, Test>();
        }
    }
}