using Microsoft.Extensions.DependencyInjection;

namespace PPTGenerator.Input
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Input.Start();
            
        }

        public static void ConfigureServices(IServiceCollection services)
        {

        }
    }
}
