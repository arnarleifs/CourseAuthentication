using System.Collections.Generic;
using CourseService.Models;

namespace CourseService.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseInstanceDto> GetAllCourses();
        CourseInstanceDto GetCourseById(int id);
        void AddCourse(CourseInstanceDto course);
    }
}
