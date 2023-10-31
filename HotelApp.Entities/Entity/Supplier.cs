namespace HotelApp.Entities.Entity
{
    public sealed class Supplier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
    }
}
