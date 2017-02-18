using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Resume.Data;
using Microsoft.EntityFrameworkCore;


namespace Resume.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Jobs.Any())
                {
                    return;
                }

                context.Jobs.AddRange(

                    new Jobs
                    {
                        JobTitle = "Adjudicator",
                        JobDateFrom = DateTime.Parse("01/01/2007"),
                        JobDateTo = DateTime.Parse("5/1/2012")

                    },

                    new Jobs
                    {
                        JobTitle = "Customer Service Rep",
                        JobDateFrom = DateTime.Parse("01/01/2004"),
                        JobDateTo = DateTime.Parse("5/1/2012")
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
