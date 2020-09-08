using Anisimov.Domain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anisimov.Domain.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
