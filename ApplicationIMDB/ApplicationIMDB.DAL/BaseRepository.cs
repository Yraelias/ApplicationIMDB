using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ApplicationIMDB.DAL
{
    public abstract class BaseRepository<T,Tkey>
    {
        private string _connectionString = "@Data Source=localhost;Initial Catalog=IMDB;Integrated Security=True";
        protected IDbConnection connection;

        public BaseRepository()
        {
            connection = new System.Data.SqlClient.SqlConnection(_connectionString);
        }

        public  IEnumerable<T> ExecuteReader(string query)
        {
            List<T> list = new List<T>();
            IDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 90;
            if (connection.State == ConnectionState.Closed) connection.Open();
            using(IDataReader dr = cmd.ExecuteReader())
            {
                //parcourir datareader et ajouter a une liste <T>
                while(dr.Read())
                {
                    list.Add((T)dr);
                }
            }
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            return list;
        }
    }
}
