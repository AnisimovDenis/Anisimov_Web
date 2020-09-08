using Anisimov.Infrastructure.Interfaces;
using Anisimov.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anisimov.Infrastructure.Services
{
    public class InMemoryStudentsService : IStudentsService
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

        public IEnumerable<StudentViewModel> GetAll()
        {
            return _students;
        }

        public StudentViewModel GetById(int id)
        {
            return _students.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Commit()
        {
            // ничего не делаем
        }

        public void AddNew(StudentViewModel model)
        {
            model.Id = _students.Max(e => e.Id) + 1;
            _students.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee is null)
                return;

            _students.Remove(employee);
        }
    }
}
