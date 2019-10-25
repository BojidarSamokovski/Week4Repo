using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Registration.Models
{
    public class User
    {
        [Key] 
        public string IdFuckYou { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
