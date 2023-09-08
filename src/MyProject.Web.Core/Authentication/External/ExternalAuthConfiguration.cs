using System.Collections.Generic;
using Abp.Dependency;

namespace MyProject.Authentication.External
{
    public class ExternalAuthConfiguration : IExternalAuthConfiguration, ISingletonDependency
    {
        // bir web uygulaması Facebook, Google gibi dış kimlik sağlayıcılarına kullanıcıların giriş yapmasına
        // izin veriyorsa, bu sınıf bu sağlayıcıların yapılandırma bilgilerini saklamak için kullanılabilir.
        public List<ExternalLoginProviderInfo> Providers { get; }

        public ExternalAuthConfiguration()
        {
            Providers = new List<ExternalLoginProviderInfo>();
        }
    }
}
