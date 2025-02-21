using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_frameWork3.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        [Column(TypeName ="money")]
        public int Salary { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}
