﻿using System;
using System.Collections.Generic;
using System.Text;
using ITLab.Cabinet.Logic.Helpers.Sql;
using ITLab.Cabinet.Logic.Queries.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using ITLab.Cabinet.Logic.DTOModels;
using System.Linq;

namespace ITLab.Cabinet.Logic.Queries
{
    public class StudentQueries : IStudentQueries
    {
        public string _connectionString;
        public StudentQueries(IConnectionStringHelper helper)
        {
            _connectionString = helper.ConnectionString;
        }

        public List<CourseDTO> GetStudentCourses(int studentId)
        {
            var sqlquery = @$"
                SELECT Courses.Name
                    , Courses.Description
                FROM dbo.Courses
                    JOIN StudentsCourses on StudentsCourses.CourseId = Courses.CourseId
                    JOIN Students on Students.StudentId = StudentsCourses.StudentId
                WHERE Students.StudentId = {studentId}";

            var cources = new List<CourseDTO>();

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                cources = db.Query<CourseDTO>(sqlquery).ToList();
            }

            return cources;
        }

        public List<LessonDTO> GetStudentLessons(int studentId)
        {
            var sqlquery = @$"
                SELECT Lessons.Name
                    , Lessons.Description
                    , Lessons.CourseId
                FROM dbo.Lessons
                    JOIN Courses on Courses.CourseId = Lessons.CourseId
                    JOIN StudentsCourses on StudentsCourses.CourseId = Courses.CourseId
                    JOIN Students on Students.StudentId = StudentsCourses.StudentId
                WHERE Students.StudentId = {studentId};";

            var lessons = new List<LessonDTO>();

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                lessons = db.Query<LessonDTO>(sqlquery).ToList();
            }

            return lessons;
        }

        public StudentDTO GetStudent(int studentId)
        {
            var query = $@"
                SELECT [StudentId]
                    ,[Name]
                    ,[Password]
                    ,[AvatarPhoto]
                FROM [ITLab_Cabinet].[dbo].[Students]
                WHERE StudentId = @studentId";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<StudentDTO>(query, new { studentId }).FirstOrDefault();
            }
        }

    }
}
