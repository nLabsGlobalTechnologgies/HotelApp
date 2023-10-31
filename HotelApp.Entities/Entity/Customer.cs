namespace HotelApp.Entities.Entity
{
    public sealed class Customer
    {
        public Guid Id { get; set; }
        public byte CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public bool IsMarried { get; set; }
        public string? CompanyName { get; set; }
        public bool IsActive { get; set; }
        public string? Address { get; set; }
    }
}
