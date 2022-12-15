using System.ComponentModel.DataAnnotations;

namespace Aston_Shop.Servises.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name_Product { get; set; }
        public double Price_Product { get; set; }
        public string Description_Product { get; set; }
        public string CategoryName_Product { get; set; }
        public string ImageUrl_Product { get; set; }
    }
}
