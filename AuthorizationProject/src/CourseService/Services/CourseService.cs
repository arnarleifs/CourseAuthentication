using System.Collections.Generic;
using CourseService.Models;

namespace CourseService.Services
{
    public class CourseService : ICourseService
    {
        private List<CourseInstanceDto> _courses;
        public CourseService()
        {
            _courses = new List<CourseInstanceDto>();
            _courses.AddRange(new List<CourseInstanceDto> {
            new CourseInstanceDto
            {
                Id = 1,
                CourseCode = "T-111-PROG",
                CourseName = "Forritun",
                Semester = "20161"
            },
            new CourseInstanceDto
            {
                Id = 2,
                CourseCode = "P-652-AFL",
                CourseName = "Aflafræði",
                Semester = "20161"
            },
            new CourseInstanceDto
            {
                Id = 3,
                CourseCode = "T-625-GEGT",
                CourseName = "Högun leikjavéla",
                Semester = "20153"
            },
            new CourseInstanceDto
            {
                Id = 4,
                CourseCode = "T-522-ABC",
                CourseName = "Stafarófskennsla",
                Semester = "20153"
            },
            new CourseInstanceDto
            {
                Id = 5,
                CourseCode = "M-234-MARK",
                CourseName = "Markaðsfræði",
                Semester = "20151"
            }
            });
        }
        public IEnumerable<CourseInstanceDto> GetAllCourses()
        {
            return _courses;
        }

        public void AddCourse(CourseInstanceDto course)
        {
            _courses.Add(course);
        }

        public CourseInstanceDto GetCourseById(int id)
        {
            return _courses.Find(c => c.Id == id);
        }
    }
}
