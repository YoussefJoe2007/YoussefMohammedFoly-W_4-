using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YoussefMohammedFoly_W_4_.Data;
using YoussefMohammedFoly_W_4_.Models;

namespace YoussefMohammedFoly_W_4_.Controllers
{
    public class ProjectController : Controller
    {
        private readonly DB_Connection _Context;
        public ProjectController(DB_Connection context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            var x = _Context.projects.ToList();

            return View(x);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Project p)
        {
            if (ModelState.IsValid)
            {
                _Context.projects.Add(p);
                _Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }
        public IActionResult Delete(int id_input)
        {
            var Response = _Context.projects.Find(id_input);
            _Context.projects.Remove(Response);
            _Context.SaveChanges();
            return RedirectToAction("index");
        }


        [HttpPost]
        public IActionResult updateform(int id_input)
        {
            ViewData["id"] = id_input;
            return View();

        }
        [HttpPost]
        public IActionResult update(int ID, Project x)
        {
            var Response = _Context.projects.Find(ID);
            Response.Name = x.Name;
            Response.Description = x.Description;
            Response.StartDate = x.StartDate;
            Response.EndDate = x.EndDate;
            _Context.SaveChanges();

            return RedirectToAction("index");

        }
    }
}
