using System.Reflection;
using Gameshop.Application.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Gameshop.Application.Configurations;

public static class ConfigureServices
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        
        services.AddMediatR(typeof(GetAllUsersQuery));
        services.AddMediatR(typeof(GetAllUsersQueryHandler));
    }
}