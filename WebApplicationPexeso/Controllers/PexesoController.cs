using Microsoft.AspNetCore.Mvc;
using Pexeso.PexesoCore;
using Pexeso.PexesoCore.Core;
using Pexeso.PexesoCore.Entity;
using Pexeso.PexesoCore.Service;
using Pexeso.PexesoCore.Service.CommentService;
using Pexeso.PexesoCore.Service.StarService;
using Pexeso.PexesoCore.Service.TimeService;
using Pexeso.PexesoUI;
using PexesoTest.PexesoCore.Service.CommentService;
using WebApplicationPexeso.ApiControllers;
using WebApplicationPexeso.Models;

namespace WebApplicationPexeso.Controllers
{
    public class PexesoController : Controller
    {

		CommentController commentController = new CommentController();
		StarController starController = new StarController();
		ITimeService _scoreService = new TimeServiceFile();
		IStarService _starService = new StarServiceFile();
		ICommentService _commentService = new CommentServiceFile();
        Ui ui = new Ui();

		public IActionResult Index()
        {
            ui.AddBaseTop(_scoreService,_commentService,_starService);
            return View();
        }

        public IActionResult SingleMode()
        {

            

            var model = PrepareModel("New field created");

            model.Field.CreateMap(model.Field.MapSize);
            HttpContext.Session.SetObject("field", model.Field);
            
            return View(model);
        }

        public IActionResult MultiMode()
        {
            var model = PrepareModel("New field created");

            model.Field.CreateMap(model.Field.MapSize);
            HttpContext.Session.SetObject("field", model.Field);
            return View(model);
        }

        public ViewResult Comments()
        {
            ui.AddBaseTop(_scoreService, _commentService, _starService);
            PexesoModel model = prepareModelForComments("Comment Complete");
            return View(model);
        }

        public ViewResult TopScores()
        {
            ui.AddBaseTop(_scoreService, _commentService, _starService);
            PexesoModel model = prepareModelForScores("Score Complete");
            return View(model);
        }

        public IActionResult AddComments(string name, int reviewStars, string comment)
        {
            ui.AddBaseTop(_scoreService, _commentService, _starService);
            commentController.Post(new Comment { Player = name, Comments = comment });
			starController.Post(new Star { Player = name, Stars = reviewStars });
			return View();
        }
        public ViewResult About()
        {
            PexesoModel model = prepareModelForComments("Comment Complete");
            return View(model);
        }

        

        public IActionResult AddPlayer(string name, int print, int size)
        {
            if(name == null)
            {
                name = "John";
            }
            if(print == 0)
            {
                print = 1;
            }
            
            Field field = new Field();
            field.player = new Player(name, print, size);
            field.CreateMap(size);
            HttpContext.Session.SetObject("field", field);
            return View(field);
            
        }




        public IActionResult AddTwoPlayer(string fname, string sname, int print, int size)
        {
            if(fname == null)
            {
                fname = "John";
            }
            if(sname == null)
            {
                sname = "Mark";
            }
            if(print == 0)
            {
                print = 1;
            }
            Field field = new Field();
            field.multiPlayer = new MultiPlayer(fname, sname, print, size);
            field.CreateMap(size);
            HttpContext.Session.SetObject("field", field);
            return View("AddTwoPlayer",field);
        }















        private PexesoModel prepareModelForScores(string message)
        {
            return new PexesoModel
            {
               
				Times = _scoreService.GetTopTime()
			};
        }


        private PexesoModel prepareModelForComments(string message)
        {
            return new PexesoModel
            {
                Stars = _starService.GetStars(),
                Comments = _commentService.GetTopComment()
            };
        }

        private PexesoModel PrepareModel(string message)
        {
            return new PexesoModel
            {
                Field = (Field)HttpContext.Session.GetObject("field"),
                Message = message,
                Times = _scoreService.GetTopTime()
            };
        }


        public IActionResult NewMove(int x, int y)
        {
            var model = InitMove("New move");

            if (model.Field.Map[x, y] != -1)
            {
                model.Field.Cells[x, y].Value = (char)(model.Field.Map[x, y] + 65);

                if (model.Field._firstCardX != -1 && model.Field._firstCardY != -1 && model.Field._secondCardX != -1 && model.Field._secondCardY != -1) //якщо присутні координати всіх карт
                {
                    if (model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value == model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value) //якщо карти одинакові
                    {
                        model.Field.Map[model.Field._firstCardX, model.Field._firstCardY] = -1;
                        model.Field.Map[model.Field._secondCardX, model.Field._secondCardY] = -1;
                        model.Field._firstCardX = -1;
                        model.Field._firstCardY = -1;
                        model.Field._secondCardX = -1;
                        model.Field._secondCardY = -1;
                        model.Field.Cells[x, y].Value = 'X';

                    }
                    else if (model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value != model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value) //якщо карти не одинакові
                    {
                        model.Field.Cells[x, y].Value = 'X';
                        model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value = 'X';
                        model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value = 'X';
                        model.Field._firstCardX = -1;
                        model.Field._firstCardY = -1;
                        model.Field._secondCardX = -1;
                        model.Field._secondCardY = -1;

                    }
                    else return Content("Error");
                }
                else if (model.Field._firstCardX == -1 && model.Field._firstCardY == -1 && model.Field._secondCardX == -1 && model.Field._secondCardY == -1) //якщо відсутні координати всіх карт
                {

                    model.Field._firstCardX = x;
                    model.Field._firstCardY = y;

                }
                else if (model.Field._firstCardX != -1 && model.Field._firstCardY != -1 && model.Field._secondCardX == -1 && model.Field._secondCardY == -1 && model.Field._firstCardX != model.Field._secondCardX && model.Field._firstCardY != model.Field._secondCardY) //якщо відсутні координати другої карти
                {

                    model.Field._secondCardX = model.Field._firstCardX;
                    model.Field._secondCardY = model.Field._firstCardY;

                    model.Field._firstCardX = x;
                    model.Field._firstCardY = y;
                }
            }
            HttpContext.Session.SetObject("field", model.Field);


            if (!model.Field.IsSolved())
            {
                return View("Win2", model);
            }

            return View("SingleMode", model);
        }



        public IActionResult NewMove1(int x, int y)
        {
            var model = InitMove("New move");

            if (model.Field.Map[x, y] != -1)
            {
                model.Field.Cells[x, y].Value = (char)(model.Field.Map[x, y] + 65);

                if (model.Field._firstCardX != -1 && model.Field._firstCardY != -1 && model.Field._secondCardX != -1 && model.Field._secondCardY != -1) //якщо присутні координати всіх карт
                {
                    if (model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value == model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value) //якщо карти одинакові
                    {
                        model.Field.Map[model.Field._firstCardX, model.Field._firstCardY] = -1;
                        model.Field.Map[model.Field._secondCardX, model.Field._secondCardY] = -1;
                        model.Field._firstCardX = -1;
                        model.Field._firstCardY = -1;
                        model.Field._secondCardX = -1;
                        model.Field._secondCardY = -1;
                        model.Field.Cells[x, y].Value = 'X';

                    }
                    else if (model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value != model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value) //якщо карти не одинакові
                    {
                        model.Field.Cells[x, y].Value = 'X';
                        model.Field.Cells[model.Field._firstCardX, model.Field._firstCardY].Value = 'X';
                        model.Field.Cells[model.Field._secondCardX, model.Field._secondCardY].Value = 'X';
                        model.Field._firstCardX = -1;
                        model.Field._firstCardY = -1;
                        model.Field._secondCardX = -1;
                        model.Field._secondCardY = -1;

                    }
                    else return Content("Error");
                }
                else if (model.Field._firstCardX == -1 && model.Field._firstCardY == -1 && model.Field._secondCardX == -1 && model.Field._secondCardY == -1) //якщо відсутні координати всіх карт
                {

                    model.Field._firstCardX = x;
                    model.Field._firstCardY = y;

                }
                else if (model.Field._firstCardX != -1 && model.Field._firstCardY != -1 && model.Field._secondCardX == -1 && model.Field._secondCardY == -1 && model.Field._firstCardX != model.Field._secondCardX && model.Field._firstCardY != model.Field._secondCardY) //якщо відсутні координати другої карти
                {

                    model.Field._secondCardX = model.Field._firstCardX;
                    model.Field._secondCardY = model.Field._firstCardY;

                    model.Field._firstCardX = x;
                    model.Field._firstCardY = y;
                }
            }
            HttpContext.Session.SetObject("field", model.Field);


            if (!model.Field.IsSolved())
            {
                return View("Win1",model);
            }

            return View("MultiMode", model);
        }












        private PexesoModel InitMove(string message)
        {
            return new PexesoModel
            {
                Field = (Field)HttpContext.Session.GetObject("field"),
                Message = message
            };
        }




    }












}