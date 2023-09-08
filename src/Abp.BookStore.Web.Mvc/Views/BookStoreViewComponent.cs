using Abp.AspNetCore.Mvc.ViewComponents;

namespace Abp.BookStore.Web.Views
{
    public abstract class BookStoreViewComponent : AbpViewComponent
    {
        protected BookStoreViewComponent()
        {
            LocalizationSourceName = BookStoreConsts.LocalizationSourceName;
        }
    }
}
