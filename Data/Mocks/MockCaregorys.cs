using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Graf37.Data.Interfaces;
using Shop_Graf37.Data.Models;

namespace Shop_Graf37.Data.Mocks
{
    public class MockCaregorys : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                return new List<Categorys>
                {
                    new Categorys()
                    {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "ФЦВфцвфцвцфвцфвцф"
                    },
                };
            }
        }
    }
}
