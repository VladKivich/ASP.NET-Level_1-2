using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLibrary.Interfaces
{
    interface IOrderedEntity
    {
        int Order { get; set; }
    }
}
