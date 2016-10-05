using System.Collections.Generic;
using CourseService.Models;
using CourseService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("", Name = "GetAllCourses")]
        public IEnumerable<CourseInstanceDto> GetAllCourses()
        {
            return _courseService.GetAllCourses();
        }

        [HttpGet]
        [Route("{courseId:int}", Name = "GetCourseById")]
        public CourseInstanceDto GetCourseById(int courseId)
        {
            return _courseService.GetCourseById(courseId);
        }


        [Authorize(Policy = "Teacher")]
        [HttpPost]
        [Route("", Name = "AddCourse")]
        public void AddCourse([FromBody]CourseInstanceDto course)
        {
            _courseService.AddCourse(course);
        }
    }
}
