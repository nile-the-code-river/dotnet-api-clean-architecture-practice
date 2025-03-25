using ClearnArchitecturePractice.Application;
using ClearnArchitecturePractice.Infrastructure;

namespace CleanArchitecturePractice.API
{
    public static class DependencyInjection
    {
        // 'this' as parameter makes this an 'extension method'
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}
