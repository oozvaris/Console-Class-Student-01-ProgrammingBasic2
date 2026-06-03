using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Interfaces
{
    public interface IStudentRepository
    {
        Task<IReadOnlyList<Models.Student>> GetAllAsync();

        Task<Student?> GetByIdAsync(int StudentID);

    }
}
