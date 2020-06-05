using System;
using Pexeso.PexesoCore.Core;

namespace Pexeso.PexesoUI.Mode
{
    public class SinglePlayerMode
    {
        
        private readonly int[,] _table;
        private int Score { get; set; }
        public int ResultTime { get; private set; }
        private int _size ;
        public int _firstCardX = -1;
        public int _firstCardY = -1;
        public int _secondCardX = -1;
        public int _secondCardY =-1;
        private Cell[,] _objectTable;
        public string UserName { get; set; }
        private readonly Ui _ui = new Ui();




       
        public SinglePlayerMode(int[,] table, int size, Cell[,] objectTable)
        {
            _table = table;
            _size = size;
            _objectTable = objectTable;
        }

        public void StartSinglePlayerGame()
        {
            int startTime = Environment.TickCount;
            _ui.PrintScore();
            _ui.PexesoOneLine();
            _ui.Print(_objectTable);
            Ui.PickCard(ref _firstCardX, ref _firstCardY, ref _size,ref _objectTable,ref _secondCardX,ref _secondCardY);
            ResultTime = (Environment.TickCount - startTime)/1000;
            Console.WriteLine("Second: " + ResultTime);
            _ui.PexesoPrintUp();
            AddScore();
            while (Field.CheckMap(_table,_size))
            {
                StartSinglePlayerGame();
                _ui.PexesoOneLine();
            }
            ResultTime = (Environment.TickCount - startTime)/1000;
        }

        private void AddScore()
        {
            if (_table[_firstCardX, _firstCardY] == _table[_secondCardX, _secondCardY] &&
                 (_firstCardX != _secondCardX || _firstCardY != _secondCardY))
            {
                Score += 100;
                UpdateTable(_table); 
                Console.ForegroundColor = ConsoleColor.Green;
                Ui.PrintPlayersScore(_firstCardX,_firstCardY,_secondCardX,_secondCardY);
                _ui.PexesoPrintDown();
            }
            else
            {
                UpdateTable(_table);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ooops... Nothing!");
                Console.ResetColor();
                _ui.PexesoPrintDown();
            }
            Console.WriteLine();
        }
        
        private void UpdateTable(int[,] toUpdate)
        {
            Console.WriteLine("Your score: " + Score + "\n");
            if (_firstCardX != -1 &&_firstCardY != -1 &&_secondCardX != -1 &&_secondCardY != -1 )
            {
                _objectTable[_firstCardX, _firstCardY].Value = (char) (toUpdate[_firstCardX, _firstCardY] + 65 );
                _objectTable[_secondCardX, _secondCardY].Value = (char) (toUpdate[_secondCardX, _secondCardY] + 65);

            }
            _ui.Print(_objectTable);
            if (_firstCardX != -1 && _firstCardY != -1 && _secondCardX != -1 && _secondCardY != -1)
            {
                if (toUpdate[_firstCardX, _firstCardY] != toUpdate[_secondCardX, _secondCardY])
                {
                    _objectTable[_firstCardX, _firstCardY].Value = 'X';
                    _objectTable[_secondCardX, _secondCardY].Value = 'X';
                }
                else
                {
                    _table[_firstCardX, _firstCardY] = -1;
                    _table[_secondCardX, _secondCardY] = -1;
                }
            }
        }

        public void EnterYourName()
        {
            Console.Write("Player name: ");
            UserName = Console.ReadLine(); 
        }

        public void End()
        {
            _ui.SinglePlayerEnd(ResultTime);
        }
    }
}