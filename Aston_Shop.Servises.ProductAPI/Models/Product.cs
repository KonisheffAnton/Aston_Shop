using System.ComponentModel.DataAnnotations;

namespace Aston_Shop.Servises.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name_Product { get; set; }
        [Range(1,1000)]
        public double Price_Product { get; set; }   
        public string Description_Product { get; set; }
        public string CategoryName_Product { get; set; }
        public string ImageUrl_Product { get; set; }
    }
}
