using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    public class MovieService : BaseService<Movie, int>
    {
        MovieRepository repo;
        public MovieService()
        {
            repo = new MovieRepository();
        }
        public override bool Add(Movie id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Movie id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Movie> Get()
        {
            return repo.ExecuteReader("SELECT * FROM T_Movies");
        }

        public override Movie GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Movie obj)
        {
            throw new NotImplementedException();
        }
    }
}
