namespace PersonAPI.Source
{
    public interface IPersonRepository
    {
        bool PersonExists(int id);

        ICollection<Person> GetPeople();
        Person GetPerson(int id);

        ICollection<Person> GetPeopleByFirstName(string firstName);
        ICollection<Person> GetPeopleByLastName(string lastName);
        ICollection<Person> GetPeopleByFullName(string firstName, string lastName);
        ICollection<Person> GetPeopleByAge(int upperAge);
        ICollection<Person> GetPeopleByAge(int lowerAge, int upperAge);
        ICollection<Person> GetPeopleByAlive(bool alive);

        bool Save();
        bool CreatePerson(Person person);
        bool UpdatePerson(Person person);
        bool DeletePerson(Person person);


    }
}
