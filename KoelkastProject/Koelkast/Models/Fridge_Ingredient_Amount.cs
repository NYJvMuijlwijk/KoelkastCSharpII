using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Fridge_Ingredient_Amount
    {
        [Required]
        public int Amount { get; set; }

        [Required]
        public Fridge Fridge { get; set; }
        [Required]
        public Ingredient Ingredient { get; set; }
    }
}