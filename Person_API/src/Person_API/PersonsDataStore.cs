using Person_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API
{
    public class PersonsDataStore
    {
        public static PersonsDataStore Current { get; } = new PersonsDataStore();

        public List<PersonsDTO> Persons { get; set; }

        public PersonsDataStore()
        {
            Persons = new List<PersonsDTO>()
            {
                new PersonsDTO
                {
                    FirstName="Zdravka",
                    SecondName="Umicevic",
                    JMBG=1512992805053,
                    Gender= "Female",
                    Occupation="student"
                },
                new PersonsDTO
                {
                    FirstName="Aca",
                    SecondName="Dickov",
                    JMBG=2511992805053,
                    Gender= "Male",
                    Occupation="student"
                },
                new PersonsDTO
                {
                    FirstName="Ana",
                    SecondName="Banana",
                    JMBG=1301994805053,
                    Gender= "Female",
                    Occupation="student"
                }
            };
        }

    }
}
