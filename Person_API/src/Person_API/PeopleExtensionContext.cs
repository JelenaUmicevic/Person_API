using Person_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API
{
    public static class PeopleExtensionContext
    {
        public static void EnsureSeedDataForContext(this PpContext context)
        {
            if (context.People.Any())
            {
                return;
            }
            var people=new List<Person>()
            { 

               new Person()
                {
                    FirstName = "Zdravka",
                    SecondName = "Umicevic",
                    JMBG = 1512992805053,
                    Gender = "Female",
                    Occupation = "student"
               } };
            context.People.AddRange(people);
            context.SaveChanges();
            }
        }
    
}
