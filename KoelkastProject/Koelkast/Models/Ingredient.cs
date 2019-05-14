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
        public String Name { get; set; }
        
        [Required]
        public String Unit_Of_Measure { get; set; }

        public virtual ICollection<Fridge_Ingredient> Fridge_Ingredients { get; set; }
        public virtual ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }


    }
}