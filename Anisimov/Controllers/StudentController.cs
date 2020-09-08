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
        
        [Route("{id}")]
        public IActionResult StudentDetails(int id)
        {
            var employee = this.studentsService.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new StudentViewModel());

            var model = this.studentsService.GetById(id.Value);
            if (model == null)
                return NotFound();// возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(StudentViewModel model)
        {
            if (model.Id > 0) // если есть Id, то редактируем модель
            {
                var dbItem = this.studentsService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found

                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Class = model.Class;
            }
            else // иначе добавляем модель в список
            {
                this.studentsService.AddNew(model);
            }
            this.studentsService.Commit(); // станет актуальным позднее (когда добавим БД)

            return RedirectToAction(nameof(Students));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            this.studentsService.Delete(id);
            return RedirectToAction(nameof(Students));
        }
    }
}
