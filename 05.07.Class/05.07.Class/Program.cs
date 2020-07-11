using _05._07.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.ToString());
            Horse horse = new Horse("Arthur", true);
            Horse horse2 = new Horse("Igal", false);
            Dog dog = new Dog("Bobik", "Bones");
            Wolf wolf = new Wolf("Beast", "Rabbits", "Northern Pack");
            Poodle poodle = new Poodle("Toy", "Sausages", "Two");
            PetWolf petWolf = new PetWolf("Baby wolf", "Milk", "Eastern pack");

            Animal[] abc = new Animal[] { horse, dog, wolf, poodle, petWolf };
            AnimalSing(abc);
            Console.WriteLine();
            Horse[] horses = new Horse[] {horse, horse2 };
            Horse[] racingHorses = GetRacingHorses(horses);

            for (int i = 0; i < racingHorses.Length; i++)
            {
                Console.WriteLine(racingHorses[i]._name);
            }

            Console.WriteLine();
            Console.WriteLine(horse.ToString());
            Console.WriteLine(dog.ToString());
            Console.WriteLine(wolf.ToString());
            Console.WriteLine(poodle.ToString());
            Console.WriteLine(petWolf.ToString());
            Console.ReadKey();
        }

        static void AnimalSing(Animal[] xyz)
        {

            for (int i = 0; i < xyz.Length; i++)
            {
                Animal animal = xyz[i];
                animal.MakeSound();
            }
        }

        static Horse[] GetRacingHorses(Horse[] horses)
        {
            Horse[] result = new Horse[horses.Length];
            int resultIndex = 0;

            for (int i = 0; i < horses.Length; i++)
            {
                Horse horse = horses[i];
 
                if (horse._racingHorse == true)
                {
                    result[resultIndex] = horse;
                    resultIndex++;
                }
            }

            return result;
        }
        

    }
}