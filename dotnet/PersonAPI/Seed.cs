using PersonAPI.Source;

namespace PersonAPI
{
    public class Seed
    {
        private readonly DataContext context;
        private Random rand = new Random();

        public Seed(DataContext context)
        {
            this.context = context;
        }

        public void SeedDataContext()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "Burak", LastName = "Öztürk", Age = 23, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Heather", LastName = "Mary", Age = 65, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Emma", LastName = "Madeleine", Age = 55, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Fiona", LastName = "Andrea", Age = 21, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Bella", LastName = "Una", Age = 63, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Emma", LastName = "Zoe", Age = 34, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Ruth", LastName = "Jane", Age = 4, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Molly", LastName = "Wanda", Age = 81, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Theresa", LastName = "Emma", Age = 86, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Ruth", LastName = "Audrey", Age = 81, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Pippa", LastName = "Diane", Age = 5, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Faith", LastName = "Anna", Age = 2, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sarah", LastName = "Faith", Age = 23, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Amy", LastName = "Lily", Age = 47, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Joan", LastName = "Melanie", Age = 22, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Samantha", LastName = "Stephanie", Age = 8, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Ella", LastName = "Anne", Age = 28, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Andrea", LastName = "Una", Age = 18, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Una", LastName = "Elizabeth", Age = 33, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Tracey", LastName = "Deirdre", Age = 4, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Leah", LastName = "Stephanie", Age = 57, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Olivia", LastName = "Madeleine", Age = 23, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Samantha", LastName = "Dorothy", Age = 63, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Maria", LastName = "Heather", Age = 30, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alison", LastName = "Katherine", Age = 94, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Carol", LastName = "Katherine", Age = 33, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Maria", LastName = "Amelia", Age = 25, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Virginia", LastName = "Carol", Age = 92, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Carolyn", LastName = "Emily", Age = 60, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Carol", LastName = "Audrey", Age = 31, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Heather", LastName = "Olivia", Age = 5, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sophie", LastName = "Stephanie", Age = 19, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Leah", LastName = "Sophie", Age = 92, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Emily", LastName = "Bella", Age = 89, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Audrey", LastName = "Sue", Age = 23, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sue", LastName = "Jessica", Age = 79, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Jennifer", LastName = "Emma", Age = 7, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sonia", LastName = "Fiona", Age = 90, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Deirdre", LastName = "Bella", Age = 69, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Anna", LastName = "Sarah", Age = 62, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Stephanie", LastName = "Maria", Age = 95, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Felicity", LastName = "Megan", Age = 58, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sarah", LastName = "Grace", Age = 1, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Wanda", LastName = "Hannah", Age = 12, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Pippa", LastName = "Carolyn", Age = 18, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alexandra", LastName = "Samantha", Age = 31, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Theresa", LastName = "Zoe", Age = 59, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Jasmine", LastName = "Bernadette", Age = 86, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Hannah", LastName = "Heather", Age = 26, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Una", LastName = "Diana", Age = 77, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Victoria", LastName = "Caroline", Age = 65, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Joanne", LastName = "Amy", Age = 89, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Amelia", LastName = "Andrea", Age = 25, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Fiona", LastName = "Samantha", Age = 66, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Bella", LastName = "Samantha", Age = 24, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Felicity", LastName = "Amy", Age = 11, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Audrey", LastName = "Natalie", Age = 15, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sophie", LastName = "Audrey", Age = 45, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Deirdre", LastName = "Alison", Age = 66, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Zoe", LastName = "Joanne", Age = 58, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Olivia", LastName = "Anne", Age = 75, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Gabrielle", LastName = "Samantha", Age = 93, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alexandra", LastName = "Anna", Age = 81, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Bernadette", LastName = "Una", Age = 46, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Diana", LastName = "Stephanie", Age = 99, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Donna", LastName = "Wendy", Age = 24, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Natalie", LastName = "Megan", Age = 96, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Jessica", LastName = "Michelle", Age = 63, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Felicity", LastName = "Ava", Age = 96, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sally", LastName = "Lily", Age = 5, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Leah", LastName = "Jennifer", Age = 99, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Amelia", LastName = "Kimberly", Age = 93, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Diane", LastName = "Penelope", Age = 77, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Grace", LastName = "Una", Age = 4, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Lily", LastName = "Sonia", Age = 76, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alexandra", LastName = "Sally", Age = 52, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alison", LastName = "Katherine", Age = 26, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sarah", LastName = "Una", Age = 3, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Donna", LastName = "Felicity", Age = 73, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Molly", LastName = "Jasmine", Age = 57, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Elizabeth", LastName = "Zoe", Age = 45, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Amanda", LastName = "Jasmine", Age = 4, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Jennifer", LastName = "Joanne", Age = 85, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Diane", LastName = "Claire", Age = 1, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Amy", LastName = "Julia", Age = 83, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Mary", LastName = "Wanda", Age = 45, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Chloe", LastName = "Kimberly", Age = 48, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Joan", LastName = "Amanda", Age = 55, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Lillian", LastName = "Lisa", Age = 47, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Elizabeth", LastName = "Amanda", Age = 29, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Wanda", LastName = "Ava", Age = 42, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Wendy", LastName = "Felicity", Age = 84, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Natalie", LastName = "Julia", Age = 38, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Maria", LastName = "Madeleine", Age = 85, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Carolyn", LastName = "Maria", Age = 74, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sonia", LastName = "Irene", Age = 40, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Virginia", LastName = "Diana", Age = 89, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Sophie", LastName = "Elizabeth", Age = 4, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Alexandra", LastName = "Felicity", Age = 34, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Rachel", LastName = "Hannah", Age = 60, IsAlive = rand.NextDouble() < 0.8},
                new Person() {FirstName = "Fiona", LastName = "Penelope", Age = 36, IsAlive = rand.NextDouble() < 0.8}
            };
            context.People.AddRange(people);
            context.SaveChanges();
        }
    }
}
