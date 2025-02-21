﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_frameWork3.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; }= new HashSet<Employee>();
    }
}
