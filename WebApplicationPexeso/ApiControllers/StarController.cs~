using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service.StarService;

namespace WebApplicationPexeso.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarController : ControllerBase
    {
        private readonly IStarService _scoreService = new StarServiceFile();

        // GET: api/Star
        [HttpGet]
        public IEnumerable<Star> Get()
        {
            return _scoreService.GetStars();
        }

        // POST: api/Star
        [HttpPost]
        public void Post([FromBody] Star star)
        {
            _scoreService.AddStar(star);
        }
    }
}