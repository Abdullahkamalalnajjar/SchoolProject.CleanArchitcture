using SchoolProject.Data.Entites;
using SchoolProject.inrfuastrure.Abstracts;
using SchoolProject.Service.Abstractic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implamentation
{
    public class StudentService : IStudentService
    {
        #region filds
        private readonly IStudentRepository _studentRepository;
        #endregion
        #region constractor
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion
        #region handel funcation
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsListAsync();
        }
        #endregion
    }
}
