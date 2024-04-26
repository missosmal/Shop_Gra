using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Graf37.Data.Models;

namespace Shop_Graf37.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }

    }
}
