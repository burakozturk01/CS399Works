namespace PersonAPI.Source
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Person> GetPeople()
        {
            return _context.People.OrderBy(p => p.Id).ToList();
        }

        public ICollection<Person> GetPeopleByAge(int upperAge)
        {
            return _context.People
                .Where(p => p.Age <= upperAge)
                .OrderBy(p => p.Age).ToList();
        }

        public ICollection<Person> GetPeopleByAge(int lowerAge, int upperAge)
        {
            return _context.People
                .Where(p => p.Age >= lowerAge && p.Age <= upperAge)
                .OrderBy(p => p.Age).ToList();
        }

        public ICollection<Person> GetPeopleByAlive(bool alive)
        {
            return _context.People
                .Where(p => p.IsAlive == alive)
                .OrderBy(p => p.Id).ToList();
        }

        public Person GetPerson(int id)
        {
            return _context.People.Where(p => p.Id == id) .FirstOrDefault();
        }

        public ICollection<Person> GetPeopleByFirstName(string firstName)
        {
            return _context.People.Where(p => p.FirstName == firstName.Trim())
                .OrderBy(p => p.FirstName).ToList();
        }

        public ICollection<Person> GetPeopleByLastName(string lastName)
        {
            return _context.People.Where(p => p.LastName == lastName.Trim())
                .OrderBy(p => p.LastName).ToList();
        }

        public ICollection<Person> GetPeopleByFullName(string firstName, string lastName)
        {
            return _context.People
                .Where(p => p.FirstName == firstName.Trim() && p.LastName == lastName.Trim())
                .OrderBy(p => p.LastName + p.FirstName).ToList();
        }

        public bool PersonExists(int id)
        {
            return _context.People.Where(p => p.Id == id).Any();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool CreatePerson(Person person)
        {
            _context.People.Add(person);
            return Save();
        }

        public bool UpdatePerson(Person person)
        {
            _context.Update(person);
            return Save();
        }

        public bool DeletePerson(Person person)
        {
            _context.Remove(person);
            return Save();
        }
    }
}
