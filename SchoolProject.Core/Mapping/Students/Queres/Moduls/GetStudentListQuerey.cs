using MediatR;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students.Queres.Moduls
{
    public class GetStudentListQuerey : IRequest<List<Student>>
    {

    }
}
