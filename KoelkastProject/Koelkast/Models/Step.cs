using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class Step
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Recipe_Step> Recipe_Steps { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Step_description { get; set; }

    }
}