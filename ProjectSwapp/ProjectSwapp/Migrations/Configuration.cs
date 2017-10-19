namespace ProjectSwapp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectSwapp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectSwapp.Models.ApplicationDbContext context)
        {
            context.ApplicationAddressRegionPost.Add(
              new Models.ApplicationAddressRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Minsk region",
                  AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Minsk"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Borisov"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Krupki"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Logoisk"
                        }
                   }
              });
            context.ApplicationAddressRegionPost.Add(
                new Models.ApplicationAddressRegionPost
                {
                    Id = Guid.NewGuid().ToString(),
                    Region = "Brest region",
                    AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Brest"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Lyahovichi"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ivacevichi"
                        }
                   }
                });
            context.ApplicationAddressRegionPost.Add(
              new Models.ApplicationAddressRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Grodno region",
                  AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Grodno"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slonim"
                        }
                   }
              });
            context.ApplicationAddressRegionPost.Add(
              new Models.ApplicationAddressRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Mogilev region",
                  AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mogilev"
                        },
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slonim"
                        }
                   }
              });
            context.ApplicationAddressRegionPost.Add(
              new Models.ApplicationAddressRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Gomel region",
                  AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Gomel"
                        }
                   }
              });
            context.ApplicationAddressRegionPost.Add(
              new Models.ApplicationAddressRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Vitebsk region",
                  AddressCityPost = new List<Models.ApplicationAddressCityPost>()
                   {
                        new Models.ApplicationAddressCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Vitebsk"
                        }
                   }
              });


 context.ApplicationCategory.Add(
                new Models.ApplicationCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Style",
                    SubCategory = new List<Models.ApplicationSubCategory>()
                    {
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men clothes",
                            Points = 10
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Woman clothes",
                            Points = 10
                        },
                         new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men shoes",
                            Points = 10
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Woman shoes",
                            Points = 10
                        },
                         new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men clothes",
                            Points = 10
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Clocks",
                            Points = 8
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Other",
                            Points = 8
                        }
                    }
                });
            context.ApplicationCategory.Add(
                new Models.ApplicationCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Technic",
                    SubCategory = new List<Models.ApplicationSubCategory>()
                    {
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Audio",
                            Points = 15
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "TV and video",
                            Points = 15
                        },
                         new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Computer",
                            Points = 15
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Phone",
                            Points = 10
                        },
                         new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Other",
                            Points = 10
                        }
                    }
                });
            context.ApplicationCategory.Add(
                new Models.ApplicationCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Auto",
                    SubCategory = new List<Models.ApplicationSubCategory>()
                    {
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Tires and wheels",
                            Points = 20
                        },
                        new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Passenger car",
                            Points = 50
                        },
                         new Models.ApplicationSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Services for car",
                            Points = 20
                        }
                    }
                });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
