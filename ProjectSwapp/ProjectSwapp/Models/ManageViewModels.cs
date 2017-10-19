using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSwapp.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The value must contain at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmation new password")]
        [Compare("NewPassword", ErrorMessage = "'Password' and 'Password confirmation' does not match")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The value must contain at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "'Password' and 'Password confirmation' does not match")]
        public string ConfirmPassword { get; set; }
    }
    public class RegisterViewModelPost
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Please input Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input Description")]
        [MinLength(5, ErrorMessage = "The value must contain at least 5 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please input Date")]
        public DateTime Date { get; set; }
        public int Points { get; set; }
        public string Status { get; set; }
        public byte[] ImageData { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        //public List<System.Web.Mvc.SelectListItem> Category { get; set; }
        //public List<System.Web.Mvc.SelectListItem> Subcategory { get; set; }
        //public List<System.Web.Mvc.SelectListItem> Region { get; set; }
        //public List<System.Web.Mvc.SelectListItem> City { get; set; }
        //[Required(ErrorMessage = "Please input Region")]
        //public IEnumerable<System.Web.Mvc.SelectListItem> Region { get; set; }
        //[Required(ErrorMessage = "Please input City")]
        //public IEnumerable<System.Web.Mvc.SelectListItem> City { get; set; }
        //public IEnumerable<System.Web.Mvc.SelectListItem> Category { get; set; }
        //public IEnumerable<System.Web.Mvc.SelectListItem> Subcategory { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }
    }
    public class RegisterViewModelStatusPost
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public RegisterViewModelUser RegisterViewModelUser { get; set; }
        public string Name { get; set; }
    }
}
    //public List<System.Web.Mvc.SelectListItem> getAllCategoryList()
    //{
    //    List<System.Web.Mvc.SelectListItem> myList = new List<System.Web.Mvc.SelectListItem>();
        
    //    using (ApplicationDbContext db = new ApplicationDbContext())
    //    {
    //        var data = db.ApplicationCategory;
    //        myList = d
    //    }
    //}