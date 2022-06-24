using DevOpsTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
using Microsoft.AspNetCore.Authorization;
using DevOpsTask.Areas.Identity.Data;

namespace DevOpsTask.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly DevOpsTaskIdentityDbContext _context;
        public AdminController(DevOpsTaskIdentityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
