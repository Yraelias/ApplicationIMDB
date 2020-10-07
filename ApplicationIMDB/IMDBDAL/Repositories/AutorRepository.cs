using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDBDAL.Repositories
{
    class AutorRepository : BaseRepository<Autor,int>
    {
        private IEnumerable<Autor> ExecuteReader()
        {
           return base.ExecuteReader("SELECT * FROM T_Autors");
        }
    }
}
