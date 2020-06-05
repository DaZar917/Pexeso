using Pexeso.PexesoCore.Core;
using Pexeso.PexesoCore.Entity;
using System.Collections.Generic;

namespace WebApplicationPexeso.Models
{
    public class PexesoModel
    {
            public Field Field { get; set; }

            public string Message { get; set; }

            public IList<Time> Times { get; set; }

            public IList<Star> Stars { get; set; }

            public IList<Comment> Comments { get; set; }
    }
}
