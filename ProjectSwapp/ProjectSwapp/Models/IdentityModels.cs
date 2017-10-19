using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjectSwapp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public ApplicationPoints Points { get; set; }
        public virtual ICollection<ApplicationPost> Posts { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }
    public class ApplicationPoints
    {
        public string Id { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public int Points { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public DateTime Date { get; set; }
    }

    public class ApplicationPost
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set;}
        public DateTime DateFunction { get; set; }
        public string DateCreatePost { get; set; }
        public string Status { get; set; }
        public byte[] ImageData { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string SubCategoryId { get; set; }
        public ApplicationSubCategory SubCategory { get; set; }
    }

    #region Category
    public class ApplicationCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationSubCategory> SubCategory { get; set; }
    }
    public class ApplicationSubCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string ApplicationCategoryId { get; set; }
        public ApplicationCategory ApplicationCategory { get; set; }
        public virtual ICollection<ApplicationPost> Posts { get; set; }
    }
    #endregion
    #region Region
    public class ApplicationAddressRegionPost
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public virtual ICollection<ApplicationAddressCityPost> AddressCityPost { get; set; }
    }
    public class ApplicationAddressCityPost
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string ApplicationAddressRegionPostId { get; set; }
        public ApplicationAddressRegionPost ApplicationAddressRegionPost { get; set; }
    }
    #endregion 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationPost> ApplicationPost { get; set; }
        public DbSet<ApplicationCategory> ApplicationCategory { get; set; }
        public DbSet<ApplicationSubCategory> ApplicationSubCategory { get; set; }
        public DbSet<ApplicationAddressRegionPost> ApplicationAddressRegionPost { get; set; }
        public DbSet<ApplicationAddressCityPost> ApplicationAddressCityPost { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}