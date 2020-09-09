using Anisimov.Domain.Entities.Base;
using Anisimov.Domain.Entities.Base.Interfaces;

namespace Anisimov.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
