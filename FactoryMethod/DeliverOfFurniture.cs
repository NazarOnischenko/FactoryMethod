using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DeliverOfFurniture:Deliver
    {
        public DeliverOfFurniture(string name) : base(name) { }
        public override Product ToDeliver() { return new Furniture(); }

    }
}
