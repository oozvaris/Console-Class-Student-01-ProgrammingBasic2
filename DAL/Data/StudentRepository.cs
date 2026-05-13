using DAL.Data.Interfaces;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString;
        public StudentRepository(IConfiguration configuration) {

            _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' was not found");


        }

        public async Task<IReadOnlyList<Student>> GetAllAsync()
        { 
            var students = new List<Student>();
            const string sql =  """
                                SELECT StudentID, StudentName, StudentSurname, 
                                    StudentEmail 
                                FROM Student
                                """;

            await using var connection = new SqlConnection(_connectionString);
            await using var command = new SqlCommand(sql, connection);
            await connection.OpenAsync();
            await using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var student = new Student
                {
                    StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                    StudentName = reader.GetString(reader.GetOrdinal("StudentName")),
                    StudentSurname = reader.GetString(reader.GetOrdinal("StudentSurname")),
                    StudentEmail = reader.GetString(reader.GetOrdinal("StudentEmail"))
                };
                students.Add(student);
            }

            return students;
        }

    }
}
