using CinemaPro.WebUI.AppCode.Filters;
using CinemaPro.Domain.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using CinemaPro.Domain.Entity.Membership;
using Microsoft.AspNetCore.Identity;
using System;

namespace CinemaPro.WebUI
{
    public class Startup
    {
        readonly IConfiguration conf;

        public Startup(IConfiguration conf)
        {
            this.conf = conf;

        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg =>
            {

                cfg.Filters.Add<JsonSerializerFilter>();

                var policy = new AuthorizationPolicyBuilder()
                       .RequireAuthenticatedUser()
                       .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            });
           

            //services.PostConfigure<MvcNewtonsoftJsonOptions>(o =>
            //{
            //    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //});

            services.AddDbContext<CinemaDbContext>(cfg =>
            {
                //cfg.UseInMemoryDatabase(databaseName: "CinemaPro");
                cfg.UseSqlServer(conf.GetConnectionString("cString"));

            });

            services.AddIdentity<CpUser, CpRole>()
                .AddEntityFrameworkStores<CinemaDbContext>();

            services.Configure<IdentityOptions>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;

                cfg.Password.RequireDigit = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredLength = 3;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
            });
            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accesdenied.html";
                cfg.Cookie.Name = "Cp";
                cfg.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                cfg.SlidingExpiration = true;
            });
            services.AddRouting(opt =>
            {
                opt.LowercaseUrls = true;
                opt.LowercaseQueryStrings = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Seed();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute(
                 name: "areaAdmin",
                 areaName: "Admin",
                 pattern: "Admin/{controller=moviedetails}/{action=Index}/{id:int:min(1)?}"
             );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id:int:min(1)?}"
                    );

                endpoints.MapAreaControllerRoute(
                  name: "default",
                  areaName: "Admin",
                  pattern: "signin.html",
                  defaults: new
                  {
                      controller = "Account",
                      action = "Login",
                      area = "admin"
                  });



            });
        }
    }
}
