using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class Comment
    {
        public int ID_Comment { get; set; }
        private User User { get; set; }
        private Movie Movie { get; set; }
        public string Message { get; set; }
        public DateTime RealeaseDate {get;set; }
        public bool IsValidate { get; set; }
        public int Note { get; set; }
        public bool IsReported { get; set; }
        public int Id_User { get; set; }
        public int Id_Movie { get; set; }
    }
}
