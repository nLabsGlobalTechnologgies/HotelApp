namespace HotelApp.Entities.Entity
{
    public sealed class Sale
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        public short RoomId { get; set; }
        public DateTime Date { get; set; }
    }
}
