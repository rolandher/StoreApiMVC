namespace StoreApi.Model
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Product Products { get; set; }
        public User Users { get; set; }

    }
}
