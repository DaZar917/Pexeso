using Pexeso.PexesoCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pexeso.PexesoCore.Service.StarService
{
    [Serializable]
    public class StarServiceEF : IStarService
    {
        public void AddStar(Star star)
        {
            using (var context = new PexesoDbContext())
            {
                context.Stars.Add(star);
                context.SaveChanges();
            }
        }

        public IList<Star> GetStars()
        {
            using (var context = new PexesoDbContext())
            {
                return (from s in context.Stars
                        orderby s.Stars
                            descending
                        select s).Take(5).ToList();
            }
        }

        [Obsolete]
        public void ClearStars()
        {
            using (var context = new PexesoDbContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Scores");
            }
        }
    }
}
