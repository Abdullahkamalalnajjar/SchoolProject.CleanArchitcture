
using Microsoft.EntityFrameworkCore;
using SchoolProject.inrfuastrure;
using SchoolProject.Core;
using SchoolProject.Service;
using SchoolProject.inrfuastrure.Data;

namespace SchoolProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Connection SQL ***************Se7a***************
            builder.Services.AddDbContext<ApplcationDBContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
            });
            #region dependancy angaction
            //dependancy angaction

            builder.Services.AddInfuastrureDependenic()
                .AddServiceDependenic()
                .AddCoreDependenic();

            //حل مؤقت 
            //builder.Services.AddTransient<IStudentService, StudentService>();


            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
