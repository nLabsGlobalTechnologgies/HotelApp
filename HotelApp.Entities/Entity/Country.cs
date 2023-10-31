namespace HotelApp.Entities.Entity
{
    public sealed class Country
    {
        public byte Id { get; set; }
        public byte ContinentId { get; set; }
        public byte CountryCode { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneCode { get; set; }
    }
}
