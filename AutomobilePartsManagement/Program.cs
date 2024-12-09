using AutomobilePartsManagement.Models;
using AutomobilePartsManagement.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace AutomobilePartsManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddControllersWithViews().AddJsonOptions(
             options =>
             {
                 options.JsonSerializerOptions.PropertyNamingPolicy = null;
                 //options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                 options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
                 options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                 options.JsonSerializerOptions.WriteIndented = true;
                  });

                 //1-ConnectionString as a Middleware
                 builder.Services.AddDbContext<AmpartsMngtContext>(
                 options => options.UseSqlServer(builder.Configuration.GetConnectionString("PropelConnection")));

                 //2-Register repository and service layer
                 builder.Services.AddScoped<IAutomobileRepository, AutomobileRepository>();

                 var app = builder.Build();

                 // Configure the HTTP request pipeline.

                 app.UseHttpsRedirection();

                 app.UseAuthorization();


                 app.MapControllers();

                 app.Run();
        }
    }
}
