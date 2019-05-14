using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Recipe_Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}