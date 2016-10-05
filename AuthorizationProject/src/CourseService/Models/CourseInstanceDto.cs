using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseService.Models
{
    public class CourseInstanceDto
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Semester { get; set; }
    }
}
