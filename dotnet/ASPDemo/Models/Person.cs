using System.ComponentModel;

namespace ASPDemo.Models
{
    public class Person
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Alive")]
        public bool IsAlive { get; set; } = true;
    }
}