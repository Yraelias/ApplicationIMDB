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
        private Autor autor { get; set; }
        private Actor actor { get; set; }
        private Scenarist scenarist { get; set; }
        [Required]
        private string Title { get; set; }
        private int Year { get; set; }
        private string Description { get; set; }
    }
}
