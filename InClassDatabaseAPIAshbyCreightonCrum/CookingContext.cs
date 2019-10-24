using InClassDatabaseAPIAshbyCreightonCrum.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InClassDatabaseAPIAshbyCreightonCrum
{
    public class CookingContext : DbContext
    {
        public CookingContext(DbContextOptions<CookingContext> options)
            : base(options)
        { }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:acreighton1.database.windows.net,1433;Initial Catalog=CIS174DBDemo;Persist Security Info=False;User ID=Acreighton1;Password=Balifun!1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
