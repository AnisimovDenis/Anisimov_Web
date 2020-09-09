using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Anisimov.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя явялдется обязательным для заполнения")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength:200, MinimumLength = 2, ErrorMessage = "Имя должно быть не менее 2-ух символов и не более 200 символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия явялдется обязательным для заполнения")]
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст явялдется обязательным для заполнения")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Должность явялдется обязательным для заполнения")]
        [Display(Name = "Должность")]
        public string Position { get; set; }
    }
}
