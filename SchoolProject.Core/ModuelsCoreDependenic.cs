using Microsoft.Extensions.DependencyInjection;
using SchoolProject.inrfuastrure.Abstracts;
using SchoolProject.inrfuastrure.Repositoirs;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuelsCoreDependenic
    {
        public static IServiceCollection AddCoreDependenic(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }

    }
}
