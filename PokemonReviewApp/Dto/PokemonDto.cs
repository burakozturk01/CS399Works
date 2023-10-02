using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    public class PokemonDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public DateTime BirthTime { get; set; } = DateTime.Now; // Might be problem
    }
}
