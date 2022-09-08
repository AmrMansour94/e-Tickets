using e_Tickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _ctx;
        public MoviesController(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _ctx.Movies.ToListAsync();
            return View(movies);
        }
    }
}
