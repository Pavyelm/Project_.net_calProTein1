using Microsoft.EntityFrameworkCore;
using CalProTein.Models;

namespace CalProTein.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category måltid = new Category { Name = "Måltid", Slug = "måltid" };
                Category frukt = new Category { Name = "Frukt", Slug = "frukt" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Gainomamx",
                            Slug = "gainomamx",
                            Description = "proteinshasxke",
                            Cal = 170,
                            Protein = 30,
                            Category = måltid,
                           
                        }
                    


                );

                context.SaveChanges();
            }
        }
    }
}