using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    class UserRepository : BaseRepository<User,int>
    {
        public IEnumerable<User> Get(string query)
        {
            return base.ExecuteReader(query);
        }
    }
}
