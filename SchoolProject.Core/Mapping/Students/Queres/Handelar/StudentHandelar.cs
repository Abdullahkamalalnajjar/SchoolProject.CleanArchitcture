using MediatR;
using SchoolProject.Core.Mapping.Students.Queres.Moduls;
using SchoolProject.Data.Entites;
using SchoolProject.Service.Abstractic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students.Queres.Handelar
{
    public class StudentHandelar : IRequestHandler<GetStudentListQuerey, List<Student>>
    {

        #region filds
        private readonly IStudentService _studentService;
        #endregion
        #region constractore
        public StudentHandelar(IStudentService  StudentService)
        {
            _studentService = StudentService;
        }

        #endregion
        #region handaler funcation
        #endregion
        public async Task<List<Student>> Handle(GetStudentListQuerey request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsListAsync();
        }
    }
}
