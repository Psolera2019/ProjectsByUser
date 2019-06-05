using ProjectByUsers.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectByUsers.Data
{
    public class LoadData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<UserProjectContext>();
                context.Database.EnsureCreated();

                // Look if data already exist
                if (context.Users != null && context.Users.Any())
                    return;   // DB has already been seeded
            }
        }

    }
}