using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafeteria_Management_System.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;

namespace Cafeteria_Management_System
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public string AuthenticationScheme { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole<int>>(options =>
            {

                //options.Password.RequiredLength = 6;
                //options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<Data>().AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(o =>
            {

                o.TokenLifespan = TimeSpan.FromHours(5);
            });
            

            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                options.Filters.Add(new AuthorizeFilter(policy));

            });




            services.AddDbContextPool<Data>(option => option.UseSqlServer(Configuration.GetConnectionString("CMSDB")));



            services.AddScoped<IVendorRepo, SqlRepository>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                //This lambda determines whether user consent for non - essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                 options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddScoped<IFoodsRepo, SqlRepository>();
            services.AddScoped<IOrderRepo, SqlRepository>();
            services.AddScoped<IAppUser, SqlRepository>();
             //changing Access denied Route, u need to login and logout to effect changes
            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.AccessDeniedPath = new PathString("Administration/AccessDenied");

            //});



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //});


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            loggerFactory.AddNLog();
            env.ConfigureNLog("nlog.config");
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
