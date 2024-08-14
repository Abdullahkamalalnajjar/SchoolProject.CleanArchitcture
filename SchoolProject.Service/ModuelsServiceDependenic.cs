using Microsoft.Extensions.DependencyInjection;
using SchoolProject.inrfuastrure.Abstracts;
using SchoolProject.inrfuastrure.Repositoirs;
using SchoolProject.Service.Abstractic;
using SchoolProject.Service.Implamentation;

namespace SchoolProject.Service
{
    public static class ModuelsServiceDependenic
    {
     public static IServiceCollection AddServiceDependenic(this IServiceCollection services)
        {
            services.AddTransient<IStudentService,StudentService>();
            return services;
        }
    }
}

