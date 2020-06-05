using System;
using System.Threading;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service.StarService;
using PexesoTest.PexesoCore.Service.CommentService;

namespace Pexeso.PexesoUI
{
    public class StartingGame
    {
        public string Mode { get; private set; }
        private readonly ICommentService _commentService;
        private readonly IStarService _starService;
        private readonly Ui _ui = new Ui();

        public StartingGame(ICommentService commentService, IStarService starService)
        {
            _commentService = commentService;
            _starService = starService;
        }

        public void StartTheGame()
        {
            _ui.PexesoOneLine();
            Console.Write("Choose your mode ( Single player/multi players/rules/write comment/read comments/top score ): ");
            string mode = Console.ReadLine();
            while (( mode != "1" && mode != "2" )||  mode == "3" || mode == "4" || mode == "5" || mode == "6" )
            {
                if (mode == "3")
                {
                    const string rules = "A deck of shuffled cards where each card appears twice is placed in front of you\nwith the cards facing down so you can see which card is where. The idea is to\nmatch the pairs of cards until there are no more cards available. At each turn\nyou are allowed to flip two cards.";
                    foreach (var t in rules)
                    {
                        Console.Write(t);
                        Thread.Sleep( 20 );
                    }
                    Console.WriteLine();
                    _ui.PexesoOneLine();
                }
                else if (mode == "4" )
                {
                    Console.Write("Player name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Star: ");
                    int stars = Ui.CheckInt();
                    while (stars > 5 || stars < 0)
                    {
                        Console.Write("Star (MAX 5): ");
                        stars = Ui.CheckInt();
                    }
                    Console.Write("Your comment: ");
                    string comment = Console.ReadLine();
                    _commentService.AddComment(new Comment{ Player = userName, Comments = comment});
                    _starService.AddStar(new Star{ Player = userName,Stars = stars});
                }
                else if ( mode == "5" )
                {
                    _ui.PexesoOneLine();
                    _ui.PrintComments();
                    _ui.PexesoOneLine();
                    _ui.PrintMarks();
                    _ui.PexesoOneLine();
                }
                else if( mode == "6" )
                {
                    _ui.PexesoOneLine();
                    _ui.PrintScore();
                    _ui.PexesoOneLine();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Single player");
                Console.WriteLine("2. Multi players");
                Console.WriteLine("3. Rules");
                Console.WriteLine("4. Write comment");
                Console.WriteLine("5. Read comments");
                Console.WriteLine("6. Top score");
                Console.Write("Choose your mode (Press a key (1/2/3/4/5/6)): ");
                Console.ResetColor();
                mode = Console.ReadLine();
                
            }
            ChosenMode(mode);
            Mode = mode;

        }

        private void ChosenMode( string mode )
        {
            switch (mode)
            {
                case "1":
                    Console.WriteLine("\nYou select single player mode.");
                    break;
                    
                case "2":
                    Console.WriteLine("\nYou select multi player mode.");
                    break;
            }
        }
    }
}