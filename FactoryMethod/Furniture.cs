using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Furniture:Product
    {
        public Furniture()
        {
            Console.WriteLine("Доставка меблів");
        }
    }
}
