using System;
using System.Collections.Generic;
using System.Text;
using eCommerce.Core.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.Core.Validators;

namespace eCommerce.Core;

public static class DependencyInjections
{
    /// <summary>
    /// Extension method to add infrastructure services to the dependency injection container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        //TODO: Add infrastructure services to the IoC container
        services.AddTransient<Core.ServiceContracts.IUsersService, UsersService>();
        services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
        return services;
    }
}
