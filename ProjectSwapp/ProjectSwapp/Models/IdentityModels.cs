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
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public SwappPoints Points { get; set; }
        public virtual ICollection<SwappPosts> Posts { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class SwappPoints
    {
        public string Id { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public int Points { get; set; }
        public int? Earned { get; set; }
        public int? Spent { get; set; }
        public DateTime Date { get; set; }
    }

    public class SwappPosts
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set;}
        public string DateCreatePost { get; set; }
        public string Status { get; set; }
        public byte[] ImageData { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string SubCategoryId { get; set; }
        public SwappSubCategory SubCategory { get; set; }
    }

    public class SwappCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SwappSubCategory> SubCategory { get; set; }
    }

    public class SwappSubCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string SwappCategoryId { get; set; }
        public SwappCategory SwappCategory { get; set; }
    }

    public class SwappAdrRegionPost
    {
        public string Id { get; set; }
        public string Region { get; set; }
        public virtual ICollection<SwappAdrCityPost> AddressCityPost { get; set; }
    }

    public class SwappAdrCityPost
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string SwappAdrRegionPostId { get; set; }
        public SwappAdrRegionPost SwappAdrRegionPost { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<SwappPosts> SwappPosts { get; set; }
        public DbSet<SwappCategory> SwappCategory { get; set; }
        public DbSet<SwappSubCategory> SwappSubCategory { get; set; }
        public DbSet<SwappAdrRegionPost> SwappAdrRegionPost { get; set; }
        public DbSet<SwappAdrCityPost> SwappAdrCityPost { get; set; }
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