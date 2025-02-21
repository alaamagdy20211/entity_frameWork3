using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_frameWork3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
        public int? age { get; set; }

        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public ICollection<StudentCourse>studentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
