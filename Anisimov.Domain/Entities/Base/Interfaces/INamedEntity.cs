namespace Anisimov.Domain.Entities.Base.Interfaces
{
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
