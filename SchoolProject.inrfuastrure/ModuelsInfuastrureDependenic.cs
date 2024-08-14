using Microsoft.Extensions.DependencyInjection;
using SchoolProject.inrfuastrure.Abstracts;
using SchoolProject.inrfuastrure.Repositoirs;

namespace SchoolProject.inrfuastrure
{
    public static class ModuelsInfuastrureDependenic
    {
        public static IServiceCollection AddInfuastrureDependenic(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository,StudentRepository>();
            return services;
        }
    }
}
