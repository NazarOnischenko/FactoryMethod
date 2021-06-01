using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DeliverOfAppliances:Deliver
    {
        public DeliverOfAppliances(string name) : base(name) { }
        public override Product ToDeliver()
        {
            return new Appliances();
        }
    }
}
