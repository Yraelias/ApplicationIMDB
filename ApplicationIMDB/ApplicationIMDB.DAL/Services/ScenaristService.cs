using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    public class ScenaristService : BaseService<Scenarist, int>
    {
        ScenaristRepository repo;
        public ScenaristService()
        {
            repo = new ScenaristRepository();
        }
        public override bool Add(Scenarist id)
        {
            throw new NotImplementedException();
        }

        public override bool DesactiveActive(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Scenarist> Get()
        {
            return repo.ExecuteReader("SELECT * FROM T_Scenarist");
        }

        public override Scenarist GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Scenarist obj)
        {
            throw new NotImplementedException();
        }
    }
}
