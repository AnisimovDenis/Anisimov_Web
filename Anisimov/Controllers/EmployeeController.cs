using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anisimov.Infrastructure.Interfaces;
using Anisimov.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anisimov.Controllers
{
    //[Route("users/[action]")]
    [Route("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService employeesService;

        public EmployeeController(IEmployeesService employeesService)
        {
            this.employeesService = employeesService;
        }

        [Route("all")]
        public IActionResult Employees()
        {
            return View(this.employeesService.GetAll());
        }

        [Route("{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            var employee = this.employeesService.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}
