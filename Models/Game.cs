using System.ComponentModel.DataAnnotations;

namespace HobbyHub.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        public string Genre { get; set; } = "";

        public int ReleaseYear { get; set; }
    }
}