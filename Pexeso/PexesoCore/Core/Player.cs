using System;
namespace Pexeso.PexesoCore
{
    [Serializable]
    public class Player
    {
        public string Name { get;  set; }
        public int Print { get;  set; }
        public int Size { get;  set; }

        public Player(string name, int print, int size)
        {
            Name = name;
            Print = print;
            Size = size;
        }

        public Player()
        {

        }

    }
}
