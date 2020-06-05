using System;
using Pexeso.PexesoCore.Core;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service;
using Pexeso.PexesoCore.Service.CommentService;
using Pexeso.PexesoCore.Service.StarService;
using Pexeso.PexesoCore.Service.TimeService;
using Pexeso.PexesoUI.Mode;
using PexesoTest.PexesoCore.Service.CommentService;

namespace Pexeso.PexesoUI
{
    [Serializable]
    public class Ui
    {


        private readonly ITimeService _timeService = new TimeServiceEF();
        private readonly ICommentService _commentService = new CommentServiceEF();
        private readonly IStarService _starService = new StarServiceEF();

        public void Play()
        {
           
            while (true)
            { 
                StartingGame startingGame = new StartingGame(_commentService,_starService);
                startingGame.StartTheGame();
                Field maps = new Field();
                maps.CreateMaps();
                SinglePlayerMode singlePlayerMode = new SinglePlayerMode(maps.Map,maps.MapSize,maps.Cells);
                MultiPlayerMode multiPlayerMode = new MultiPlayerMode(maps.Map,maps.MapSize,maps.Cells);
                switch (startingGame.Mode)
                {
                    case "1":
                        singlePlayerMode.EnterYourName();
                        singlePlayerMode.StartSinglePlayerGame();
                        singlePlayerMode.End();
                        break;
                    case "2" :
                        multiPlayerMode.EnterYourName();
                        multiPlayerMode.StartMultiPlayerGame();
                        multiPlayerMode.End();
                        break;
                }
                _timeService.AddScore(new Time{Player = singlePlayerMode.UserName, TimeInSeconds = singlePlayerMode.ResultTime});
                Console.Write("Do you want restart?(yes/no) ");
                string restart = Console.ReadLine();
                while (restart != "yes" && restart != "no"&&restart != "y"&&restart != "n")
                {
                    restart = Console.ReadLine();
                }
                if (restart == "no"||restart == "n")
                {
                    
                    break;
                }
            }
            Console.WriteLine("Good bye");
        }
        
        
        
        public void Print(Cell[,] objectMap)
        {
            int mapSize = (int) Math.Sqrt(objectMap.Length);
            for (int i = 0; i < mapSize+1; i++)
            {
                Console.Write("========");
            }
            Console.WriteLine();
            for (var i = 0; i < mapSize; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(mapSize- i + "|\t");
                Console.ResetColor();
                for (var j = 0; j < mapSize; j++)
                {
                    Console.Write("|{0}|\t", objectMap[i, j].Value);
                }
                Console.WriteLine();
            }
            for (int i = 0; i <mapSize + 1; i++)
            {
                Console.Write("========");
            }
            Console.WriteLine();Console.Write("\t ");
            for (var i = 1; i < mapSize + 1 ; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i + " \t ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Top scores:");
            Console.ResetColor();
            foreach (var time in _timeService.GetTopTime())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}'s time: ", time.Player);
                Console.ResetColor();
                Console.WriteLine("{0} seconds", time.TimeInSeconds);
            }
        }

        public void PrintComments()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Comments:");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var comment in _commentService.GetTopComment())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}'s comment: ", comment.Player);
                Console.ResetColor();
                Console.Write("{0}\n", comment.Comments);
            }
        }
        
        public void PrintMarks()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Marks:");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var star in _starService.GetStars()) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}'s mark: ", star.Player);
                Console.ResetColor();
                string stars = "";
                for (int i = 0; i < star.Stars; i++)
                {
                    stars = stars + "⭐ ";
                }
                Console.Write("{0}\n", stars);
            }
        }

        public static void PickCard(ref int firstCardY ,ref int firstCardX,ref int size,ref Cell[,] objectTable,ref int secondCardY ,ref int secondCardX)
        {

            Console.WriteLine("Pick your first card coordinate ( max size : " + (size ) + " ) :");
            while (true)
            {
                Console.Write("First card X: (→)");
                firstCardX =  CheckInt() - 1;
                while (firstCardX < 0 || firstCardX > size-1 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("First card ( max size : " + (size) + " ) X: (→)");
                    Console.ResetColor();
                    firstCardX = CheckInt() - 1;
                }
                Console.Write( "First card Y: (↑)"); 
                firstCardY = size - CheckInt() ;
                while (firstCardY< 0 || firstCardY > size -1 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("First card ( max size : " +  (size) + " ) Y: (↑)");
                    Console.ResetColor();
                    firstCardY = size -CheckInt() ;
                }
                if (objectTable[firstCardY, firstCardX].Value == 'X')
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This card has been peeked!");
                Console.WriteLine("Pick your first card coordinate ( max size : " + (size ) + " ) :");
                Console.ResetColor();
            }
            Console.WriteLine("Pick your second card coordinate: ( max size : " + (size ) + " ) :");
            while (true)
            {
                Console.Write("Second card X: (→)");
                secondCardX = CheckInt() - 1;
                while (secondCardX < 0 || secondCardX > size-1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Second card ( max size : " + (size) + " ) X: (→)");
                    Console.ResetColor();
                    secondCardX =  CheckInt() - 1;
                }
                Console.Write("Second card Y: (↑)");
                secondCardY =size - CheckInt();
                while (secondCardY < 0 || secondCardY > size - 1 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Second card ( max size : " +  (size) + " ) Y: (↑)");
                    Console.ResetColor();
                    secondCardY = size - CheckInt() ;
                }
                if (objectTable[secondCardY, secondCardX].Value == 'X' && (firstCardY != secondCardY || firstCardX != secondCardX))
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This card has been peeked!");
                Console.WriteLine("Pick your second card coordinate: ( max size : " + (size ) + " ) :");
                Console.ResetColor();
            }
        }

        public void PexesoPrintUp()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------Pexeso-------------");
            Console.WriteLine("------------↓Result↓------------");
            Console.WriteLine("-------------Pexeso-------------");
            Console.ResetColor();
        }

        public void PexesoPrintDown()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------Pexeso-------------");
            Console.WriteLine("------------↑Result↑------------");
            Console.WriteLine("-------------Pexeso-------------\n");
            Console.ResetColor();
        }

        public void PexesoOneLine()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------Pexeso-------------");
            Console.ResetColor();
        }

        public static void PrintPlayersScore(int firstCardX,int firstCardY,int secondCardX, int secondCardY)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Got it! " + "\nCoordinates of First card( " + firstCardX + ", " + firstCardY +
                              " );" + "\nCoordinates of Second card( " + secondCardX + ", " + secondCardY + " );");
            Console.ResetColor();
        }


        public static void MultiplayerSteps(string playerName)
        {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerName + "'s step");
                Console.ResetColor();
        }

        public static void MultiplayerEnd(string firstPlayer,string secondPlayer,int firstPlayerScore,int secondPlayerScore)
        {
            if (firstPlayerScore > secondPlayerScore)
            {
                Console.WriteLine(firstPlayer + " win!");
            }
            else if (secondPlayerScore < firstPlayerScore)
            {
                Console.WriteLine(secondPlayer + " win!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.WriteLine( firstPlayer + "'s score: " + firstPlayerScore + "\t" + secondPlayer+  "'s score: " + secondPlayerScore);
        }
        


        public void AddBaseTop(ITimeService _timeService, ICommentService _commentService,IStarService _starService)
        {
            _timeService.AddScore(new Time { Player = "John", TimeInSeconds = 15 });
            _timeService.AddScore(new Time { Player = "Emily", TimeInSeconds = 20 });
            _timeService.AddScore(new Time { Player = "Tom", TimeInSeconds = 25 });
            _timeService.AddScore(new Time { Player = "Alex", TimeInSeconds = 30 });
            _timeService.AddScore(new Time { Player = "Martin", TimeInSeconds = 35 });

            _commentService.AddComment(new Comment { Player = "John", Comments = "It’s like nintendo forgot that their consoles are essentially family consoles which multiple people play on. Now I can’t really even enjoy the game because I share it with my sister and I wanted her to have a good time playing so I let her play first. Now im pretty much useless on the island other than being there and im not going to delete my little sisters save just because I want to be able to progress through the game. Nintendo really let me down on this one." });
            _commentService.AddComment(new Comment { Player = "Emily", Comments = "If you want to be friends with me, My friend code is 1092-4393-9799, If you register me as your friend, make sure to put down your friend code. I will often be Online in Mario Kart, so feel free to play with me." });
            _commentService.AddComment(new Comment { Player = "Tom", Comments = "Animal Crossing is everything you could ever want and expect, its lovely, cute characters, and lots of grinding! only thing i will leave bad about it is that if you buy it online expecting to play with your switch and switch lite to play with your family, expect it to be pricey as you WILL have to purchase ANOTHER of the same game depending on how many switches you got so you can play together at the same time and have your own island (that more than 100dls per household) way to go." });

            _starService.AddStar(new Star { Player = "John", Stars = 4 });
            _starService.AddStar(new Star { Player = "Emily", Stars = 2 });
            _starService.AddStar(new Star { Player = "Tom", Stars = 3 });
        }


        public void SinglePlayerEnd(int playerTime)
        {
           
            Console.WriteLine("You win! Good job!");
            Console.WriteLine("Your time: " + playerTime + "\n");
        }

        public static int CheckInt()
        {
            while (true)
            {
                var input = Console.ReadLine();
                var value = 8;
                var success = true;

                try
                {
                    value = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.Write("Please repeat: ");
                    Console.ResetColor();
                    success = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("Please repeat: ");
                    success = false;
                }

                if ((!success)) continue;
                return value;
            }
        }
    }
}