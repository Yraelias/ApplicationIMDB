using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class User
    {
        [Required]
        private string Login { get; set; }
        [Required]
        private string Password { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        [Required]
        private DateTime Date_Of_Birth { get; set; }
        private bool isActive { get; set; }
        private Role role { get; set; }

    }
}
