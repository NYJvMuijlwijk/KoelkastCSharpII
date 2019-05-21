using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Ingredient
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Unit_Of_Measure { get; set; }

        public List<Fridge_Ingredient_Amount> FridgeIngredientAmounts { get; set; }
        public List<Recipe_Ingredient_Amount> RecipeIngredientAmounts { get; set; }
    }
}