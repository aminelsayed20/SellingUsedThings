namespace SellingUsedThings.Models
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public DateTime CreatedAt{ get; set; }
        public int SenderId{ get; set;}
        public Chat Chat { get; set; }

    }
}
