using blog.Models.ViewModels;
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
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            //var name = Request.Form["name"];
            //var displayName = Request.Form["displayName"];
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            return View("Add");
        }
    }
}
