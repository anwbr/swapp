using ProjectSwapp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectSwapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SwappPosts> PostsList = new List<SwappPosts>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                foreach (var Post in db.SwappPosts)
                {
                    PostsList.Add(Post);
                }
            }
            ViewBag.item = PostsList;
            return View();
        }
    }
}