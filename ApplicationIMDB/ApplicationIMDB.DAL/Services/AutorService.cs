﻿using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;

namespace ApplicationIMDB.DAL.Services
{
    public class AutorService : BaseService<Autor,int>
    {
        AutorRepository repo;
        public AutorService()
        {
            repo = new AutorRepository();
        }
        public override bool AddorUpdate(Autor id,bool Update)
        {
            if (Update) ;
            throw new NotImplementedException();
        }

        public override bool DesactiveActive(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Autor> Get()
        {
            return repo.ExecuteReader("SELECT * FROM T_Autors");
        }

        public override Autor GetOne(int id)
        {
            return repo.GetOne("SELECT * FROM T_Autors WHERE Id_Autor = " + id);
        }

    }
}
