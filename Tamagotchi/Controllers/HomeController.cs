using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/new-critter")]
        public ActionResult NewCritter()
        {
            return View();
        }

        [HttpGet("/critters")]
        public ActionResult Critters()
        {
            List<Critter> allCritters = Critter.GetAll();
            return View(allCritters);

        }

        [HttpPost("/critters")]
        public ActionResult Create()
        {
            Critter newCritter = new Critter(Request.Form["new-critter"]);
            List<Critter> allCritters = Critter.GetAll();
            return View("Index", allCritters);
        }

        [HttpGet("/critters/{id}")]
        public ActionResult CritterDetail(int id)
        {
            Critter critter = Critter.Find(id);
            return View(critter);
        }
    }
}
