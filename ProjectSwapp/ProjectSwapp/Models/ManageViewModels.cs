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

    public class RegisterPostViewModel
    {
        [Required(ErrorMessage = "Please input Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input Description")]
        [MinLength(5, ErrorMessage = "The value must contain at least 5 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please input Date")]
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public byte[] ImageData { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Please choose Subcategory")]
        public string Subcategory { get; set; }
        public string Region { get; set; }
        [Required(ErrorMessage = "Please choose City")]
        public string City { get; set; }
    }
}