using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Recipe
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int Time { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }

        public virtual ICollection<Recipe_Step> Recipe_Steps { get; set; }

    }
}