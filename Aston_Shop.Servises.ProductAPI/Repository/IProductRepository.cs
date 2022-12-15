using Aston_Shop.Servises.ProductAPI.Models.Dto;

namespace Aston_Shop.Servises.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task <ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProductById(int productId);
    }
}
