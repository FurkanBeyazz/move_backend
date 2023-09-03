namespace move_app_backend.Concrate
{
    public class Movies
    {
        public int MoveID { get; set; }
        public string MoveName { get; set; }
        public string MoveDescription { get; set; }
        public DateTime MoveRelaseDate { get; set; }
        public string IMDb { get; set; }
        public int MoveCategoriesID { get; set; }
        List<MoviesCategories> MoviesCategories { get; set; }   
    }
}
