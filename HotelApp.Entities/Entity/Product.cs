namespace HotelApp.Entities.Entity
{
    public sealed class Product
    {
        public int Id { get; set; }
        public short CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Amount { get; set; }
        public bool IsActive { get; set; }
    }
}
