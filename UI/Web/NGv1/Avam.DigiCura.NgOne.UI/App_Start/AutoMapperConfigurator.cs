using AutoMapper;
using Avam.DigiCura.Domain;
using Avam.DigiCura.NgOne.UI.Models;

namespace Avam.DigiCura.NgOne.UI
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoryViewModel>());
        }
    }
}