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
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        private Scenario Scenario { get; set; }
        public int Id_Cast { get; set; }
        public int Id_Scenario { get; set; }
        public int Id_Production { get; set; }
        private Casting Casting { get; set; }
        private Production Production { get; set; }
    }
}
