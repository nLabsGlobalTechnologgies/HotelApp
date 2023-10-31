namespace HotelApp.Entities.Entity
{
    public sealed class Till
    {
        public short Id { get; set; }
        public string PaymentType { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
