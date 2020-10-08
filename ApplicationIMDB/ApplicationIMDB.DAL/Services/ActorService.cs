using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    public class ActorService : BaseService<Actor, int>
    {
        ActorRepository repo;
        public  ActorService()
        {
            repo = new ActorRepository();
        }
        public override bool Add(Actor id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Actor id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Actor> Get()
        {
            return repo.ExecuteReader("SELECT * FROM T_Actors");
        }

        public override Actor GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Actor obj)
        {
            throw new NotImplementedException();
        }
    }
}
