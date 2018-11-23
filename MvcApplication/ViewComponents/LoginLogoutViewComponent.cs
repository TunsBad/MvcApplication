using Microsoft.AspNetCore.Mvc;

namespace MvcApplication.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
