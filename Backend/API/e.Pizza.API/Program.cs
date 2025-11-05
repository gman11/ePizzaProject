using ePizza.Application;
using ePizza.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
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
            // builder.Services.AddAutoMapper()
            builder.Services.AddAutoMapper(cfg =>
             {
                // ⚠️ Required for AutoMapper 15+ if you are using the commercial/OSS dual license.
                // Replace <License Key Here> with your actual key if required.
                // If you are using it under the OSS license, this configuration block is still required.
                // cfg.LicenseKey = "<License Key Here>";

             }, typeof(ApplicationAssemblyMarker).Assembly);
            builder.Services.AddApplication();


            // adding reference of Infra layer
             builder.Services.AddAutoMapper(cfg =>
             {
                // ⚠️ Required for AutoMapper 15+ if you are using the commercial/OSS dual license.
                // Replace <License Key Here> with your actual key if required.
                // If you are using it under the OSS license, this configuration block is still required.
                // cfg.LicenseKey = "<License Key Here>";

             }, typeof(InfraAssemblyMarker).Assembly);
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
