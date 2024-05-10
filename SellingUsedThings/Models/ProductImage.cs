using System.ComponentModel.DataAnnotations.Schema;

namespace SellingUsedThings.Models
{
    public class ProductImage : BaseEntity
    {
        public string ImagePath { get; set; }
        public Product Product { get; set; }
    }
}
