using AutoMapper;
using Avam.DigiCura.Domain;
using Avam.DigiCura.NgOne.UI.Models;

namespace Avam.DigiCura.NgOne.UI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<CategoryViewModel, Category>()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}