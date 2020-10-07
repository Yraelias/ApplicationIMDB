using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class AutorRepository : BaseRepository<Autor,int>
    {
        private IEnumerable<Autor> ExecuteReader()
        {
           return base.ExecuteReader("SELECT * FROM T_Autors");
        }
    }
}
