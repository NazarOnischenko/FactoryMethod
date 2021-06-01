using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Deliver
    {
        public string Name { get; set; }
        public Deliver(string name)
        {
            Name = name;
        }
        abstract public Product ToDeliver(); 
    }
}
