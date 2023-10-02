using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            Level = 18,
                            BirthTime = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            BirthTime = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            BirthTime = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Gym = "Ashs Gym",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Charizard",
                            BirthTime = new DateTime(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Fire" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Awesome Fire Pokemon",
                                    Text = "Charizard is an incredible fire-type Pokemon with powerful attacks.",
                                    Rating = 5,
                                    Reviewer = new Reviewer { FirstName = "Gary", LastName = "Oak" }
                                },
                                new Review
                                {
                                    Title = "Charizard's Strength",
                                    Text = "Charizard's Fire Blast attack can melt anything in its path.",
                                    Rating = 4,
                                    Reviewer = new Reviewer { FirstName = "Misty", LastName = "Waterflower" }
                                },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Red",
                            LastName = "Vermillion",
                            Gym = "Red's Gym",
                            Country = new Country()
                            {
                                Name = "Pallet Town"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            BirthTime = new DateTime(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Cutest Pokemon Ever",
                                    Text = "Pikachu's adorable appearance and electric powers make it my favorite Pokemon!",
                                    Rating = 5,
                                    Reviewer = new Reviewer { FirstName = "Ash", LastName = "Ketchum" }
                                },
                                new Review
                                {
                                    Title = "Pikachu's Thunderbolt",
                                    Text = "Pikachu's Thunderbolt attack is so strong that it can paralyze opponents instantly.",
                                    Rating = 4,
                                    Reviewer = new Reviewer { FirstName = "Brock", LastName = "Harrison" }
                                },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ritchie",
                            LastName = "Harrison",
                            Gym = "Ritchie's Gym",
                            Country = new Country()
                            {
                                Name = "Evergreen City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Blastoise",
                            BirthTime = new DateTime(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Water-Type Powerhouse",
                                    Text = "Blastoise's Hydro Pump attack can create powerful water blasts capable of crushing rocks.",
                                    Rating = 5,
                                    Reviewer = new Reviewer { FirstName = "Misty", LastName = "Waterflower" }
                                },
                                new Review
                                {
                                    Title = "Blastoise's Defense",
                                    Text = "Blastoise's tough shell provides excellent defense against enemy attacks.",
                                    Rating = 4,
                                    Reviewer = new Reviewer { FirstName = "Lt. Surge", LastName = "Vermillion" }
                                },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Gary",
                            LastName = "Oak",
                            Gym = "Gary's Gym",
                            Country = new Country()
                            {
                                Name = "Pallet Town"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Gengar",
                            BirthTime = new DateTime(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Ghost" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Mischievous Ghost",
                                    Text = "Gengar's ability to hide in the shadows and play tricks on others makes it an entertaining Pokemon.",
                                    Rating = 4,
                                    Reviewer = new Reviewer { FirstName = "Sabrina", LastName = "Kadabra" }
                                },
                                new Review
                                {
                                    Title = "Gengar's Nightmares",
                                    Text = "Gengar's Nightmare attack can haunt opponents, causing them to have terrifying dreams.",
                                    Rating = 3,
                                    Reviewer = new Reviewer { FirstName = "Morty", LastName = "Ecruteak" }
                                },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Agatha",
                            LastName = "Willow",
                            Gym = "Agatha's Gym",
                            Country = new Country()
                            {
                                Name = "Lavender Town"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Dragonite",
                            BirthTime = new DateTime(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Dragon" } },
                                new PokemonCategory { Category = new Category() { Name = "Flying" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Majestic Dragon",
                                    Text = "Dragonite's powerful wings allow it to soar through the skies and unleash devastating dragon-type attacks.",
                                    Rating = 5,
                                    Reviewer = new Reviewer { FirstName = "Lance", LastName = "Dragonheart" }
                                },
                                new Review
                                {
                                    Title = "Dragonite's Hyper Beam",
                                    Text = "Dragonite's Hyper Beam attack can obliterate anything in its path with its incredible power.",
                                    Rating = 4,
                                    Reviewer = new Reviewer { FirstName = "Drake", LastName = "Orange" }
                                },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Clair",
                            LastName = "Blackthorn",
                            Gym = "Clair's Gym",
                            Country = new Country()
                            {
                                Name = "Blackthorn City"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}