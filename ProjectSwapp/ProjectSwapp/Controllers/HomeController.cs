using ProjectSwapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectSwapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ApplicationPost> Posts = new List<ApplicationPost>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                foreach (var Post in db.ApplicationPost)
                {
                    Posts.Add(Post);
                }
            }
            ViewBag.item = Posts;
            return View();
        }
    }
}