﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class User
    {
        [Required]
        [Key]
        public int User_Id { get; set; }

        [Required]
        public String E_mail { get; set; }

        [Required]
        public String Password { get; set; }

        public virtual ICollection<Fridge> Fridge { get; set; }
    }
}