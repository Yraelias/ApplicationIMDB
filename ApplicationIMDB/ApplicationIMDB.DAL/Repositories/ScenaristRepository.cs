using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    class ScenaristRepository : BaseRepository<Scenarist,int>
    {
        public IEnumerable<Scenarist> Get(string query)
        {
            return base.ExecuteReader(query);
        }
    }
}
