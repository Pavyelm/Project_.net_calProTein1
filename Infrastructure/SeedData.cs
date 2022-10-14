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
                Category Produkt = new Category { Name = "Produkt", Slug = "produkt" };
                Category Maltid = new Category { Name = "Måltid", Slug = "måltid" };
                Category Snabbmat = new Category { Name = "Snabbmat", Slug = "Snabbmat" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Gainomamx",
                            Slug = "gainomamx",
                            Description = "proteinshasxke",
                            Cal = 170,
                            Protein = 30,
                            Category = Produkt
                           
                        },
                          new Product
                          {
                              Name = "Cheseburger",
                              Slug = "cheseburger",
                              Description = "mcdonlads",
                              Cal = 170,
                              Protein = 30,
                              Category = Snabbmat

                          
                           },
                          new Product
                          {
                              Name = "Ägg",
                              Slug = "ägg",
                              Description = "ett ägg",
                              Cal = 80,
                              Protein = 7,
                              Category = Produkt

                          
                           },
                          new Product
                          {
                              Name = "KebabPizza",
                              Slug = "kebbabpizza",
                              Description = "kebab pizza",
                              Cal = 2100,
                              Protein = 132,
                              Category = Maltid

                          
                           },
                          new Product
                          {
                              Name = "Bigmac",
                              Slug = "bigmac",
                              Description = "mcdonalds",
                              Cal = 500,
                              Protein = 20,
                              Category = Snabbmat



                          }


                );

                context.SaveChanges();
            }
        }
    }
}