using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class ActorRepository : BaseRepository<Actor,int>
    {
        public IEnumerable<Actor> Get(string query)
        {
            return base.ExecuteReader(query);
        }
    }
}
