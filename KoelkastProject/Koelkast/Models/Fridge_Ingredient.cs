using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Fridge_Ingredient
    {

        [Required]
        public int Amount { get; set; }
    }
}