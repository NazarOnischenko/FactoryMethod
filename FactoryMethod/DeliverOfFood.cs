using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class DeliverOfFood:Deliver
    {
        public DeliverOfFood(string name) : base(name) { }
        public override Product ToDeliver()
        {
            return new Food(); 
        }
    }
}
