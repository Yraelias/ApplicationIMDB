using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    public class RoleService : BaseService<Role, int>
    {
        RoleRepository repo;
        public RoleService()
        {
            repo = new RoleRepository();
        }
        public override bool AddorUpdate(Role id,bool Update)
        {
            throw new NotImplementedException();
        }

        public override bool DesactiveActive(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Role> Get()
        {
            
            var a = repo.ExecuteReader("SELECT * FROM T_Role");
            return a;
        }

        public override Role GetOne(int id)
        {
            throw new NotImplementedException();
        }

    }
}
