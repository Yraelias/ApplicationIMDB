using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    class UserService : BaseService<User, int>
    {
        UserRepository repo;
        public UserService()
        {
            repo = new UserRepository();
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
            return repo.ExecuteReader("SELECT * FROM T_Users");
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
