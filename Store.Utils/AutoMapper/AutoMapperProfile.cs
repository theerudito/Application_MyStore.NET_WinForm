using AutoMapper;
using Store.DTO;
using Store.Models;

namespace Store.Utils.AutoMapper
{
    public class AutoMapperProfile : Profile

    {
        protected AutoMapperProfile()
        {
            CreateMap<MAuthDTO, MAuth>();
        }
    }
}