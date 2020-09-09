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

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new EmployeeViewModel());

            var model = this.employeesService.GetById(id.Value);
            if (model == null)
                return NotFound();// возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeViewModel model)
        {
            if (model.Age < 18 || model.Age > 100)
            {
                ModelState.AddModelError("Age", "Ошибка возраста");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Id > 0) // если есть Id, то редактируем модель
            {
                var dbItem = this.employeesService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found

                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Position = model.Position;
            }
            else // иначе добавляем модель в список
            {
                this.employeesService.AddNew(model);
            }
            this.employeesService.Commit(); // станет актуальным позднее (когда добавим БД)

            return RedirectToAction(nameof(Employees));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            this.employeesService.Delete(id);
            return RedirectToAction(nameof(Employees));
        }
    }
}
