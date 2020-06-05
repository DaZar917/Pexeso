using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Pexeso.PexesoCore.Entity;

namespace Pexeso.PexesoCore.Service
{

    public class TimeServiceFile : ITimeService
    {
        
            private const string FileName = "time.bin";

            private List<Time> times = new List<Time>();

            public void AddScore(Time time)
            {
                times.Add(time);

                SaveScore();
            }

        
            
            

            public IList<Time> GetTopTime()
            {
                LoadScore();

                return (from s in times orderby s.TimeInSeconds select s).Take(5).ToList();

                //return scores.OrderByDescending(s => s.Points).Select(s => s).Take(3).ToList();
            }

            public void ClearTime()
            {
                times.Clear();
                File.Delete(FileName);
            }


            private void SaveScore()
            {
                using (var fs = File.OpenWrite(FileName))
                {
                    var bf = new BinaryFormatter();
                    bf.Serialize(fs, times);
                }
            }

            private void LoadScore()
            {
                if (File.Exists(FileName))
                {
                    using (var fs = File.OpenRead(FileName))
                    {
                        var bf = new BinaryFormatter();
                        times = (List<Time>)bf.Deserialize(fs);
                    }
                }
            }

    }
}