using System.Collections.Generic;
using Pexeso.PexesoCore.Entity;

namespace PexesoTest.PexesoCore.Service.CommentService
{
    public interface ICommentService
    {
        void AddComment(Comment comment);

        IList<Comment> GetTopComment();
        
        void ClearComment();
    }
}