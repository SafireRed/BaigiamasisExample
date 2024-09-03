namespace BaigiamasisExample.Models
{
    public class UserHouseStuff
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public virtual UserInfo UserInfo {  get; set; }
    }
}
