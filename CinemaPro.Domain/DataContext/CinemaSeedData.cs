using CinemaPro.Domain.Entity.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaPro.Domain.DataContext
{
    static public class CinemaSeedData
    {
        static public IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CinemaDbContext>();


                var userManager = scope.ServiceProvider
                   .GetRequiredService<UserManager<CpUser>>();
                var roleManager = scope.ServiceProvider
                     .GetRequiredService<RoleManager<CpRole>>();

                if (roleManager.FindByNameAsync("SuperAdmin").Result == null)
                {
                    var superAdminRole = roleManager.CreateAsync(new CpRole
                    {
                        Name = "SuperAdmin"
                    }).Result;

                    if (superAdminRole.Succeeded)
                    {
                        if (userManager.FindByEmailAsync("majidan@code.edu.az").Result == null)
                        {
                            var mecid = new CpUser
                            {
                                UserName = "mecid",
                                Email = "majidan@code.edu.az"
                            };

                            var u1Result = userManager.CreateAsync(mecid, "123").Result;


                        }
                    }
                }

                //InitCategory(db);

                //InitLanguage(db);
                //InitDirector(db);
                //InitMoviedetail(db);
                //InitMcat(db);

                //InitCast(db);
                //InitMcast(db);
                //InitBtheS(db);
                //InitFormat(db);
                //InitMFormat(db);
                //InitCinema(db);
                //InitRoom(db);
                //InitCabine(db);
                //InitExtra(db);
                //InitTicket(db);
                //InitPartner(db);
                //InitContact(db);
                //InitSocial(db);


            }

            return app;
        }

        //private static void InitSocial(CinemaDbContext db)
        //{
        //    if (!db.Socialmedias.Any())
        //    {
        //        db.Socialmedias.AddRange(
        //            new Socialmedia
        //            {
        //                Name = "Facebook",
        //                Logo = "fab fa-facebook",
        //                Link = "https://www.facebook.com"
        //            },
        //            new Socialmedia
        //            {
        //                Name = "Instagram",
        //                Logo = "fab-fa-instagram",
        //                Link = "https://www.instagram.com"
        //            },
        //            new Socialmedia
        //            {
        //                Name = "Twitter",
        //                Logo = "fab-fa-twitter",
        //                Link = "https://www.twitter.com"
        //            });
        //    }
        //}

        //private static void InitContact(CinemaDbContext db)
        //{
        //    if (!db.Contacts.Any())
        //    {
        //        db.Contacts.AddRange(
        //            new Contact
        //            {
        //                Location = "Bakı şəhəri,Yusif Məmmədəliyev küç 24",
        //                Number1 = "+994 51 567 02 60",
        //                Number2 = "+994 50 501 13 77",
        //                Link = "",
        //                Mail = "aqashova@inbox.ru"

        //            });

        //    }
        //}

        //private static void InitCategory(CinemaDbContext db)
        //{
        //    if (!db.Categories.Any())
        //    {
        //        db.Categories.AddRange(
        //       new Category
        //       {
        //           Name = "Aksiyon"
        //       },
        //         new Category
        //         {
        //             Name = "Dram"
        //         },
        //           new Category
        //           {
        //               Name = "Romantik"
        //           });
        //    }
        //    db.SaveChanges();
        //}


        //private static void InitMcat(CinemaDbContext db)
        //{
        //    if (!db.Mcats.Any())
        //    {
        //        db.Mcats.AddRange(
        //            new Mcat
        //            {
        //                CategoryId = 1,
        //                MoviedetailId = 1,
        //            },
        //             new Mcat
        //             {
        //                 CategoryId = 2,
        //                 MoviedetailId = 1,
        //             },
        //             new Mcat
        //             {
        //                 CategoryId = 2,
        //                 MoviedetailId = 3,
        //             });
        //        db.SaveChanges();
        //    }
        //}

        //private static void InitTicket(CinemaDbContext db)
        //{
        //    if (!db.Tickets.Any())
        //    {
        //        db.Tickets.AddRange(
        //            new Ticket
        //            {
        //                Totalamount = "",
        //                Cabine_id = 1,
        //                Extra_id = 1
        //            },
        //             new Ticket
        //             {
        //                 Totalamount = "",
        //                 Cabine_id = 2,
        //                 Extra_id = 2
        //             });
        //    }
        //}

        //private static void InitExtra(CinemaDbContext db)
        //{
        //    if (db.Extras.Any())
        //    {
        //        db.Extras.AddRange(
        //            new Extra
        //            {
        //                Packet = "Single",
        //                Cost = "2AZN",
        //                Desc = "1 nəfərlik paketin daxilinə 1 hamburger,1 kiçik boy frenç frayz,1 kola",
        //                Image = ""
        //            },
        //             new Extra
        //             {
        //                 Packet = "Double",
        //                 Cost = "5 AZN",
        //                 Desc = "2 nəfərlik paketin daxilinə 1 hamburger,1 çizburger,1 böyük boy frenç frayz,2 kola",
        //                 Image = ""
        //             });
        //    }
        //}

        //private static void InitCabine(CinemaDbContext db)
        //{
        //    if (db.Cabines.Any())
        //    {
        //        db.Cabines.AddRange(
        //            new Cabine
        //            {
        //                Time = "2 saat",
        //                Moviedetail_id = 1,
        //                Cinema_id = 1,
        //                Room_id = 1
        //            },
        //             new Cabine
        //             {
        //                 Time = "1.30 saat",
        //                 Moviedetail_id = 2,
        //                 Cinema_id = 2,
        //                 Room_id = 2
        //             });
        //    }
        //}

        //private static void InitRoom(CinemaDbContext db)
        //{
        //    if (!db.Rooms.Any())
        //    {
        //        db.Rooms.AddRange(
        //            new Room
        //            {
        //                Name = "1-ci zal"
        //            },
        //             new Room
        //             {
        //                 Name = "2-ci zal"
        //             });
        //    }
        //}

        //private static void InitCinema(CinemaDbContext db)
        //{
        //    if (!db.Cinemas.Any())
        //    {
        //        db.Cinemas.AddRange(
        //            new Cinema
        //            {
        //                Name = "Nizami"
        //            },
        //             new Cinema
        //             {
        //                 Name = "28 Mall"
        //             });
        //    }
        //}

        //private static void InitMFormat(CinemaDbContext db)
        //{
        //    if (!db.Mformats.Any())
        //    {
        //        db.Mformats.AddRange(
        //            new Mformat
        //            {
        //                MoviedetailId = 1,
        //                FormatId = 1
        //            },
        //            new Mformat
        //            {
        //                MoviedetailId = 2,
        //                FormatId = 2
        //            });
        //    }
        //}

        //private static void InitFormat(CinemaDbContext db)
        //{
        //    if (!db.Formats.Any())
        //    {
        //        db.Formats.AddRange(
        //            new Format
        //            {
        //                Name = "2D",
        //            },
        //            new Format
        //            {
        //                Name = "3D",
        //            },
        //            new Format
        //            {
        //                Name = "5D",
        //            });
        //    }
        //}

        //private static void InitBtheS(CinemaDbContext db)
        //{
        //    if (!db.BtheSes.Any())
        //    {
        //        db.BtheSes.AddRange(
        //            new BtheS
        //            {
        //                Video_Photo = "",
        //                Moviedetail_Id = 1
        //            },
        //             new BtheS
        //             {
        //                 Video_Photo = "",
        //                 Moviedetail_Id = 2
        //             });
        //    }
        //}

        //private static void InitMcast(CinemaDbContext db)
        //{
        //    if (!db.Mcasts.Any())
        //    {
        //        db.AddRange(
        //            new Mcast
        //            {
        //                Movie_Id = 1,
        //                Cast_Id = 1
        //            },
        //             new Mcast
        //             {
        //                 Movie_Id = 2,
        //                 Cast_Id = 2
        //             });
        //    }
        //}

        //private static void InitCast(CinemaDbContext db)
        //{
        //    if (!db.Casts.Any())
        //    {
        //        db.AddRange(
        //            new Cast
        //            {
        //                Fullname = "Fazil Qulağov",
        //                Rolename = "Aktyor"
        //            },
        //             new Cast
        //             {
        //                 Fullname = "Zura Isiyeva",
        //                 Rolename = "Aktyor"
        //             });
        //    }
        //}

        //private static void InitPartner(CinemaDbContext db)
        //{
        //    if (!db.Partners.Any())
        //    {
        //        db.Partners.AddRange(
        //            new Partner
        //            {
        //                Name = "Netflix Türkiye",
        //                Logo = "p1.jpg"

        //            },
        //             new Partner
        //             {
        //                 Name = "Smart Tv",
        //                 Logo = "p2.jpg"

        //             });
        //    }
        //}

        //private static void InitLanguage(CinemaDbContext db)
        //{
        //    if (!db.Languages.Any())
        //    {
        //        db.Languages.AddRange(
        //            new Language
        //            {
        //                Lang = "Az"

        //            },
        //             new Language
        //             {
        //                 Lang = "Rus"

        //             });
        //        db.SaveChanges();
        //    }

        //}

        //private static void InitDirector(CinemaDbContext db)
        //{
        //    if (!db.Directors.Any())
        //    {
        //        db.Directors.AddRange(

        //       new Director
        //       {

        //           Name = "Şon Levi"
        //       },
        //        new Director
        //        {

        //            Name = "Con Devi"
        //        });
        //        db.SaveChanges();
        //    }
        //}

        //private static void InitMoviedetail(CinemaDbContext db)
        //{
        //    if (!db.Moviedetails.Any())
        //    {
        //        db.Moviedetails.AddRange(

        //        new Moviedetail
        //        {

        //            Name = "Baş Qəhraman",
        //            Startdate = new DateTime(2021, 12, 20),
        //            Enddate = new DateTime(2020, 07, 23),
        //            Trailer = "",
        //            Image = "bot-1.jpg",
        //            TitleImage = "01.jpg",
        //            Price = "25 AZN",
        //            Desc = "Gözəl bir gündə adi bir bank işçisi adi kassir yox, " +
        //           "video oyun qəhrəmanı olduğunu kəşf edir." +
        //           " Ancaq o, bu şüuru ilə super qəhrəmanı sadə" +
        //           " oyuncudan fərqləndirən güclər qazanacaqmı?",
        //            Country = "ABŞ",
        //            Time = "2 saat",
        //            Agelimit = "12+",
        //            Subtitles = "Az,Rus",
        //            DirectorId = 1,
        //            LangId = 1


        //        },
        //          new Moviedetail
        //          {

        //              Name = "Baş Qəhraman-1",
        //              Startdate = new DateTime(2021, 08, 02),
        //              Enddate = new DateTime(2021, 08, 23),
        //              Trailer = "",
        //              Image = "bot-1.jpg",
        //              TitleImage = "02.jpg",
        //              Price = "35 AZN",
        //              Desc = "Gözəl bir gündə adi bir bank işçisi adi kassir yox, " +
        //           "video oyun qəhrəmanı olduğunu kəşf edir." +
        //           " Ancaq o, bu şüuru ilə super qəhrəmanı sadə" +
        //           " oyuncudan fərqləndirən güclər qazanacaqmı???",
        //              Country = "ABŞ",
        //              Time = "2 saat",
        //              Agelimit = "12+",
        //              Subtitles = "Az,Rus",
        //              DirectorId = 2,
        //              LangId = 1

        //          },
        //             new Moviedetail
        //             {

        //                 Name = "Baş Qəhraman-3",
        //                 Startdate = new DateTime(2020, 12, 20),
        //                 Enddate = new DateTime(2021, 08, 23),
        //                 Trailer = "",
        //                 Image = "bot-3.jpg",
        //                 TitleImage = "02.jpg",
        //                 Price = "35 AZN",
        //                 Desc = "Gözəl bir gündə adi bir bank işçisi adi kassir yox, " +
        //           "video oyun qəhrəmanı olduğunu kəşf edir." +
        //           " Ancaq o, bu şüuru ilə super qəhrəmanı sadə" +
        //           " oyuncudan fərqləndirən güclər qazanacaqmı???",
        //                 Country = "ABŞ",
        //                 Time = "2 saat",
        //                 Agelimit = "12+",
        //                 Subtitles = "Az,Rus",
        //                 DirectorId = 2,
        //                 LangId = 1

        //             },
        //                new Moviedetail
        //                {

        //                    Name = "Baş Qəhraman-4",
        //                    Startdate = new DateTime(2020, 12, 19),
        //                    Enddate = new DateTime(2021, 08, 23),
        //                    Trailer = "",
        //                    Image = "bot-4.jpg",
        //                    TitleImage = "02.jpg",
        //                    Price = "35 AZN",
        //                    Desc = "Gözəl bir gündə adi bir bank işçisi adi kassir yox, " +
        //           "video oyun qəhrəmanı olduğunu kəşf edir." +
        //           " Ancaq o, bu şüuru ilə super qəhrəmanı sadə" +
        //           " oyuncudan fərqləndirən güclər qazanacaqmı???",
        //                    Country = "ABŞ",
        //                    Time = "2 saat",
        //                    Agelimit = "12+",
        //                    Subtitles = "Az,Rus",
        //                    DirectorId = 2,
        //                    LangId = 1

        //                });
        //        db.SaveChanges();
        //    }
        //}
    }
}
