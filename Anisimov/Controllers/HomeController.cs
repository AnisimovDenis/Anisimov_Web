using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anisimov.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anisimov.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "Начальник"
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Position = "Программист"
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(_employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}
