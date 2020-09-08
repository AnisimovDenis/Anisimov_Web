using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anisimov.Infrastructure.Interfaces;
using Anisimov.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anisimov.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentsService studentsService;

        public StudentController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        public IActionResult Students()
        {
            return View(this.studentsService.GetAll());
        }
    }
}
