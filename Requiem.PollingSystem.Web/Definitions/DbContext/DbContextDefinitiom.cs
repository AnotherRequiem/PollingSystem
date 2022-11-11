using Microsoft.EntityFrameworkCore;
using Requiem.PollingSystem.Application;
using Requiem.PollingSystem.Web.Definitions.Base;

namespace Requiem.PollingSystem.Web.Definitions.DbContext;

public class DbContextDefinitiom : AppDefinition
{
    public override void ConfigureServices(IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration
                .GetConnectionString(nameof(ApplicationDbContext)));
        });
    }
}
