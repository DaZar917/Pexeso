using System.Collections.Generic;
using Pexeso.PexesoCore.Entity;

namespace Pexeso.PexesoCore.Service.StarService
{
    public interface IStarService
    {
        void AddStar(Star star);

        IList<Star> GetStars();
        
        void ClearStars();
    }
}