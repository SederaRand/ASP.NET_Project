using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Alltech.FrontOffice.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return ViewResult();
        }

        private IActionResult ViewResult()
        {
            throw new NotImplementedException();
        }
    }
}