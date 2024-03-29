﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITLab.Cabinet.Logic.ReadServices;
using ITLab.Cabinet.Logic.ReadServices.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITLab.Cabinet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IStudentReadService _studentService;
        private readonly ICoursesReadService _coursesService;
        public CourseController(StudentReadService studentService, CoursesReadService coursesService)
        {
            _studentService = studentService;
            _coursesService = coursesService;
        }

        //TODO: rewrite using object to another type, like in .NET Framework - IActionResult

        [HttpPost]
        public object GetCourseSchedule()
        {
            var response = _coursesService.GetCourseSchedule();
            return response;
        }

        [HttpGet]
        public object GetStudentCourses(int studentId)
        {
            var response = _coursesService.GetStudentCourses(studentId);
            return response;
        }

        [HttpGet]
        public object GetCourseLessons(int courseId)
        {
            var lessons = _coursesService.GetCourseLessons(courseId);
            return lessons;
        }

        [HttpGet]
        public object GetStudentStatistics(int studentId, int courseId)
        {
            return _coursesService.GetStudentStatistics(studentId, courseId);
        }
    }
}
