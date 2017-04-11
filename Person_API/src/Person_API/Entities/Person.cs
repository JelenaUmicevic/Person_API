using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Entities
{
    public class Person
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JMBG { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string SecondName { get; set; }
       
        public string Gender { get; set; }
        [MaxLength(200)]
        public string Occupation { get; set; }
        //public bool IsComplete { get; set; }
    }
}
