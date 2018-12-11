using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Czar.Cms.DB;
using Microsoft.AspNetCore.Mvc;

namespace Czar.Cms.Admin.Controllers
{
    public class USaleOrderController : Controller
    {
        private readonly cy_platform_rcContext _context;
        public USaleOrderController(cy_platform_rcContext Context)
        {
            _context = Context;
        }

        public IActionResult USaleOrder()
        {
            return View(_context.USaleOrder.ToList());
        }
    }
}