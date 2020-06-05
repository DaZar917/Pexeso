using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Pexeso.PexesoCore.Entity;

namespace Pexeso.PexesoCore.Service.StarService
{
    public class StarServiceFile : IStarService
    {
        private const string FileName = "Star.bin";
        

        private List<Star> _stars = new List<Star>();

        public void AddStar(Star star)
        {
            _stars.Add(star);

            SaveStar();
        }
        

        

        public IList<Star> GetStars()
        {
            LoadStar();
            return (from s in _stars orderby s.Stars descending select s).ToList();
            
        }
        
        

        public void ClearStars()
        {
            _stars.Clear();
            File.Delete(FileName);
        }



        private void SaveStar()
        {
            using (var fs = File.OpenWrite(FileName))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, _stars);
            }
        }
        
        

        private void LoadStar()
        {
            if (File.Exists(FileName))
            {
                using (var fs = File.OpenRead(FileName))
                {
                    var bf = new BinaryFormatter();
                    _stars = (List<Star>)bf.Deserialize(fs);
                }
            }
        }
    }
}