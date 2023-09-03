using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using move_app_backend.Concrate;

namespace move_app_backend
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CH9SD0T; database=MovieDb; Encrypt = False;integrated Security=true;");
        }
        DbSet<Movies> movies { get; set; }
        DbSet<MoviesCategories> moviesCategories { get; set; }
        DbSet<UserFavoriteMove> moviesFavoriteMove { get; set; }

    }
}
