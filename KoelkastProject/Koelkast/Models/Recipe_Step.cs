using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Recipe_Step
    {
        [Key]
        public int Id { get; set; }

    }
}