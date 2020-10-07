using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class Scenarist
    {
        private int Id_Scenarist { get; set; }
        [Required]
        private string FirstName { get; set; }
        [Required]
        private int LastName { get; set; }
    }
}
