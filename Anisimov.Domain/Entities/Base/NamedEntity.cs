using Anisimov.Domain.Entities.Base.Interfaces;

namespace Anisimov.Domain.Entities.Base
{
    public class NamedEntity : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
