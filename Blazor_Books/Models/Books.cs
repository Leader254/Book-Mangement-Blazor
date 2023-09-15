using System.ComponentModel.DataAnnotations;

namespace Blazor_Books.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public List<Author> Author { get; set; } = new List<Author>();

    }

    //dto for author
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }   
}