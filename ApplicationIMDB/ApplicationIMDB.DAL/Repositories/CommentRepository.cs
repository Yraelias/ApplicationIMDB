using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationIMDB.DAL.Repositories
{
    class CommentRepository : BaseRepository<Comment,int>
    {
        public IEnumerable<Comment> Get(string query)
        {
            return base.ExecuteReader(query);
        }
    }
}
