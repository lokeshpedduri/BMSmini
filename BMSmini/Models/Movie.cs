using System.ComponentModel.DataAnnotations;

namespace BMSmini.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Overview { get; set; }

        [Required]
        public City City { get; set; }

        public Guid TheatreId { get; set; }

    }
}
