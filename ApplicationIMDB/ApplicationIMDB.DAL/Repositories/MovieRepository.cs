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
    }
}
