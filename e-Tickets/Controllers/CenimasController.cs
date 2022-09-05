using e_Tickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Controllers
{
    public class CenimasController : Controller
    {
        private readonly AppDbContext _ctx;
        public CenimasController(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var cenimas = await _ctx.Cenimas.ToListAsync();
            return View();
        }
    }
}
