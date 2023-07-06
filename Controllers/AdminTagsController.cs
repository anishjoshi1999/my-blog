using blog.Data;
using blog.Models.Domain;
using blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogDbContext blogDbContext;
        //Constructor injection
        public AdminTagsController(BlogDbContext blogDbContext)
        {
           this.blogDbContext = blogDbContext;
        }
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
            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;

            //Mapping AddTagRequest to Tag domain model
            var tag = new Tag {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName
            };
            blogDbContext.Tags.Add(tag);
            blogDbContext.SaveChanges();
            return View("Add");
        }
    }
}
