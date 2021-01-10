using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tharaha.Data;

[assembly: HostingStartup(typeof(tharaha.Areas.Identity.IdentityHostingStartup))]
namespace tharaha.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<tharahaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("tharahaContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                { options.SignIn.RequireConfirmedAccount = false;
               options.Password.RequireDigit = false;
               options.Password.RequireLowercase = false;
               options.Password.RequiredLength = 3;
               options.Password.RequiredUniqueChars = 0;
               options.Password.RequireUppercase = false;
                
                })
                    .AddEntityFrameworkStores<tharahaContext>();
            });
        }
    }
}