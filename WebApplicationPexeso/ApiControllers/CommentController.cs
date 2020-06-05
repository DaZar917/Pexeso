using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service.CommentService;
using PexesoTest.PexesoCore.Service.CommentService;

namespace WebApplicationPexeso.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _scoreService = new CommentServiceFile();

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _scoreService.GetTopComment();
        }

        // POST: api/Comment
        [HttpPost]
        public void Post([FromBody] Comment comment)
        {
            _scoreService.AddComment(comment);
        }
    }
}