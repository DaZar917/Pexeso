using Microsoft.EntityFrameworkCore;
using Pexeso.PexesoCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pexeso.PexesoCore.Service.TimeService
{
    [Serializable]
    public class TimeServiceEF : ITimeService
    {
 
        public void AddScore(Time time)
        {
            using (var context = new PexesoDbContext())
            {
               
                context.Times.Add(time);
                context.SaveChanges();
            }
        }

        public IList<Time> GetTopTime()
        {
            using (var context = new PexesoDbContext())
            {
                return (from s in context.Times
                        orderby s.TimeInSeconds
                           
                        select s).Take(5).ToList();
            }
        }

        [Obsolete]
        public void ClearTime()
        {
            using (var context = new PexesoDbContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Times");
            }
        }
    }
}
