using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class RoleRepository : BaseRepository<Role,int>
    {
        public IEnumerable<Role> Get(string query)
        {
            return base.ExecuteReader(query);
        }
    }
}
