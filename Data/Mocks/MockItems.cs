using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Graf37.Data.Interfaces;
using Shop_Graf37.Data.Models;

namespace Shop_Graf37.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _category = new MockCategorys();
        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items()
                    {
                        Id = 0,
                        Name = "DEXP MS-70",
                        Description = "Adawdwadawdawd",
                        Img = "https://",
                        Price = 3599,
                        Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    },
                    new Items()
                    {

                    },
                    new Items()
                    {

                    },
                    new Items()
                    {

                    },
                    new Items()
                    {

                    }
                };
            }
        }
    }
}
