using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Class_Student_01_ProgrammingBasic2
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string StudentSurname { get; set; }

        public string StudentEmail { get; set; }

        public void DisplayStudentInfo()
        {
            Console.WriteLine(
                $"Student ID: {StudentID}, " +
                $"Student Name: {StudentName}, " +
                $"Student Code: {StudentSurname}, " +
                $"Student Email...: {StudentEmail}");
        }

        public void GetStudentList(List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                Console.WriteLine(
                    $"Student ID: {s.StudentID}, " +
                    $"Student Name: {s.StudentName}, " +
                    $"Student Surname: {s.StudentSurname}, " +
                    $"Student Email: {s.StudentEmail}");
            }
        }

        public Student RegisterStudent(int studentID, string studentName, 
            string studentSurname, string studentEmail)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentEmail = studentEmail;
            return this;
        }

        public Student? FindStudentByID(List<Student> students, int studentID)
        {
            return students.FirstOrDefault(c => c.StudentID == studentID);
        }



    }
}
