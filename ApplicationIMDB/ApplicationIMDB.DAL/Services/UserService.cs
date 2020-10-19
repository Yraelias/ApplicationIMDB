using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using Microsoft.AspNetCore.Http;
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
        public override bool AddorUpdate(User user,bool Update)
        {
            
            if (Update) return repo.AddorUpdate("UPDATE T_Users SET[Login] = '"+user.Login+"',[Password] = '"+user.Password+"',[FirstName] ='"+user.FirstName+"',[LastName] ='"+user.LastName+"',[Date_of_birth] ='"+user.Date_Of_Birth.ToString("yyyy/MM/dd")+"' WHERE Id_User = " +user.Id_User );
                return repo.AddorUpdate("INSERT INTO[T_Users] ([Login],[ID_role],[Password],[FirstName],[LastName],[Date_of_birth],[isActive]) VALUES ('" + user.Login + "', 2, '" + user.Password + "', '" + user.FirstName + "', '" + user.LastName + "', '" + user.Date_Of_Birth.ToString("yyyy/MM/dd") + "', 1)");
        }

        public override bool DesactiveActive(int id,bool isActive)
        {
            return repo.DesactiveActive(id, isActive);
        }

        public User SignIn (User user)
        {
            user.Id_User = repo.SignIn(user.Login);
            bool a = false;
            a = repo.CheckPassword(user.Id_User, user.Password);
            if (a == true)
            {
                user = GetOne(user.Id_User);
                return user;
            }
            return null;
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
            return repo.GetOne("SELECT * FROM T_Users WHERE Id_User = " + id);
        }
    }
}
