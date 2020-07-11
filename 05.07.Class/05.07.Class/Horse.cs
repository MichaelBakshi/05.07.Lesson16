using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
    class Horse:Animal
    {
        public string _name;
        public bool _racingHorse;

        public  Horse(string _name, bool _racingHorse):base(_name)
        {
            this._name = _name;
            this._racingHorse = _racingHorse;
        }

        public override void MakeSound()
        {
           Neigh();
        }
        public virtual void Neigh ()
        {
            Console.WriteLine("Horse says neigh...");
        }

        public override string ToString()
        {
            return $"[name]:{_name} [Racing Horse]:{_racingHorse} ";
        }

        
    }
}
