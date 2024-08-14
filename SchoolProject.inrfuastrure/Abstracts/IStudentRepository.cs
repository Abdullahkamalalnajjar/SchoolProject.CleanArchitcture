﻿using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.inrfuastrure.Abstracts
{
    public interface IStudentRepository
    {
      
        public Task <List<Student>> GetStudentsListAsync();
    }
}
