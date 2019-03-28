using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace denizdikbiyik_CET322_HW2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}
