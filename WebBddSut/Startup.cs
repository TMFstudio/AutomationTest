using Microsoft.Extensions.DependencyInjection;
using ProductDataApi.Repository;
using SolidToken.SpecFlow.DependencyInjection;
using WebBddSut.Page;
using WebFrameworkSUT.Infrastructure;

namespace EATestBDD;

public static class Startup
{
    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var services = new ServiceCollection();

        services.AddScoped<IHomePage, HomePage>();
        services.AddScoped<ICreateProductPage, CreateProductPage>();
        services.AddScoped<IDriverUtilities, DriverUtilities>();
        services.AddScoped<IBrowserDriver, BrowserDriver>();

        return services;
    }

}