using System;

namespace Pexeso.PexesoCore.Core
{
    [Serializable]
    public class Cell
    {
        public char Value { get; set; }

        public Cell(char value)
        {
            Value = value;
        }
    }
}