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

            // Это сообщение означает наличие ошибки; повторное отображение формы
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Published()
        {
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                ViewBag.item = user.Posts;
            }
            return View();
        }

        [HttpGet]
        public ActionResult Addpublished()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string selectedIndexRegion = "3c5c16c3-8ab8-416c-8996-a4dd1a26dcd2";
            string selectedIndexCategory = "56bf8121-329a-4ef0-9805-ae754e1f2dee";
            SelectList Region = new SelectList(db.ApplicationAddressRegionPost.ToList(), "Id", "Region", selectedIndexRegion);
            ViewBag.Region = Region;
            SelectList City = new SelectList(db.ApplicationAddressCityPost.Where(i => i.ApplicationAddressRegionPostId == selectedIndexRegion), "Id", "City");
            ViewBag.City = City;
            SelectList Category = new SelectList(db.ApplicationCategory.ToList(), "Id", "Name", selectedIndexCategory);
            ViewBag.Category = Category;
            SelectList Subcategory = new SelectList(db.ApplicationSubCategory.Where(i => i.ApplicationCategoryId == selectedIndexCategory), "Id", "Name");
            ViewBag.Subcategory = Subcategory;
            return View();  
        }
        [HttpGet]
        public ActionResult GetItems(string id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return PartialView(db.ApplicationAddressCityPost.Where(i => i.ApplicationAddressRegionPostId == id).ToList());
            }
        }
        [HttpGet]
        public ActionResult GetItemsCategory(string id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return PartialView(db.ApplicationSubCategory.Where(i => i.ApplicationCategoryId == id).ToList());
            }
        }
        [HttpPost]
        public async Task<ActionResult> Addpublished(RegisterViewModelPost model, HttpPostedFileBase Image)
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
                        var post = new ApplicationPost
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
                    return RedirectToAction("Published", new { Message = "SaveSuccess" });
                }
            }
            else
            {
                ApplicationDbContext db = new ApplicationDbContext();
                string selectedIndexRegion = "3c5c16c3-8ab8-416c-8996-a4dd1a26dcd2";
                string selectedIndexCategory = "56bf8121-329a-4ef0-9805-ae754e1f2dee";
                SelectList Region = new SelectList(db.ApplicationAddressRegionPost.ToList(), "Id", "Region", selectedIndexRegion);
                ViewBag.Region = Region;
                SelectList City = new SelectList(db.ApplicationAddressCityPost.Where(i => i.ApplicationAddressRegionPostId == selectedIndexRegion), "Id", "City");
                ViewBag.City = City;
                SelectList Category = new SelectList(db.ApplicationCategory.ToList(), "Id", "Name", selectedIndexCategory);
                ViewBag.Category = Category;
                SelectList Subcategory = new SelectList(db.ApplicationSubCategory.Where(i => i.ApplicationCategoryId == selectedIndexCategory), "Id", "Name");
                ViewBag.Subcategory = Subcategory;
                return View();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string Id)
        {
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    foreach (var post in db.ApplicationPost.Where(i => i.Id == Id))
                    {
                        db.ApplicationPost.Remove(post);
                    }
                    await db.SaveChangesAsync();
                }
                return RedirectToAction("Published", new { Message = "DeleteSuccess" });
            }
            return View();

        }

        //[HttpPost]
        //public async Task<ActionResult> Requestpost(ApplicationPost PostId)
        //{
        //    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        using (ApplicationDbContext db = new ApplicationDbContext())
        //        {
        //            foreach (var post in db.ApplicationPost.Where(i => i.Id == PostId.Id))
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
        //public async Task <ActionResult> Requestpublished()
        //{
        //    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
        //    if (user != null)
        //    {
        //        ViewBag.item = user.PostsRequest;
        //    }
        //    return View();
        //}


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