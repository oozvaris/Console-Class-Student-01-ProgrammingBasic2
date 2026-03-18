using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Class_Student_01_ProgrammingBasic2
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }

        public void DisplayCourseInfo()
        {
            Console.WriteLine(
                $"Course ID: {CourseID}, " +
                $"Course Name: {CourseName}, " +
                $"Course Code: {CourseCode}, " +
                $"Course Credit: {CourseCredit}");
        }

        public Course RegisterCourse (int courseID, string courseName, string courseCode, int courseCredit)
        {
            CourseID = courseID;
            CourseName = courseName;
            CourseCode = courseCode;
            CourseCredit = courseCredit;
            return this;
        }

        public List<Course> GetCourseList(List<Course> courses)
        {
            // List<Course> courses = new List<Course>();
            // courses.Add(this);
            foreach (Course c in courses)
            {
                Console.WriteLine(
                    $"Course ID: {c.CourseID}, " +
                    $"Course Name: {c.CourseName}, " +
                    $"Course Code: {c.CourseCode}, " +
                    $"Course Credit: {c.CourseCredit}");
            }
            return courses;
        }

        public Course FindCourseByID(List<Course> courses, int courseID)
        {
            return courses.FirstOrDefault(c => c.CourseID == courseID);
        }

        public List<Course> SearchCourseByName(List<Course> courses, string courseName)
        {
            return courses.Where(c => c.CourseName.Contains(courseName)).ToList();
        }

    }
}
