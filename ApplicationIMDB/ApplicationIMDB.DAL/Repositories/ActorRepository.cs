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
        public override Actor GetOne(string query)
        {
            return base.GetOne(query);
        }
        public override bool Add(string query )
        {
            return base.Add(query);
        }
    }
}
