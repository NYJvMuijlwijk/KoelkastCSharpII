using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Koelkast.Models
{
    // Models returned by MeController actions.
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string E_mail { get; set; }
        [Required]
        public string Password { get; set; }

        public List<Fridge> Fridges { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}