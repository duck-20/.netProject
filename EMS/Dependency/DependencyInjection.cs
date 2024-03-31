using EMS.Services.Implementation;
using EMS.Services.Interface;

namespace EMS.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeInfo,EmployeeInfoService>();
            services.AddScoped<IDepartmentInfo,DepartmentInfoService>();
            return services;

        }
    }
}
