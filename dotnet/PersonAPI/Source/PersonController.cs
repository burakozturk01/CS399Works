using Microsoft.AspNetCore.Mvc;

namespace PersonAPI.Source
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeople()
        {
            var people = _personRepository.GetPeople();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ById/{id}")]
        [ProducesResponseType(200, Type = typeof(Person))]
        [ProducesResponseType(400)]
        public IActionResult GetPerson(int id = 1)
        {
            if (!_personRepository.PersonExists(id))
                return NotFound();

            var person = _personRepository.GetPerson(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(person);
        }

        [HttpGet("ByFirstName/{firstName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByFirstName(string firstName)
        {
            var people = _personRepository.GetPeopleByFirstName(firstName);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ByLastName/{lastName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByLastName(string lastName)
        {
            var people = _personRepository.GetPeopleByLastName(lastName);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ByFullName/{firstName}/{lastName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByFullName(string firstName, string lastName)
        {
            var people = _personRepository.GetPeopleByFullName(firstName, lastName);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ByUpperAge/{maxAge}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByAge(int maxAge = 120)
        {
            var people = _personRepository.GetPeopleByAge(maxAge);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ByAgeRange/{minAge}/{maxAge}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByAgeRange(int minAge = 0, int maxAge = 120)
        {
            var people = _personRepository.GetPeopleByAge(minAge, maxAge);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        [HttpGet("ByAlive/{isAlive}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Person>))]
        public IActionResult GetPeopleByAlive(bool isAlive = true)
        {
            var people = _personRepository.GetPeopleByAlive(isAlive);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(people);
        }

        private string InputValidation(Person person)
        {
            string error = "";

            if (person.FirstName == "string" || person.LastName == "string")
                error = "Change default value for the names.";
            else if (person.FirstName.Length < 2)
                error = "Firstname can't be shorter than 2 characters.";
            else if (person.LastName.Length < 2)
                error = "Lastname can't be shorter than 2 characters.";
            else if (person.Age < 0)
                error = "Age can't be negative";
            else if (person.Age > 120)
                error = "Age can't be higher than 120.";

            return error;
        }

        [HttpPost("Create")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreatePerson([FromBody] Person personCreate)
        {
            if (personCreate == null)
                return BadRequest(ModelState);

            string error = InputValidation(personCreate);
            
            if (error.Any())
            {
                ModelState.AddModelError("", error);
                return BadRequest(error);
            }
            

            var person = _personRepository.GetPeople()
                .Where(p => p.FirstName == personCreate.FirstName.Trim()
                         &&  p.LastName == personCreate.LastName.Trim()
                         &&       p.Age == personCreate.Age
                         &&   p.IsAlive == personCreate.IsAlive)
                .FirstOrDefault();

            if (person != null)
            {
                ModelState.AddModelError("", "Person already exists");
                return StatusCode(422, ModelState);
            }

            if (!_personRepository.CreatePerson(personCreate))
            {
                ModelState.AddModelError("", "Something went wrong while creating the person.");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created.");
        }

        [HttpPut("Update/{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult UpdatePerson(int id, [FromBody] Person updatedPerson)
        {
            if (updatedPerson == null)
                return BadRequest(ModelState);

            if (id != updatedPerson.Id)
                return BadRequest(ModelState);

            if (!_personRepository.PersonExists(id))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_personRepository.UpdatePerson(updatedPerson))
            {
                ModelState.AddModelError("", "Something went wrong while updating the person.");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully updated.");
        }

        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult DeletePerson(int id)
        {
            if (!_personRepository.PersonExists(id))
                return NotFound();

            var personDelete = _personRepository.GetPerson(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_personRepository.DeletePerson(personDelete))
            {
                ModelState.AddModelError("", "Something went wrong while deleting the person.");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully deleted.");
        }
    }
}
