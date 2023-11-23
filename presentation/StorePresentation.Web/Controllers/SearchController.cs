using Microsoft.AspNetCore.Mvc;
using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePresentation.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProjRepository projRepository;

        public SearchController(IProjRepository projRepository)
        {
            this.projRepository = projRepository;
        }
        public IActionResult Index(string query)
        {
            var projs = projRepository.GetAllByTitle(query);
            
            return View(projs);
        }
    }
}
