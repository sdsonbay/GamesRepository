using Gameshop.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gameshop.Domain.Configurations;

public static class ConfigureServices
{
    public static void AddDomainServices(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPublisherService, PublisherService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IGameService, GameService>();
        services.AddScoped<ICreditCardService, CreditCardService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IAddressService, AddressService>();
    }
}