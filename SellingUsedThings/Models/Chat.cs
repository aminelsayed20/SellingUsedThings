namespace SellingUsedThings.Models
{
    public class Chat :BaseEntity
    {
        public int User1Id { get; set; }
        public int User2Id { get; set; }
        public List<Message> Messages { get; set; }

    }
}
