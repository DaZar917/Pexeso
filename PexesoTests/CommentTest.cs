using NUnit.Framework;
using Pexeso.PexesoCore.Entity;
using PexesoTest.PexesoCore.Service.CommentService;

namespace PexesoTests
{
    public class CommentTests
    {
        private ICommentService IcommentService()
        {
            var commentService = new CommentServiceFile();
            commentService.ClearComment();
            return commentService;
        }

        [Test]
        public void PositiveAddComment1()
        {
            var commentService = IcommentService();
            commentService.AddComment(new Comment { Player = "Janko", Comments = "Game is not bad!" });
            var comment = commentService.GetTopComment();
            Assert.AreEqual(1, comment.Count);
            Assert.AreEqual("Janko", comment[0].Player);
            Assert.AreEqual("Game is not bad!", comment[0].Comments);
        }

        [Test]
        public void PositiveAddComment2()
        {
            var commentService = IcommentService();
            commentService.AddComment(new Comment { Player = "Jaro", Comments = "Index was out of range. Must be non-negative and less than the size of the collection." });
            var comment = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Kubo", Comments = "Parameter name: index at System.Collections.Generic.List`1.get_Item(Int32 index)" });
            comment = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Janko", Comments = "Well done!" });
            comment = commentService.GetTopComment();
            Check("Jaro", "Index was out of range. Must be non-negative and less than the size of the collection.", comment[0].Player, comment[0].Comments);
            Check("Kubo", "Parameter name: index at System.Collections.Generic.List`1.get_Item(Int32 index)", comment[1].Player, comment[1].Comments);
            Check("Janko", "Well done!", comment[2].Player, comment[2].Comments);
        }

        [Test]
        public void NegativeAddTime1()
        {
            var commentService = IcommentService();
            commentService.AddComment(new Comment { Player = "Jaro", Comments = "Index was out of range. Must be non-negative and less than the size of the collection." });
            var comment = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Kubo", Comments = "Parameter name: index at System.Collections.Generic.List`1.get_Item(Int32 index)" });
            comment = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Janko", Comments = "Well done!" });
            comment = commentService.GetTopComment();
            Check("Jaro", "Index was out of range. Must be non-negative and less than the size of the collection.", comment[0].Player, comment[0].Comments);
            Check("Kubo", "Parameter name: index at System.Collections.Generic.List`1.get_Item", comment[1].Player, comment[1].Comments); // NEG!!!!!
            Check("Janko", "Well done!", comment[2].Player, comment[2].Comments);
        }

        [Test]
        public void NegativeAddTime2()
        {
            var commentService = IcommentService();
            commentService.AddComment(new Comment { Player = "Jaro", Comments = "Index was out of range. Must be non-negative and less than the size of the collection." });
            var comment1 = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Kubo", Comments = "Parameter name: index at System.Collections.Generic.List`1.get_Item(Int32 index)" });
            var comment2 = commentService.GetTopComment();
            commentService.AddComment(new Comment { Player = "Janko", Comments = "Well done!" });
            var comment3 = commentService.GetTopComment();
            Check("Jaro", "Index was out of range. Must be non-negative and less than the size of the collection.", comment1[0].Player, comment1[0].Comments);
            Check("Kubo", "Parameter name: index at System.Collections.Generic.List`1.get_Item", comment1[1].Player, comment1[1].Comments); // NEG!!!!!
            Check("Janko", "Well done!", comment1[2].Player, comment1[2].Comments);//NEG!!!!
        }

        private void Check(string playerToCheck, string stringToCheck, string player, string comment)
        {
            Assert.AreEqual(playerToCheck, player);
            Assert.AreEqual(stringToCheck, comment);
        }
    }
}