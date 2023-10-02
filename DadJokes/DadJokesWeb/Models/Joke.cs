using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DadJokesWeb.Models
{
    public class Joke
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("title")]
        [MaxLength(128, ErrorMessage = $"Title can't be longer than 128 characters.")]
        public string Title { get; set; } // Start of the joke

        [Required]
        [DisplayName("punchline")]
        [MaxLength(128, ErrorMessage = $"Punchline can't be longer than 128 characters.")]
        public string Description { get; set; } // Punchline

        [Required]
        [DisplayName("display order")]
        [Range(1, Int32.MaxValue, ErrorMessage = $"Display order must be between 1 and 2147483647.")]
        public int DisplayOrder { get; set; }

        [Required]
        [DisplayName("author")]
        [MaxLength(32, ErrorMessage = $"Author's name can't be longer than 32 characters.")]
        public string Author { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
