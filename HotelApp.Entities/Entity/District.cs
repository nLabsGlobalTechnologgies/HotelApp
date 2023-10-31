namespace HotelApp.Entities.Entity
{
    public sealed class District
    {
        public short Id { get; set; }
        public short CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PostCode { get; set; }
    }
}
