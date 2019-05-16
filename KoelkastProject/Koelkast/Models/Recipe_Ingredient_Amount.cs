using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Recipe_Ingredient_Amount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }

        [Required]
        public Recipe Recipe { get; set; }
        [Required]
        public Ingredient Ingredient { get; set; }
        
    }
}