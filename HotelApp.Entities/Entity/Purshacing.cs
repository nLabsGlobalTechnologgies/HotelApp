namespace HotelApp.Entities.Entity
{
    public sealed class Purshacing
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int EmployeeId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
