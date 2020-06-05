using Microsoft.EntityFrameworkCore;
using Pexeso.PexesoCore.Entity;
using PexesoTest.PexesoCore.Service.CommentService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pexeso.PexesoCore.Service.CommentService
{
    [Serializable]
    public class CommentServiceEF : ICommentService
    {
        public void AddComment(Comment comment)
        {
            using (var context = new PexesoDbContext())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }

        [Obsolete]
        public void ClearComment()
        {
            using (var context = new PexesoDbContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Scores");
            }
        }

        public IList<Comment> GetTopComment()
        {
            using (var context = new PexesoDbContext())
            {
                return (from s in context.Comments
                        orderby s.Comments
                            descending
                        select s).Take(5).ToList();
            }
        }
    }
}
