﻿using ITLab.Cabinet.Logic.DTOModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITLab.Cabinet.Logic.Queries.Interfaces
{
    public interface ILessonsQueries
    {
        Task<IEnumerable<LessonDTO>> GetLessonsAsync(int courseId, int studentId);
        Task<IEnumerable<DetailedLessonDTO>> GetLessonByLessonId(int lessonId, int studentId);
    }
}
