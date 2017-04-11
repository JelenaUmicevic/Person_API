using Microsoft.AspNetCore.Mvc;
using Person_API.Entities;
using Person_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Controllers
{
    [Route("api/persons")]
    public class PersonsController : Controller
    {
        private IPersonRepository _personRepository;

        private PpContext _ctx;

        public PersonsController(PpContext personRepository)
        {
            _ctx = personRepository;
            _personRepository = new PersonRepository(personRepository);
        }



        [HttpGet()]
        public IActionResult GetPersons()
        {
            var result = _personRepository.GetPeople();
            return Ok(result);
        }
        [HttpGet("{JMBG}")]
        public IActionResult GetPersons(long JMBG)
        {
            var PersonstoReturn = _personRepository.GetPerson(JMBG);

            if (PersonstoReturn == null)
            {
                return NotFound();
            }
            _personRepository.GetPerson(JMBG);
            return Ok(PersonstoReturn);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            _personRepository.Add(person);
            return Ok();
        }

        [HttpPut("{JMBG}")]
        public IActionResult Update(long JMBG, [FromBody] Person updatePerson)
        {
            if (updatePerson == null || updatePerson.JMBG != JMBG)
            {
                return BadRequest();
            }

            var newPerson = _personRepository.GetPerson(JMBG);
            if (newPerson == null)
            {
                return NotFound();
            }

            newPerson.FirstName = updatePerson.FirstName;
            newPerson.SecondName = updatePerson.SecondName;
            newPerson.JMBG = updatePerson.JMBG;
            newPerson.Gender = updatePerson.Gender;
            newPerson.Occupation = updatePerson.Occupation;

            _personRepository.Update(newPerson);
            return Ok();
        }

        [HttpDelete("{JMBG}")]
        public IActionResult Delete(long JMBG)
        {
            var person = _personRepository.Find(JMBG);
            if (person == null)
            {
                return NotFound();
            }

            _personRepository.Remove(JMBG);
            return Ok();
        }

    }
}

