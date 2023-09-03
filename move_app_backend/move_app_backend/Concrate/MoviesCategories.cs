namespace move_app_backend.Concrate
{
    public class MoviesCategories
    {
        public int MoviesCategoriesID { get; set; }
        public string MoviesCategoriesName { get; set; }
        List<Movies> Movies { get; set; }
    }
}
