using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using denizdikbiyik_CET322_HW2.Models;

namespace denizdikbiyik_CET322_HW2.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext (DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<denizdikbiyik_CET322_HW2.Models.Student> Student { get; set; }

        public DbSet<denizdikbiyik_CET322_HW2.Models.Department> Department { get; set; }
    }
}
