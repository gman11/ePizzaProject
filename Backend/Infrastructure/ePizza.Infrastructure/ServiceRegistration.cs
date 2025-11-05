using System;
using ePizza.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ePizza.Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string connectionString)
    {

        services.AddDbContext<EPizzaDbContext>(option =>
        {
            option.UseSqlServer(connectionString);
        });

        return services;
    }
}
