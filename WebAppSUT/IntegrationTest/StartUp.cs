using EPShope.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductDataApi.Data;
using ProductDataApi.Repository;

namespace BddWebSUT.IntegrationTest
{
    public class StartUp
    {
        private static readonly ServiceProvider _serviceProvider;
        static StartUp()
        {
            IServiceCollection services = new ServiceCollection();

            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new string[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(projectPath).AddJsonFile("appsettings.json").Build();
            services.AddDbContext<ProductDbContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("ProductConnectionString")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IApiHelper, ApiHelper>();
            _serviceProvider = services.BuildServiceProvider();
        }

        protected static T GetService<T>() => _serviceProvider.GetRequiredService<T>();
    }
}
