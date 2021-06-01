using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DeliverOfClothing:Deliver
    {
        public DeliverOfClothing(string name):base(name)
        {
        }
        public override Product ToDeliver() { return new Clothing(); }
    }
}
