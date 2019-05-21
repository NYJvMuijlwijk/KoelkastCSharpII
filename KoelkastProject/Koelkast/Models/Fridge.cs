using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Fridge
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual User User { get; set; }

        public List<Fridge_Ingredient_Amount> Ingredients { get; set; }
    }
}