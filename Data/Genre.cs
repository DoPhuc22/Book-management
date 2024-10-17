using System.ComponentModel.DataAnnotations;
namespace BlazerApp1.Data
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide genre name")]
        public string Name { get; set; }
       

        public Genre() { }
        public Genre(int genreId, string genreName)
        {
            Id = genreId;
            Name = genreName;
        }
    }

}
