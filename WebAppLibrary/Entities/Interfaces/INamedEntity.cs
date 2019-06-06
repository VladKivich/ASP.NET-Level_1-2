using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLibrary.Interfaces
{
    interface INamedEntity:IBaseEntity
    {
        string Name { get; set; }
    }
}
