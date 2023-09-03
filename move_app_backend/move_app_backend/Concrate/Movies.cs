using System.ComponentModel.DataAnnotations;

namespace move_app_backend.Concrate
{
    public class Movies
    {
        [Key]
        public int MoveID { get; set; }
        public string MoveName { get; set; }
        public string MoveDescription { get; set; }
        public DateTime MoveRelaseDate { get; set; }
        public string IMDb { get; set; }
        public int MoveCategoriesID { get; set; }
        public List<MoviesCategories> MoviesCategories { get; set; }
        public int MoviesCategoriesID { get; set; }
    }
}
