namespace HotelApp.Entities.Entity
{
    public sealed class Employee
    {
        public int Id { get; set; }
        public byte CountryId { get; set; }
        public short CityId { get; set; }
        public short DistrictId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfWork { get; set; }
        public bool Gender { get; set; }
        public bool IsMarried { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string? Address { get; set; }
    }
}
