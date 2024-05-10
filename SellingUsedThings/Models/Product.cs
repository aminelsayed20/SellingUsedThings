using SellingUsedThings.Enum;

namespace SellingUsedThings.Models
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Citeis City { get; set; }
        public string Location { get; set;}
        public DateTime CreatedAt{ get; set; } = DateTime.Now;
        public Categories Category { get; set; }
        public User User { get; set; }
        public List<ProductImage> Images { get; set; }

    }
}
