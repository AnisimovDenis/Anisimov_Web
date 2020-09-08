using Anisimov.Domain.Entities.Base;
using Anisimov.Domain.Entities.Base.Interfaces;

namespace Anisimov.Domain.Entities
{
    public class Category : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }

        public int Order { get; set; }
    }
}
