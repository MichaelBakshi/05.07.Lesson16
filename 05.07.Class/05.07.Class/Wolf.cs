using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
    class Wolf:Dog
    {
        public string _nameOfPack;

        public Wolf(string _name, string _favoriteFood, string _nameOfPack):base(_name, _favoriteFood)
        {
            this._nameOfPack = _nameOfPack;
        }

        public override void Bark()
        {
            Console.WriteLine("Uuuuuuuuuu!!!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} [Favorite Food]:{_favoriteDogFood} [Name of pack]:{_nameOfPack}";
        }

    }
}
