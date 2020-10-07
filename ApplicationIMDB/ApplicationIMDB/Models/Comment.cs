using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationIMDB.Models
{
    public class Comment
    {
        private int ID_Comment { get; set; }
        private User User { get; set; }
        private Movie Movie { get; set; }
        private string Message { get; set; }
        private DateTime RealeaseDate {get;set; }
        private bool IsValidate { get; set; }
        private int Note { get; set; }
        private bool IsReported { get; set; }
    }
}
