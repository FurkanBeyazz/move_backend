using System.ComponentModel.DataAnnotations;

namespace move_app_backend.Concrate
{
    public class UserFavoriteMove
    {
        [Key]
        public int MoveFovorite_ID { get; set; }
        public bool Status { get; set; }
        public string MoveName { get; set; }
    }
}
