using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ViewController : Controller
    {
        IPropertyRepository _propRepos;
        public ViewController(IPropertyRepository propRepos)
        {
            _propRepos = propRepos;
        }


        public async Task<IActionResult> Index()
        {
            var properties = await _propRepos.GetProperties();
            return View(properties);
        }
    }
}
