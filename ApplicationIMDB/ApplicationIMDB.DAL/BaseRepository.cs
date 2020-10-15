using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using ApplicationIMDB.DAL.Extensions;

namespace ApplicationIMDB.DAL
{
    public abstract class BaseRepository<T,Tkey>
    {
        private string _connectionString = "Data Source=localhost;Initial Catalog=IMDB;Integrated Security=True";
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
                    list.Add(dr.ConvertTo<T>());
                }
            }
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            return list;
        }

        public virtual T GetOne(string query)
        {
            List<T> list = new List<T>();
            IDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 90;
            if (connection.State == ConnectionState.Closed) connection.Open();

            using (IDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(dr.ConvertTo<T>());
                }
            }

            
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            return list[0];
        }

        public virtual  bool Add(string query)
        {
            int a = 0;
            IDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 90;
            if (connection.State == ConnectionState.Closed) connection.Open();
            a = cmd.ExecuteNonQuery();
            if (a == 1) return true;
            return false;
        }
        public virtual bool DesactiveActive(int id, bool isActive)
        {
            int a;
            IDbCommand cmd = connection.CreateCommand();
            if (isActive) a = 1;
            else a = 0;
            cmd.CommandText = "UPDATE[dbo].[T_Users] SET[isActive] = " + a + " WHERE Id_User = " + id;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 90;
            if (connection.State == ConnectionState.Closed) connection.Open();
            a = cmd.ExecuteNonQuery();
            if (a == 1) return true;
            return false;
        }

        public virtual int SignIn(string login)
        {
            int a = 0;
            IDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id_User FROM T_Users WHERE Login LIKE '" +login+ "' " ;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 90;
            if (connection.State == ConnectionState.Closed) connection.Open();
            if (cmd.ExecuteScalar() != null) a = (int)cmd.ExecuteScalar();
            else return 0; //login inexistant 
            return a;
        }

        
    }
}
