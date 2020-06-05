using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Pexeso.PexesoCore.Entity;

namespace PexesoTest.PexesoCore.Service.CommentService
{
    public class CommentServiceFile : ICommentService
    {
        
        private const string FileName = "Comment.bin";

        private List<Comment> _comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);

            SaveComment();
        }

        

        public IList<Comment> GetTopComment()
        {
            LoadComment();
            return (from s in _comments orderby s.Comments ascending select s).ToList();
        }

        public void ClearComment()
        {
            _comments.Clear();
            File.Delete(FileName);
        }


        private void SaveComment()
        {
            using (var fs = File.OpenWrite(FileName))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, _comments);
            }
        }

        private void LoadComment()
        {
            if (File.Exists(FileName))
            {
                using (var fs = File.OpenRead(FileName))
                {
                    var bf = new BinaryFormatter();
                    _comments = (List<Comment>)bf.Deserialize(fs);
                }
            }
        }

    }
}