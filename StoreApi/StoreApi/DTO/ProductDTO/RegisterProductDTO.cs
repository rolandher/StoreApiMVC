using System.ComponentModel.DataAnnotations;

namespace StoreApi.DTO.ProductDTO
{
    public class RegisterProductDTO
    {
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        [Required] public int Price { get; set; }
        [Required] public int Stock { get; set; }
        [Required] public string Category { get; set; }
        public RegisterProductDTO(string name, string description, int price, int stock, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Category = category;
        }
        public RegisterProductDTO()
        {
        }
    }
}
