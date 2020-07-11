using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
    class Poodle:Dog
    {
        public string _numberOfPonyTails;

        public Poodle(string _name, string _favoriteFood, string _numberOfPonyTails ):base(_name,_favoriteFood)
        {
            this._numberOfPonyTails = _numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("Poodles tiaf-tiaf!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} [Number of pony tails]:{_numberOfPonyTails}";
        }
    }
}
