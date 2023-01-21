//Name: Spencer Karpati
//Filename: Animal.cs
//Date: 1/19/2023
//Description: This is the abstract Animal Superclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    abstract public class Animal
    {
        private string Name = "Animal";
        private string Noise = "Default";
        private int Age = 0;
        private int Weight = 0;

        public virtual void printInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.Write("Age: " + Age);
            Console.WriteLine(" years.");
            Console.Write("Weight: " + Weight);
            Console.WriteLine(" pounds.");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine(Noise);
        }

        public virtual void ageUp()
        {
            Console.WriteLine(Age + 5);
        }
    }
}

