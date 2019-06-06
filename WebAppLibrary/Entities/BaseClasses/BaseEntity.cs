using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppLibrary.Interfaces;

namespace WebAppLibrary.BaseClasses
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
