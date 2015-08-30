using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cat:Animal
    {
         public Cat(string name) : base(name) { }

        public override string Speak()
        {
            return "Meow";
        }
    }
}
