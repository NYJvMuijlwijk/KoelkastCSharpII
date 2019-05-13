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
        public int Step_Id { get; set; }

     
        [Required]
        public string Title { get; set; }

        [Required]
        public string Step_description { get; set; }

      
    }
}