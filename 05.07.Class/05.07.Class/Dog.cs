using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._07.Class
{
    class Dog:Animal
    {
        public string _favoriteDogFood;

        public Dog(string _name, string _favoriteFood):base(_name)
        {
            //this._name = _name;
            this._favoriteDogFood = _favoriteFood;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Dogs bark");
        }

        public override void MakeSound()
        {
            Bark(); 
        }

        public override string ToString()
        {
            return $"[name]:{_name} [Favorite Dog Food]:{_favoriteDogFood}";
        }
    }
}
