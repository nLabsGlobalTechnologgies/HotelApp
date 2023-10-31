namespace HotelApp.Entities.Entity
{
    public sealed class TillActivity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public short TillId { get; set; }
        public char InOrOut { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
