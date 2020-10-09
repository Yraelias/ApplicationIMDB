using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    public class UserRepository : BaseRepository<User,int>
    {
        public IEnumerable<User> Get(string query)
        {
            return base.ExecuteReader(query);
        }
        public override bool Add(string query)
        {
            return base.Add(query);
        }
        public override bool DesactiveActive(int id,bool isActive )
        {
            return base.DesactiveActive(id, isActive);
        }
    }
}
