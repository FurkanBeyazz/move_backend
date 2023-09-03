using Microsoft.AspNetCore.Identity;

namespace move_app_backend.Concrate
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public DateTime UserUpdateDate { get; set; }
        public DateTime UserCreateDate { get; set; }
    }
}
