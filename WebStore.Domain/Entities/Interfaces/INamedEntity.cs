using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Domain.Entities.Interfaces
{
    public interface INamedEntity:IBaseEntity
    {
        string Name { get; set; }
    }
}
