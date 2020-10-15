using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class User
    {
        public int Id_User { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        public DateTime Date_Of_Birth { get; set; }
        public bool isActive { get; set; }
        public int Id_Role { get; set; }
        public Role RoleName { get; set; }

    }
}
