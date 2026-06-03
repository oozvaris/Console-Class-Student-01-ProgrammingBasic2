using DAL.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Class_Student_01_ProgrammingBasic2
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task DisplayAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllAsync();
            foreach (var student in students)
            {
                Console.WriteLine(
                    $"Student ID: {student.StudentID}, " +
                    $"Student Name: {student.StudentName}, " +
                    $"Student Surname: {student.StudentSurname}, " +
                    $"Student Email: {student.StudentEmail}");
            }
        }

        public async Task DisplayStudentByIdAsync(int studentId)
        {
            var student = await _studentRepository.GetByIdAsync(studentId);
            if (student != null)
            {
                Console.WriteLine(
                    $"Student ID: {student.StudentID}, " +
                    $"Student Name: {student.StudentName}, " +
                    $"Student Surname: {student.StudentSurname}, " +
                    $"Student Email: {student.StudentEmail}");
            }
            else
            {
                Console.WriteLine($"No student found with ID: {studentId}");
            }
        }

        public async Task DisplayStudentByNameAsync(string studentName)
        {
            var student = await _studentRepository.GetByNameAsync(studentName);
            if (student != null)
            {
                Console.WriteLine(
                    $"Student ID: {student.StudentID}, " +
                    $"Student Name: {student.StudentName}, " +
                    $"Student Surname: {student.StudentSurname}, " +
                    $"Student Email: {student.StudentEmail}");
            }
            else
            {
                Console.WriteLine($"No student found with ID: {studentName}");
            }
        }

    }
}
