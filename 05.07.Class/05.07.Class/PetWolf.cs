using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
     class PetWolf:Wolf
    {
        public PetWolf(string _name, string _favoriteFood, string _nameOfPack) :base(_name, _favoriteFood, _nameOfPack)
        {

        }

        public override void Bark()
        {
            Console.WriteLine("Ffff, Ffff...");
        }
    }
}
