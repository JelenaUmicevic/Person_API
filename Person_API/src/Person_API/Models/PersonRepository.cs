using Person_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Models
{
    public class PersonRepository : IPersonRepository
    {
        private  PpContext _context;

        public PersonRepository(PpContext context)
        {
            _context = context;
            //Add(new Person { FirstName = "Item1" });
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.People.OrderBy(c => c.FirstName).ToList();
        }

        public void Add(Person item)
        {
            _context.People.Add(item);
            _context.SaveChanges();
        }

        public Person Find(long JMBG)
        {
            return _context.People.FirstOrDefault(c => c.JMBG == JMBG);
        }

        public void Remove(long JMBG)
        {
            var entity = _context.People.First(c => c.JMBG == JMBG);
            _context.People.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Person item)
        {
            _context.People.Update(item);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.OrderBy(c => c.FirstName).ToList();
        }

        public Person GetPerson(long JMBG)
        {
            return _context.People.Where(c => c.JMBG == JMBG).FirstOrDefault();
        }

        public bool PersonExists(long JMBG)
        {
            return _context.People.Any(c => c.JMBG == JMBG);
        }
    }
}
