using LearnDevOps.Automation.Functions.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(LearnDevOps.Automation.Functions.Startup))]
namespace LearnDevOps.Automation.Functions
{
    internal class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IJobService, JobService>();
            builder.Services.AddScoped<IJobFunctionHandler, JobFunctionHandler>();
        }
    }
}
