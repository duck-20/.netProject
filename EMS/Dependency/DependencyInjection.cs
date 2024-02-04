using EMS.Services.Interface;

namespace EMS.Dependency
{
    public class DependencyInjection
    {
        public void configurationService(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IEmployeeInfo, IEmployeeInfo>();
        }
    }
}
