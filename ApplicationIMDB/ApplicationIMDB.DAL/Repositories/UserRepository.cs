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
        public override bool AddorUpdate(string query)
        {
            return base.AddorUpdate(query);
        }
        public override bool DesactiveActive(int id,bool isActive )
        {
            return base.DesactiveActive(id, isActive);
        }
        public override int SignIn(string login)
        {
            int a = 0;
            a = base.SignIn(login);
            return a;
        }

        public  bool CheckPassword(User user)
        {

            return base.CheckPassword(user.Id_User, user.Password);
        }

        public override User GetOne(string query)
        {
            return base.GetOne(query);
        }
    }
}
