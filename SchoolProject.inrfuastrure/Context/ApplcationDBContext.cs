using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.inrfuastrure.Data
{
    public class ApplcationDBContext:DbContext
    {
        public ApplcationDBContext()
        {
            
        }
        public ApplcationDBContext(DbContextOptions<ApplcationDBContext>options):base(options) 
        {
            
        }
        public DbSet<Department>departments { get; set; }
        public DbSet<Student>students { get; set; } 
        public DbSet<Subjects>subjects { get; set; }
        public DbSet<DepartmetSubject>departmetSubjects { get; set;}
        public DbSet<StudentSubject>studentsSubject { get; set; }   
    }
}
