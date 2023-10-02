using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public DateTime BirthTime { get; set; } = DateTime.Now;

        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
