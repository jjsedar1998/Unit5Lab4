using Microsoft.AspNetCore.Mvc;
using JSedarMVCApp.Models;

namespace JSedarMVCApp.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult JSView()
        {
            return View(uc.JsedarTables.ToList());
        }
    }
}
