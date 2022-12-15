using Aston_Shop.Servises.ProductAPI.Models;
using Aston_Shop.Servises.ProductAPI.Models.Dto;
using AutoMapper;

namespace Aston_Shop.Servises.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product > ();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
