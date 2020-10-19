using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ApplicationIMDB.DAL.Services
{
    class CommentService : BaseService<Comment, int>
    {
        CommentRepository repo;
        public CommentService()
        {
            repo = new CommentRepository();
        }
        public override bool AddorUpdate(Comment comment, bool Update)
        {
            if (Update) return repo.AddorUpdate("UPDATE [dbo].[T_Comments] SET[Id_User] = "+comment.Id_User+",[ID_Movie] ="+comment.Id_Movie+",[message] ='"+comment.Message+"',[isValidate] ="+comment.IsValidate+",[Note] = "+comment.Note+",[isReported] = "+comment.IsReported +" WHERE id_comment = "+comment.ID_Comment );
            return repo.AddorUpdate("INSERT INTO [dbo].[T_Comments] ([Id_User],[ID_Movie],[message],[release_date],[isValidate],[Note],[isReported]) VALUES (" + comment.Id_User + "," + comment.Id_Movie + ", '" + comment.Message + "', '" + comment.RealeaseDate.ToString("yyyy/MM/DD") + "',1," + comment.Note + ", 0)");
        }

        public override bool DesactiveActive(int id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Comment> Get()
        {
            throw new NotImplementedException();
        }

        public override Comment GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
