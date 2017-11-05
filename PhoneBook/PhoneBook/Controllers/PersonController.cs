using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Services;
using PhoneBook.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneBook.Controllers
{
    public class PersonController : Controller
    {
        protected SourceManager SourceManager;

        [HttpGet]
        public IActionResult Index()
        {
            

            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonModel personModel)
        {
            

            return View();
        }

        public PersonController()
        {
            SourceManager = new SourceManager();
        }
        [HttpGet]
        public IActionResult Create()
        {
                   
            return View();
        }
        [HttpPost]
        public IActionResult ConfirmCreate(PersonModel personModel)
        {
            SourceManager.Add(personModel);

            return View();
        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var s = SourceManager.GetByID(id);
            return View(s);
        }
        [HttpPost]
        public IActionResult ConfirmRemove(int id)
        {
            SourceManager.Remove(id);
            //ViewBag.Message = $"Person has been deleted.";
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ConfirmUpdate(PersonModel personModel)
        {
            SourceManager.Update(personModel);

            return View();
        }
    }

}
