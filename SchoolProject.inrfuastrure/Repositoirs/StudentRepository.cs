using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.inrfuastrure.Abstracts;
using SchoolProject.inrfuastrure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.inrfuastrure.Repositoirs
{
    public class StudentRepository : IStudentRepository
    {
        #region filds
        private readonly ApplcationDBContext _dbContext;
        #endregion

        #region Consractor
        public StudentRepository(ApplcationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        #endregion
        #region Handels Funcations
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbContext.students.ToListAsync();
        }
        #endregion

    }
}
