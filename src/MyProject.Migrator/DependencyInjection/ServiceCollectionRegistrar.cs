using Microsoft.Extensions.DependencyInjection;
using Castle.Windsor.MsDependencyInjection;
using Abp.Dependency;
using MyProject.Identity;

namespace MyProject.Migrator.DependencyInjection
{
    //Bu kod parçası, genellikle bir ASP.NET Core uygulamasının başlangıcında kullanılır.
    //ServiceCollectionRegistrar sınıfı, hizmet kayıtlarını toplar ve bir DI konteynerine ekler.
    //Bu, uygulamanın çeşitli bileşenleri arasında bağımlılıkları yönetmek ve hizmetlere erişimi kolaylaştırmak için kullanılır.
    //Bu sayede uygulama, bağımlılık enjeksiyonu (dependency injection) kullanarak hizmetlere erişebilir ve
    //bileşenler arası gevşek bağlılık sağlar.
    public static class ServiceCollectionRegistrar
    {
        public static void Register(IIocManager iocManager)
        {
            var services = new ServiceCollection();

            IdentityRegistrar.Register(services);

            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
        }
    }
}
