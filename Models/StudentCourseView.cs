﻿namespace GraderApp.Models
{
    public class StudentCourseView
    {
        public StudentCourseView(int? idCourse, string? courseTitle, string? courseSemester, int? courseGradeStudent)
        {
            IdCourse = idCourse;
            CourseTitle = courseTitle;
            CourseSemester = courseSemester;
            CourseGradeStudent = courseGradeStudent;
        }

        public int? IdCourse { get; set; }
        public string? CourseTitle { get; set; }
        public string? CourseSemester { get; set; }
        public int? CourseGradeStudent { get; set; }

    }
}
