﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_PROJECT.Controllers
{

  [AllowAnonymous]
  public class AdminController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public PartialViewResult AdminNavBarPartial()
    {
      return PartialView();
    }
  }
}
