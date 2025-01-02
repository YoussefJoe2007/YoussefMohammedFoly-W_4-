using Microsoft.AspNetCore.Mvc;
using YoussefMohammedFoly_W_4_.Data;
using YoussefMohammedFoly_W_4_.Models;

namespace YoussefMohammedFoly_W_4_.Controllers
{
    //Controller
    public class JobController : Controller
    {
        public DB_Connection _Context;

        public JobController(DB_Connection context)
        {
            _Context = context;
        }



        public IActionResult Index(int id_input)
        {
            ViewData["id"] = id_input;
            var f = _Context.Jobs.Where(x => x.ProjectId == id_input).ToList();
            return View(f);
        }


        [HttpPost]
        public IActionResult Create(Job x)
        {
            _Context.Jobs.Add(x);
            _Context.SaveChanges();
            return RedirectToAction("index", new { id_input = x.ProjectId });
        }

        public IActionResult Delete(int ID)
        {
            var Response = _Context.Jobs.Find(ID);
            var Project = Response.ProjectId;
            _Context.Jobs.Remove(Response);
            _Context.SaveChanges();
            return RedirectToAction("index", new { id_input = Project });
        }

        public IActionResult updateform(int ID)
        {
            ViewData["ID"] = ID;
            return View();
        }

        public IActionResult update(string Status, int ID)
        {
            var Response = _Context.Jobs.Find(ID);
            Response.Status = Status;
            var X = Response.ProjectId;

            _Context.SaveChanges();
            return RedirectToAction("Index", new { id_input = X });
        }
    }
}
