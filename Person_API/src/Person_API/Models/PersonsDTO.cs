using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Models
{
    public class PersonsDTO
    {
   
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public long JMBG { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public bool IsComplete { get; set; }
    }
}
