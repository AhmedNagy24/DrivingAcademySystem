namespace DataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        public required string Street { get; set; }
        public int Floor { get; set; }
        public int BuildingNum { get; set; }
        public int AppartmentNum { get; set; }
        public required string City { get; set; }
        public required string Region { get; set; }
    }

}
