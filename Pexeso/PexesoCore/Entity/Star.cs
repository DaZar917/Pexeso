using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pexeso.PexesoCore.Entity
{
    [Serializable]
    public class Star
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set;  }
        
        public string Player { get; set; }

        public int Stars { get; set; }
    }
}