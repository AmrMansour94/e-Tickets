using e_Tickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _ctx;

        public ActorsController(AppDbContext context)
        {
            _ctx = context;
        }
        public IActionResult Index()
        {
            var data = _ctx.Actors.ToList();
            return View(data);
        }
    }
}
