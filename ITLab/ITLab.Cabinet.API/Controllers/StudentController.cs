﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITLab.Cabinet.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITLab.Cabinet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService _studentProfileService = new StudentService();

        [HttpGet]
        public object GetStudent(int studentId)
        {
            var response = _studentProfileService.GetStudent(studentId);
            return response;
        }

        [HttpGet]
        public object GetStudentCources(int studentId)
        {
            var response = _studentProfileService.GetStudentCources(studentId);
            return response;
        }
        
        [HttpGet]
        public object GetStudentLessons(int studentId)
        {
            var response = _studentProfileService.GetStudentLessons(studentId);
            return response;
        }
    }
}