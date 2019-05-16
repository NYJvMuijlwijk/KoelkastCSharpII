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
        public string Description { get; set; }

        [Required]
        public List<Recipe_Ingredient_Amount> Ingredients { get; set; }
        [Required]
        public List<Step> Steps { get; set; }
        [Required]
        public User User { get; set; }
    }
}