using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.BookStore.Controllers;

namespace Abp.BookStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BookStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
