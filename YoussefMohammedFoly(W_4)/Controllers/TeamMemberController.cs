using Microsoft.AspNetCore.Mvc;
using YoussefMohammedFoly_W_4_.Data;
using YoussefMohammedFoly_W_4_.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace YoussefMohammedFoly_W_4_.Controllers
{
    public class TeamMemberController : Controller
    {
        public readonly DB_Connection _Context;

        public TeamMemberController(DB_Connection x)
        {
            _Context = x;
        }


        public IActionResult Index()
        {
            var x = _Context.TeamMembers.ToList();
            return View(x);
        }

        public IActionResult Delete(int id_input)
        {
            var Response = _Context.TeamMembers.Find(id_input);
            _Context.TeamMembers.Remove(Response);
            _Context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult _Create(TeamMember x)
        {
            _Context.TeamMembers.Add(x);
            _Context.SaveChanges();
            return RedirectToAction("index", new { id_input = x.Id });
        }

        [HttpPost]
        public IActionResult Create(Job x)
        {
            _Context.Jobs.Add(x);
            _Context.SaveChanges();
            return RedirectToAction("index", new { id_input = x.ProjectId });
        }
        public IActionResult view(int TM)
        {
            var x = _Context.Jobs.Where(x => x.TeamMemberId == TM).ToList();
            return View(x);
        }


    }



}
