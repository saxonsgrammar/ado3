using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado3
{
    public class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}