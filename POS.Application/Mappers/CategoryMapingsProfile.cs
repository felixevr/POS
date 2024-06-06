using AutoMapper;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Utilities.Static;

namespace POS.Application.Mappers
{
    public class CategoryMapingsProfile : Profile
    {
        public CategoryMapingsProfile()
        {
            CreateMap<Category, CategoryResponseDto>()
                .ForMember(x => x.StateCategory, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo"))
                .ReverseMap();
            // Personal Notes. Learning purpose only. Not intended for documentation.
            // x in the first parameter is destination member class (CategoryResponseDto)
            // x in the second parameter is a IMemberConfigurationExpression that specify how Automap should make the map.
            // y is the source from mapping. Used when the name of the properties doesn't match.

            CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDto>>()
                .ReverseMap();

            CreateMap<CategoryRequestDto, Category>();

            CreateMap<CategorySelectResponseDto, Category>()
                .ReverseMap();
        }
    }
}
