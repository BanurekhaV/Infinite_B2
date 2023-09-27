using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
       
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalfactory = null;
            string sound = null;

            //create respective factory class objects
            animalfactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory Chosen ? :" + " "+ animalfactory.GetType().Name);
            Console.WriteLine();

            //get an animal object
            animal = animalfactory.GetAnimal("Shark");
            Console.WriteLine("Animal Chosen by you ? :" + animal.GetType().Name);
            sound = animal.speak();
            Console.WriteLine($" The Factory is :{animalfactory}, the Animal is :{animal} and the sound of the Animal is : {sound}");
            Console.WriteLine("----------------------------");

            //create respective factory class objects
            animalfactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory Chosen ? :" + " " + animalfactory.GetType().Name);
            Console.WriteLine();

            //get an animal object
            animal = animalfactory.GetAnimal("Dog");
            Console.WriteLine("Animal Chosen by you ? :" + animal.GetType().Name);
            sound = animal.speak();
            Console.WriteLine($" The Factory is :{animalfactory}, the Animal is :{animal} and the sound of the Animal is : {sound}");
            Console.Read();
        }
    }
}
