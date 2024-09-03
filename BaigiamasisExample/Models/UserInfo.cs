namespace BaigiamasisExample.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        //public byte[] ProfilePhoto { get; set; }
        public virtual UserHouseStuff UserHouseStuff { get; set; }
        //public virtual User User {  get; set; }
    }
}
