using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearnArchitecturePractice.Application
{
    // DI for Program.cs in CleanArchitecturePractice.API
    public static class DependencyInjection
    {
        // 'this' as parameter makes this an 'extension method'
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
