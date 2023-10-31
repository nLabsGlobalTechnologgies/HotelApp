namespace HotelApp.Entities.Entity
{
    public sealed class City
    {
        public short Id { get; set; }
        public byte CountryId { get; set; }
        public byte RegionId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string PhoneCode { get; set; }
        public string PostCode { get; set; }
    }
}
