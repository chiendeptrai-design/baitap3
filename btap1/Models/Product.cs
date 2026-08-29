namespace btap1.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Image { get; set; } = string.Empty;
    }
}