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
        public override bool Add(Actor actor)
        {
            return repo.Add("INSERT INTO T_Actors ([FirstName],[LastName]) VALUES ('" + actor.FirstName + "', '" + actor.LastName +"')");
        }

        public override bool DesactiveActive(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Actor> Get()
        {
            return repo.ExecuteReader("SELECT * FROM T_Actors");
        }

        public override Actor GetOne(int id)
        {
            return repo.GetOne("SELECT * FROM T_Actors WHERE Id_Actor = " + id);
        }

        public override bool Update(Actor obj)
        {
            throw new NotImplementedException();
        }
    }
}
