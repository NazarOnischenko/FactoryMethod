using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Appliances:Product
    {
        public Appliances()
        {
            Console.WriteLine("Доставка побутової техніки");
        }
    }
}
