using Anisimov.Domain.Entities.Base.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Anisimov.ViewModels
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
