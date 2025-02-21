using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_frameWork3.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<StudentCourse> studentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
