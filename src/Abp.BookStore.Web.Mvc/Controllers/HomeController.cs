using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.BookStore.Controllers;

namespace Abp.BookStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
