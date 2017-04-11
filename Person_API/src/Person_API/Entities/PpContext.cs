using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person_API.Entities
{
    public class PpContext:DbContext
    {
        public PpContext(DbContextOptions<PpContext>options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> People { get; set; }

       
    }
}
