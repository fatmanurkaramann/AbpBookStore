using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyProject.Configuration;
using MyProject.Web;

namespace MyProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */

    //IDesignTimeDbContextFactory<TContext> arabirimi, tasarım zamanı senaryoları için özel olarak oluşturulmuş bir yapıdır
    //ve veritabanı bağlamını tasarım zamanında oluşturmak ve yapılandırmak için kullanılır.
    //tasarım zamanı senaryoları uygulamanın çalışma zamanından önce yapılandırma veritabanı değişikliklerini içerir. 
    //örnek olarak uygulama ilk çalıştırıldığında db oluşturulabilir veya db ayarlarını uygulama çalışmadan önce belirlemek isteriz

    public class MyProjectDbContextFactory : IDesignTimeDbContextFactory<MyProjectDbContext>
    {
        public MyProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProjectDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyProjectConsts.ConnectionStringName));

            return new MyProjectDbContext(builder.Options);
        }
    }
}
