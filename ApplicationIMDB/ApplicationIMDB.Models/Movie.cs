using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class Movie
    {
        private int Id_Movie{ get; set; }
        [Required]
        private string Title { get; set; }
        private int Year { get; set; }
        private string Description { get; set; }
        private Scenario Scenario { get; set; }
        private Casting Casting { get; set; }
        private Production Production { get; set; }
    }
}
