using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    public class UserService : BaseService<User, int>
    {
        UserRepository repo;
        RoleService roleService;
        public UserService()
        {
            repo = new UserRepository();
            roleService = new RoleService();
        }
        public override bool Add(User id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(User id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<User> Get()
        {
            IEnumerable<User> listUsers = new List<User>();
            listUsers =  repo.ExecuteReader("SELECT * FROM T_Users");

            IEnumerable<Role> listRoles = new List<Role>();
            listRoles = roleService.Get();

            foreach (var item in listUsers)
            {
                foreach (var role in listRoles)
                {
                    if (item.Id_Role == role.Id_Role)
                    {
                        item.RoleName = new Role() { Id_Role = role.Id_Role, Name = role.Name };
                    }
                }
                
            }

            return listUsers;
        }

        public override User GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
