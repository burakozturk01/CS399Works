using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            this._context = context;
        }

        public bool CreatePokemon(int categoryId, int ownerId, Pokemon pokemon)
        {
            var category = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
            var owner = _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();

            _context.Add(
                new PokemonCategory()
                {
                    Pokemon = pokemon,
                    Category = category
                }
            );

            _context.Add(
                new PokemonOwner()
                {
                    Pokemon = pokemon,
                    Owner = owner
                }
            );

            _context.Add(pokemon);

            return Save();
        }

        public bool DeletePokemon(Pokemon pokemon)
        {
            _context.Remove(pokemon);
            return Save();
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);

            if (!review.Any())
                return 0;

            return ((decimal)review.Sum(p => p.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(p => p.Id == pokeId);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool UpdatePokemon(int categoryId, int ownerId, Pokemon pokemon)
        {
            _context.Update(pokemon);
            return Save();
        }
    }
}
