using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index1()
    {
      return View();
    }

    public IActionResult AdamI()
        {
            return View();
        }

    public IActionResult MichaelK()
        {
            return View();
        }

    public IActionResult IndexLayout()
    {
      return View();
    }
  }
}