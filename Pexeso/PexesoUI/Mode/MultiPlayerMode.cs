using System;
using Pexeso.PexesoCore.Core;

namespace Pexeso.PexesoUI.Mode
{
    public class MultiPlayerMode
    {
        
        
        private readonly int[,] _table;
        private int _firstPlayerScore ;
        private int _secondPlayerScore ;
        private bool _firstPlayerStep = true;
        private bool _secondPlayerStep;
        private int _firstCardX = -1;
        private int _firstCardY = -1;
        private int _secondCardX = -1;
        private int _secondCardY = -1;
        public string FirstPlayer { get; set; }
        public string SecondPlayer { get; set; }
        private string _firstPlayer;
        private string _secondPlayer;
        private Cell[,] _objectTable;
        private int _size;
        private readonly Ui _ui = new Ui();

        public MultiPlayerMode(int[,] table, int size,Cell[,] objectTable)
        {
            _table = table;
            _size = size;
            _objectTable = objectTable;
        }

        public void StartMultiPlayerGame()
        {
            _ui.PexesoOneLine();
            Ui.MultiplayerSteps(_firstPlayerStep ? _firstPlayer : _secondPlayer);
            _ui.Print(_objectTable); 
            Ui.PickCard(ref _firstCardX,ref _firstCardY,ref _size,ref _objectTable,ref _secondCardX,ref _secondCardY);
            _ui.PexesoOneLine();
           if (_firstPlayerStep)
            {
                Ui.MultiplayerSteps(_firstPlayer);
                FirstPlayerStep();
            }
            else if (_secondPlayerStep)
            {
                Ui.MultiplayerSteps(_secondPlayer);
                SecondPlayerStep();
            }
            while (CheckMap(_table))
            {
                Toggle();
                StartMultiPlayerGame();
                _ui.PexesoOneLine();
            }
        }
        
        

        private void UpdateTable(int[,] toUpdate)
        {
            Console.WriteLine(_firstPlayer + "'s score: " + _firstPlayerScore + "\t" + _secondPlayer + "'s score: " +
                              _secondPlayerScore);
            Console.WriteLine();
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
        
        private bool CheckMap(int[,] toCheck)
        {
            for (var i = 0; i < _size; i++)
            {
                for (var j = 0; j < _size; j++)
                {
                    if (toCheck[i,j] != -1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        private void Toggle()
        {
            _firstPlayerStep = !_firstPlayerStep;
            _secondPlayerStep = !_secondPlayerStep; 
        }

        private void FirstPlayerStep()
        {
            if (_table[_firstCardX,_firstCardY] == _table[_secondCardX,_secondCardY] && (_firstCardX != _secondCardX || _firstCardY != _secondCardY))
            {
                _firstPlayerScore += 100; 
                UpdateTable(_table);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Got it! " + "\nCoordinates of First card( " + _firstCardX + ", " + _firstCardY +
                                  " );" + "\nCoordinates of Second card( " + _secondCardX + ", " + _secondCardY + " );");
                Console.ResetColor();
            }
            else
            {
                UpdateTable(_table);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ooops... Nothing!");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------Pexeso-------------");Console.WriteLine("------------↑Result↑------------");Console.WriteLine("-------------Pexeso-------------\n");
            Console.ResetColor();
        }
        
        private void SecondPlayerStep()
        { 
            if (_table[_firstCardX,_firstCardY] == _table[_secondCardX,_secondCardY] && (_firstCardX != _secondCardX || _firstCardY != _secondCardY))
            {
                _secondPlayerScore += 100; 
                UpdateTable(_table);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Got it! " + "\nCoordinates of First card( " + _firstCardX + ", " + _firstCardY +
                                  " );" + "\nCoordinates of Second card( " + _secondCardX + ", " + _secondCardY + " );");
                Console.ResetColor();
            }
            else
            {
                UpdateTable(_table);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ooops... Nothing!");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------Pexeso-------------");Console.WriteLine("------------↑Result↑------------");Console.WriteLine("-------------Pexeso-------------\n");
            Console.ResetColor();
        }

        public void EnterYourName()
        {
            Console.Write("First player name: ");
            _firstPlayer = Console.ReadLine();
            
            Console.Write("Second player name: ");
            _secondPlayer = Console.ReadLine();
        }

        public void End()
        {
            Ui.MultiplayerEnd(_firstPlayer,_secondPlayer,_firstPlayerScore,_secondPlayerScore);
        }
    } 
}
