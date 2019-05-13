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
        public int Fridge_Id { get; set; }
    }
}