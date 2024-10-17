using System.ComponentModel.DataAnnotations;
namespace BlazerApp1.Data
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please provide book name")]
        public string Title { get; set; }
        
        [Required]
        [Range(0, 1)]
        public int Status { get; set; }

        [Required(ErrorMessage = "Please provide author name")]
        public string Author { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Please select a genre!")]
        public int Genre_id { get; set; }

        [Required(ErrorMessage = "Please provide published year")]
        [Range(1000, Int32.MaxValue, ErrorMessage = "Published Year must be higher than 1000!")]
        public int PublishedYear { get; set; }

        public string Image { get; set; }

        public Book() { }
        public Book(int bookId, string bookTitle, int status, string image, int genre_id, int publishedYear, string author)
        {
            Id = bookId;
            Title = bookTitle;
            Status = status;
            Image = image;
            Genre_id = genre_id;
            PublishedYear = publishedYear;
            Author = author;
        }
    }

}
