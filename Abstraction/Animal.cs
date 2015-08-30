using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        private string _name;

        public Animal(string n)
        {

            _name = n;
        }
        public string Name
        {
            get {return _name;}
            set {_name = value;}

        }
        public abstract string Speak();
       
    }
}
