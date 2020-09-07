using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anisimov.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anisimov.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<StudentViewModel> _students = new List<StudentViewModel>
        {
            new StudentViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Age = 22,
                Class = 3
            },
            new StudentViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Age = 35,
                Class = 4
            }
        };

        public IActionResult Students()
        {
            return View(_students);
        }
    }
}
