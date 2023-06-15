using CleanArch.Domain.Inferfaces;
using CleanArch.Infra.Data.DataContext;
using CleanArch.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProjectDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("ConexaoDoProjecro"
            ), b => b.MigrationsAssembly(typeof(ProjectDbContext).Assembly.FullName)));

            //AddScoped é o recumendado para as applicações web
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<IProduct, ProductRepository>();

            return services;
        }
    }
}
