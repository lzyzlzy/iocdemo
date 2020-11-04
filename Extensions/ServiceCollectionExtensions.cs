using iocdemo.Interfaces;

namespace iocdemo
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSingleton<IService, IImplService>(this IServiceCollection serviceCollection)
        {
            serviceCollection.Add(new ServiceDescriptor(typeof(IService), typeof(IImplService), ServiceLifeTime.Singleton));
            return serviceCollection;
        }
        public static IServiceCollection AddScoped<IService, IImplService>(this IServiceCollection serviceCollection)
        {
            serviceCollection.Add(new ServiceDescriptor(typeof(IService), typeof(IImplService), ServiceLifeTime.Scoped));
            return serviceCollection;
        }

        public static IServiceCollection AddTransient<IService, IImplService>(this IServiceCollection serviceCollection)
        {
            serviceCollection.Add(new ServiceDescriptor(typeof(IService), typeof(IImplService), ServiceLifeTime.Transient));
            return serviceCollection;
        }

        public static IServiceProvider BuildProvider(this IServiceCollection serviceCollection)
        {
            return new ServiceProvider(serviceCollection);
        }
    }
}
