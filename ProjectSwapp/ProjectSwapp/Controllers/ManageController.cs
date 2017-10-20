using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ProjectSwapp.Models;
using System.IO;
using System.Collections.Generic;

namespace ProjectSwapp.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [HttpGet]
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "You password change"
                : message == ManageMessageId.SetPasswordSuccess ? "Setted password"
                : message == ManageMessageId.Error ? "Error"
                : "";
            var userId = User.Identity.GetUserId();            
            var model = new IndexViewModel
            {
                HasPassword = HasPassword(),
                PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
                TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
                Logins = await UserManager.GetLoginsAsync(userId),
                BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId),
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);
            return View(model);
        }

        [HttpGet]
        public ActionResult SetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                    if (user != null)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    }
                    return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Posts()
        {
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                ViewBag.item = user.Posts;
            }
            return View();
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            GetDropDownListValue();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(RegisterPostViewModel model, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid && Image != null)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(Image.InputStream))
                    {
                        imageData = binaryReader.ReadBytes(Image.ContentLength);
                    }
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        model.ImageData = imageData;
                        var post = new  SwappPosts
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = model.Name,
                            Description = model.Description,
                            Address = model.City.ToString(),
                            DateFunction = model.Date,
                            DateCreatePost = DateTime.Now.ToString("hh:mm:ss"),
                            Status = model.Status,
                            ImageData = model.ImageData,
                            SubCategoryId = model.Subcategory.ToString(),
                            UserId = user.Id
                        };
                        user.Posts.Add(post);                       
                    }
                    await UserManager.UpdateAsync(user);
                    return RedirectToAction("Posts", new { Message = "SaveSuccess" });
                }
            }
            else
            {
                GetDropDownListValue();
                return View();
            }
            return View(model);
        }

        //[HttpPost]
        //public async Task<ActionResult> RequestPost(SwappPosts PostId)
        //{
        //    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        using (ApplicationDbContext db = new ApplicationDbContext())
        //        {
        //            foreach (var post in db.SwappPosts.Where(i => i.Id == PostId.Id))
        //            {
        //                user.PostsRequest.Add(post);
        //            }
        //            await UserManager.UpdateAsync(user);
        //        }
        //        return RedirectToAction("Published", new { Message = "RequestSuccess" });
        //    }
        //    return View();
        //}



        //[HttpGet]
        //public async Task<ActionResult> Requestpublished()
        //{
        //    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        ViewBag.item = user.PostsRequest;
        //    }
        //    return View();
        //}

        [HttpPost]
        public async Task<ActionResult> Delete(string Id)
        {
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    foreach (var post in db. SwappPosts.Where(i => i.Id == Id))
                    {
                        db. SwappPosts.Remove(post);
                    }
                    await db.SaveChangesAsync();
                }
                return RedirectToAction("Posts", new { Message = "DeleteSuccess" });
            }
            return View();

        }

        private void GetDropDownListValue()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            SelectList Region = new SelectList(db.SwappAdrRegionPost.ToList(), "Id", "Region", db.SwappAdrRegionPost.FirstOrDefault().Id);
            ViewBag.Region = Region;
            SelectList City = new SelectList(db.SwappAdrCityPost.Where(i => i.SwappAdrRegionPostId == db.SwappAdrRegionPost.FirstOrDefault().Id), "Id", "City");
            ViewBag.City = City;
            SelectList Category = new SelectList(db.SwappCategory.ToList(), "Id", "Name", db.SwappCategory.FirstOrDefault().Id);
            ViewBag.Category = Category;
            SelectList Subcategory = new SelectList(db.SwappSubCategory.Where(i => i.SwappCategoryId == db.SwappCategory.FirstOrDefault().Id), "Id", "Name");
            ViewBag.Subcategory = Subcategory;
        }

        [HttpGet]
        public ActionResult GetItemsCity(string id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return PartialView(db.SwappAdrCityPost.Where(i => i.SwappAdrRegionPostId == id).ToList());
            }
        }

        [HttpGet]
        public ActionResult GetItemsCategory(string id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return PartialView(db.SwappSubCategory.Where(i => i.SwappCategoryId == id).ToList());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

    }
}