using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
