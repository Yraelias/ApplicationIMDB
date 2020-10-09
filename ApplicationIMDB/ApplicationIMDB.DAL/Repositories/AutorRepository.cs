using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class AutorRepository : BaseRepository<Autor,int>
    {
        public IEnumerable<Autor> Get(string query)
        {
           return base.ExecuteReader(query);
        }
        public override Autor GetOne(string query)
        {
            return base.GetOne(query);
        }
    }
}
