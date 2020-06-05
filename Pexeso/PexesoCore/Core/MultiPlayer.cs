using System;
namespace Pexeso.PexesoCore.Core
{
    [Serializable]
    public class MultiPlayer
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Print { get; set; }
        public int Size { get; set; }

        public MultiPlayer(string fname, string sname, int print, int size)
        {
            FName = fname;
            SName = sname;
            Print = print;
            Size = size;
        }

        public MultiPlayer()
        {

        }
    }
}
