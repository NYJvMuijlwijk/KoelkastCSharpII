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

        public virtual ICollection<Ingredient> Recipe_Ingredients { get; set; }

        public virtual ICollection<Step> Recipe_Steps { get; set; }

    }
}