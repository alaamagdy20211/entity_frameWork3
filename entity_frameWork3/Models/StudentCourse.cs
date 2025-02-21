using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace entity_frameWork3.Models
{
    public class StudentCourse
    {
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public int grade { get; set; }

        public  Course Course { get; set; }
        public  Student Student { get; set; }
    }
}
