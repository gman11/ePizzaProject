using ePizza.Application;
using ePizza.Infrastructure;
namespace ePizza.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          // Add services to the container.



            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
          
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // added reference of Application Layer
            builder.Services.AddAutoMapper(typeof(ApplicationAssemblyMarker).Assembly);
            builder.Services.AddApplication();


            // adding reference of Infra layer
            builder.Services.AddAutoMapper(typeof(InfraAssemblyMarker).Assembly);
            builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("DatabaseConnection")!);


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
