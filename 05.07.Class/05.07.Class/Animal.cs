using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
    abstract class Animal
    {
        public string _name;

        public  Animal(string _name)
        {
            this._name = _name;
        }

        public abstract void MakeSound();
        

        public override string ToString()
        {
            return $"[_name]:{_name}";
        }
    }
}
