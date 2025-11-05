using System;
using ePizza.Application.Contracts;
using ePizza.Application.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace ePizza.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddScoped<IItemService, ItemService>();

        return services;
    }
}
