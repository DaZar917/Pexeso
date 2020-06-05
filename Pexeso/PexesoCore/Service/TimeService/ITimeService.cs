using System.Collections.Generic;
using Pexeso.PexesoCore.Entity;

namespace Pexeso.PexesoCore.Service
{
    public interface ITimeService
    {
        void AddScore(Time time);

        IList<Time> GetTopTime();
        
        void ClearTime();
    }
}