namespace HotelApp.Entities.Entity
{
    public sealed class Room
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte FloorNumber { get; set; }//Kat numarası
        public byte Capacity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
