namespace HotelApp.Entities.Entity
{
    public sealed class Region
    {
        public byte Id { get; set; }
        public byte CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
