using Microsoft.EntityFrameworkCore;
using Payroll.Application;
using Payroll.Infrastructure;

namespace EmployeeAllowance.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext, AllowanceDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("EmployeeAllowance.API")));

            services.AddScoped<IAllowanceService, AllowancesService>();
            services.AddScoped<IAllovanceRepository, AllowanceRepository>();
            return services;
        }
    }
}
