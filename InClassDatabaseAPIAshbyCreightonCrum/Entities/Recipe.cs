using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InClassDatabaseAPIAshbyCreightonCrum.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public TimeSpan TimeToCook { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }




    }
}
