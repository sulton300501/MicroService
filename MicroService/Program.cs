
using MicroService.DAL;
using MicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            builder.Services.AddDbContext<MicroServiceDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresqlConnectionString"));
            });

            builder.Services.AddScoped<ICRUDService,CRUDService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
           
                app.UseSwagger();
                app.UseSwaggerUI();
           

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
