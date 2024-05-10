using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SellingUsedThings.Models
{
    public class User :BaseEntity
    { 
        [Required(ErrorMessage = "the name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }
        public string ImgPath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Product> Products { get; set; }
        public List<Chat> Chats { get; set; }
 
    }
}
