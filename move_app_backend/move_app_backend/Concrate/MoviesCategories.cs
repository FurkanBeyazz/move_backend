using System.ComponentModel.DataAnnotations;

namespace move_app_backend.Concrate
{
    public class MoviesCategories
    {
        [Key]
        public int MoviesCategoriesID { get; set; }
        public string MoviesCategoriesName { get; set; }
        public List<Movies> Movies { get; set; }
        public int MoveID { get; set; }
    }
}
