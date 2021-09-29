using RabbitMQ.Source.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RabbitMQ.Destination.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SourceEntityFrameworkCoreModule),
        typeof(DestinationApplicationContractsModule)
        )]
    public class DestinationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
