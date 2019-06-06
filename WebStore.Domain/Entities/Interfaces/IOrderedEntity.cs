using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Domain.Entities.Interfaces
{
    interface IOrderedEntity
    {
        int Order { get; set; }
    }
}
