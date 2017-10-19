using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSwapp.Models
{
    public class RegisterViewModelUser
    {
        [Required(ErrorMessage = "Please input Name")]
        [MinLength(6, ErrorMessage = "The value must contain at least 6 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input Password")]
        [MinLength(6, ErrorMessage = "The value must contain at least 6 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please input Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password confirmation")]
        [Compare("Password", ErrorMessage = "Password and Password confirmation does not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please input Login")]
        [Display(Name = "Login")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please input Number of phone")]
        [Display(Name = "Number of phone")]
        public string PhoneNumber { get; set; }
        public RegisterViewModelPoints RegisterViewModelPoints { get; set; }
    }
    public class RegisterViewModelPoints
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public RegisterViewModelUser RegisterViewModelUser { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public DateTime Date { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
