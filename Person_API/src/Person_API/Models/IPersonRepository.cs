using Person_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Models
{
     interface IPersonRepository
    {
        bool PersonExists(long JMBG);
        IEnumerable<Person> GetPeople();
        Person GetPerson(long JMBG);
        void Add(Person item);
        IEnumerable<Person> GetAll();
        Person Find(long key);
        void Remove(long key);
        void Update(Person item);
    }
}
