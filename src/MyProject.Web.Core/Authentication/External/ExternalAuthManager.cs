using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;

namespace MyProject.Authentication.External
{
    //Bu kod parçası, dış kimlik doğrulama sağlayıcılarıyla (Facebook, Google vb.)
    //entegrasyon yapmak için kullanılabilir. Bu sağlayıcılar, kullanıcıların uygulamaya dış kimlikleriyle giriş yapmasını sağlar.
    public class ExternalAuthManager : IExternalAuthManager, ITransientDependency
    //ITransientDependency işareti, sınıfın bir geçici bağımlılık olduğunu gösterir, yani her istekte veya kullanımda
    //yeni bir örnek oluşturulur ve saklanmaz. Abp, bu işareti kullanarak bağımlılıkları otomatik olarak çözümler ve enjekte eder.
    //Kullanım durumunuza bağlı olarak, doğrudan DI kayıtları için AddTransient<> kullanabilir veya Abp çerçevesi
    //ile çalışıyorsanız sınıfları ITransientDependency ile işaretleyebilirsiniz.

    {
        private readonly IIocResolver _iocResolver;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;

        public ExternalAuthManager(IIocResolver iocResolver, IExternalAuthConfiguration externalAuthConfiguration)
        {
            _iocResolver = iocResolver;
            _externalAuthConfiguration = externalAuthConfiguration;
        }

        public Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode)
        {
            using (var providerApi = CreateProviderApi(provider))
            {
                return providerApi.Object.IsValidUser(providerKey, providerAccessCode);
            }
        }

        public Task<ExternalAuthUserInfo> GetUserInfo(string provider, string accessCode)
        {
            using (var providerApi = CreateProviderApi(provider))
            {
                return providerApi.Object.GetUserInfo(accessCode);
            }
        }

        public IDisposableDependencyObjectWrapper<IExternalAuthProviderApi> CreateProviderApi(string provider)
        {
            var providerInfo = _externalAuthConfiguration.Providers.FirstOrDefault(p => p.Name == provider);
            if (providerInfo == null)
            {
                throw new Exception("Unknown external auth provider: " + provider);
            }

            var providerApi = _iocResolver.ResolveAsDisposable<IExternalAuthProviderApi>(providerInfo.ProviderApiType);
            providerApi.Object.Initialize(providerInfo);
            return providerApi;
        }
    }
}
