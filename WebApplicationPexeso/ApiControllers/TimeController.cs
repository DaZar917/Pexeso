using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service;
using Pexeso.PexesoCore.Service.TimeService;

namespace WebApplicationPexeso.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITimeService _scoreService = new TimeServiceEF();

        // GET: api/Time
        [HttpGet]
        public IEnumerable<Time> Get()
        {
            return _scoreService.GetTopTime();
        }

        // POST: api/Time
        [HttpPost]
        public void Post([FromBody] Time time)
        {
            _scoreService.AddScore(time);
        }
    }
}