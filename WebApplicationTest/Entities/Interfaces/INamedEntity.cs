using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Entities.Interfaces
{
    interface INamedEntity:IBaseEntity
    {
        string Name { get; set; }
    }
}
