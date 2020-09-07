using Anisimov.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anisimov.Infrastructure.Interfaces
{
    public interface IService<T>
    {
        /// <summary>
        /// Получение списка
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Получение по id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void Commit();

        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="model"></param>
        void AddNew(T model);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
