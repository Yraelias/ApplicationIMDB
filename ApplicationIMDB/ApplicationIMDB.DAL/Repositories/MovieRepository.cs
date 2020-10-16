using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class MovieRepository : BaseRepository<Movie,int>
    {
        public IEnumerable<Movie> Get(string query)
        {
            return base.ExecuteReader(query);
        }
        public override Movie GetOne(string query)
        {
            return base.GetOne(query);
        }
        public override bool AddorUpdate(string query)
        {
            return base.AddorUpdate(query);
        }
       
    }
}
