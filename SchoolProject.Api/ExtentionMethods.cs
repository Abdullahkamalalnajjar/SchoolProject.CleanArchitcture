using SchoolProject.Service.Abstractic;
using SchoolProject.Service.Implamentation;

namespace SchoolProject.Api.ExtentionMethods
{
    public static class ExtentionMethods
    {
        public static IServiceCollection AddServiceDependenic(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
