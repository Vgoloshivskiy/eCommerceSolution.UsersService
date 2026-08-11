using System;
using System.Collections.Generic;
using System.Text;
using eCommerce.Infrastructure.DbContext;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjections
{
    /// <summary>
    /// Extension method to add infrastructure services to the dependency injection container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //TODO: Add infrastructure services to the IoC container
        services.AddSingleton<Core.RepositoryContracts.IUserRepository, Repositories.UserRepositories>();
        services.AddTransient<DapperDbContext>();
        return services;
    }
}
