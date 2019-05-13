using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Ingredients
    {
        [Required]
        [Key]
        public int UserIngredients_Id { get; set; }

        [Required]
        public String Name { get; set; }

        public int Amount { get; set; }
        
        [Required]
        public String Unit_Of_Measure { get; set; }

        
   
    }
}