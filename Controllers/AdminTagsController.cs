using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class AdminTagsController : Controller
    {
        //https://localhost:7193/AdminTags/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
