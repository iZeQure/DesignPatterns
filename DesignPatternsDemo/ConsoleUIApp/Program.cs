using FactoryPatternLibrary.Abstractions;
using FactoryPatternLibrary.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepositoryPatternLibrary.Repositories.User;

namespace ConsoleUIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            var startup = ActivatorUtilities.CreateInstance<Startup>(host.Services);

            startup.StartDemo();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder()
                //.ConfigureAppConfiguration((hostingContext, configuration) =>
                //{
                //    BuildConfiguration(hostingContext.HostingEnvironment.EnvironmentName, configuration);
                //})
                .ConfigureServices((context, service) =>
                {
                    ConfigureServices(service, context.Configuration);
                });

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserFactory, UserFactory>();
            services.AddScoped<IUserRepository, DbUserRepository>();
        }
    }
}
