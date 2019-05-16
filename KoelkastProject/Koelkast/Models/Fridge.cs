using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Fridge
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public virtual ICollection<Fridge_Ingredient> Fridge_Ingredients { get; set; }
    }
}