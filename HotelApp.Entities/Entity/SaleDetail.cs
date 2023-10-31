namespace HotelApp.Entities.Entity
{
    public sealed class SaleDetail
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public float Amount { get; set; }
        public float Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
