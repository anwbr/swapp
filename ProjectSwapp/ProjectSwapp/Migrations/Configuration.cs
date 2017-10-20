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

            context.SwappAdrRegionPost.Add(
              new Models.SwappAdrRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Minsk region",
                  AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Minsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Borisov"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Krupki"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Logoisk"
                        }
                   }
              });
            context.SwappAdrRegionPost.Add(
                new Models.SwappAdrRegionPost
                {
                    Id = Guid.NewGuid().ToString(),
                    Region = "Brest region",
                    AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Brest"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Lyahovichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ivacevichi"
                        }
                   }
                });
            context.SwappAdrRegionPost.Add(
              new Models.SwappAdrRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Grodno region",
                  AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Grodno"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slonim"
                        }
                   }
              });
            context.SwappAdrRegionPost.Add(
              new Models.SwappAdrRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Mogilev region",
                  AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mogilev"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slonim"
                        }
                   }
              });
            context.SwappAdrRegionPost.Add(
              new Models.SwappAdrRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Gomel region",
                  AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Gomel"
                        }
                   }
              });
            context.SwappAdrRegionPost.Add(
              new Models.SwappAdrRegionPost
              {
                  Id = Guid.NewGuid().ToString(),
                  Region = "Vitebsk region",
                  AddressCityPost = new List<Models.SwappAdrCityPost>()
                   {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Vitebsk"
                        }
                   }
              });


            context.SwappCategory.Add(
            new Models.SwappCategory
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Style",
                SubCategory = new List<Models.SwappSubCategory>()
                {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men clothes",
                            Points = 10
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Woman clothes",
                            Points = 10
                        },
                         new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men shoes",
                            Points = 10
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Woman shoes",
                            Points = 10
                        },
                         new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Men clothes",
                            Points = 10
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Clocks",
                            Points = 8
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Other",
                            Points = 8
                        }
                }
            });
            context.SwappCategory.Add(
                new Models.SwappCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Technic",
                    SubCategory = new List<Models.SwappSubCategory>()
                    {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Audio",
                            Points = 15
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "TV and video",
                            Points = 15
                        },
                         new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Computer",
                            Points = 15
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Phone",
                            Points = 10
                        },
                         new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Other",
                            Points = 10
                        }
                    }
                });
            context.SwappCategory.Add(
                new Models.SwappCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Auto",
                    SubCategory = new List<Models.SwappSubCategory>()
                    {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Tires and wheels",
                            Points = 20
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Passenger car",
                            Points = 50
                        },
                         new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Services for car",
                            Points = 20
                        }
                    }
                });
        }
    }
}
