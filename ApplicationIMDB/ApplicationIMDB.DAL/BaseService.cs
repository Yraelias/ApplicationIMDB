using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ApplicationIMDB.DAL
{
    public abstract class BaseService<T,TKey>
    {
        private string _connectionString = "Data Source=localhost;Initial Catalog=IMDB;Integrated Security=True";
        protected IDbConnection connection;

        public BaseService()
        {
            connection = new System.Data.SqlClient.SqlConnection(_connectionString);
        }
        public abstract IEnumerable<T> Get();
        public abstract T GetOne(TKey id);
        public abstract bool Add(T id);
        public abstract bool Update(T obj);
        public abstract bool Delete(T id);
    }
}
