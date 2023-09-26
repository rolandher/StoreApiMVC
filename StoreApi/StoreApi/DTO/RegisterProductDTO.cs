namespace StoreApi.DTO
{
    public class RegisterProductDTO
    {
        public String Name { get; set; } 
        public String Description { get; set; } 
        public int Price { get; set; } 
        public int Stock { get; set; } 
        public String Category { get; set; } 
        public RegisterProductDTO(String name, String description, int price, int stock, String category)
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
