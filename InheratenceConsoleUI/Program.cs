using System;
using System.Collections.Generic;

namespace InheratenceConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            // access to Legs and Age
            Dog myDog1 = new Dog();
            // access to Legs, Age, OwnerName, FavorateToy
            Labador myDog2 = new Labador();
            // access to Legs, Age, OwnerName, FavorateToy
            Animal myDog3 = new Labador();
            // access to Legs and Age
            Dog myDog4 = new Labador();
            // access to Legs, Age, OwnerName, FavorateToy

            Dog dog = new Dog();
            Cat cat = new Cat();
            List<Dog> animals = new List<Dog>();
            animals.Add(dog);
            //Addd cat? Cannot like this sooo...

            //since both can and dog are Animlas, we can put them here.
            List<Animal> animals2 = new List<Animal>();
            animals2.Add(dog);
            animals2.Add(cat);
        }
    }
}
