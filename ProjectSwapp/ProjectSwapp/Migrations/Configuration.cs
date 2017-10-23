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
                            City = "Beresino"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Borisov"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Vileyka"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Volojin"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Derjinsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Cleck"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Copyl"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Crypki"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Logoisky"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Luban"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Molodechno"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Myadel"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Nesvij"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Magina gorka"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slyck"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Smolevichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Soligorsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Starie dorogi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Stolbci"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Uzda"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Cherven"
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
                            City = "Baranovichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Bereza"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Gancevichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Drogichin"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Jabinka"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ivanovo"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ivacevichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Kamenec"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Kobrin"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Luninec"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Lyahovichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Malorita"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Pinsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Prujani"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Stolin"
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
                            City = "Brestovica"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Volkovisk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Voronovo"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Dyatlovo"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Zelva"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ivie"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Korelichi"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Lida"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mosti"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Novogrydok"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Oshmiany"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ostrovec"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Svisloch"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slonim"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Smorgon"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Schychin"
                        }
                    }
                });
            context.SwappAdrRegionPost.Add(
                new Models.SwappAdrRegionPost
                {
                    Id = Guid.NewGuid().ToString(),
                    Region = "Mahilyow region",
                    AddressCityPost = new List<Models.SwappAdrCityPost>()
                    {
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mahilyow"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Babruysk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Asipovichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Horki"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Krychaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Bykhaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Kastsyukovichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Klimavichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Shklow"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mstsislaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Chavusy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Cherykaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Slawharad"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Klichaw"
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
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Mazyr"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Zhlobin"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Svietlahorsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Rechytsa"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Kalinkavichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Rahachow"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Dobrush"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Zhytkavichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Khoyniki"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Pietrykaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Yel�sk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Buda-Kashalyova"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Naroulia"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Vietka"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Chachersk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Vasilievichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Brahin"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Turov"
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
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Orsha"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Navapolatsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Polatsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Pastavy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Hlybokaye"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Lepel"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Novolukoml"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Haradok"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Baran"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Talachyn"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Braslaw"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Chashniki"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Dubroina"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Myory"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Syanno"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Beshankovichy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Verkhnyadzvinsk"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Dokshytsy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Ushachy"
                        },
                        new Models.SwappAdrCityPost
                        {
                            Id = Guid.NewGuid().ToString(),
                            City = "Disna"
                        }
                    }
                });
            context.SwappCategory.Add(
                new Models.SwappCategory
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Fashion and style",
                    SubCategory = new List<Models.SwappSubCategory>()
                    {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Man clothes",
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
                            Name = "Man shoes",
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
                            Name = "Accessories and watches",
                            Points = 8
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Cosmetics and perfumery",
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
                            Name = "Tablet",
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
                            Name = "Services for car",
                            Points = 20
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Accessories",
                            Points = 20
                        }
                    }
                });
            context.SwappCategory.Add(
               new Models.SwappCategory
               {
                   Id = Guid.NewGuid().ToString(),
                   Name = "Pets",
                   SubCategory = new List<Models.SwappSubCategory>()
                   {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Home pets",
                            Points = 8
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Goods for pets",
                            Points = 8
                        },
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Accessories",
                            Points = 8
                        }
                   }
               });
            context.SwappCategory.Add(
               new Models.SwappCategory
               {
                   Id = Guid.NewGuid().ToString(),
                   Name = "Others",
                   SubCategory = new List<Models.SwappSubCategory>()
                   {
                        new Models.SwappSubCategory
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Other",
                            Points = 10
                        }
                   }
               });
        }
    }
}
