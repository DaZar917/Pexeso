using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pexeso.PexesoCore.Entity
{
    [Serializable]

    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set;  }

        public string Player { get; set; }
        
        public string Comments { get; set; }
    }
}