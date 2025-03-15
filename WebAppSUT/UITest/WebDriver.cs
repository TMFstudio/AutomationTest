using BddWebSUT.Page;
using Microsoft.Extensions.DependencyInjection;
using WebFrameworkSUT.Infrastructure;

namespace BddWebSUT.UITest
{
    public class WebDriver
    {
        private static readonly ServiceProvider _serviceProvider;
        static WebDriver()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<IDriverUtilities, DriverUtilities>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<ILoginPage, LoginPage>();
            services.AddScoped<ICreateProductPage, CreateProductPage>();
            _serviceProvider = services.BuildServiceProvider();
        }

        protected static T GetService<T>() => _serviceProvider.GetRequiredService<T>();

    }
}
