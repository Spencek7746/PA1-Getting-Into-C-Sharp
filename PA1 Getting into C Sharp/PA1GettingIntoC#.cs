//Name: Spencer Karpati
//Filename: PA1GettingIntoC#
//Date: 1/19/2023
//Description: This program helps with learning C# and the concept of abstract and concrete classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PA1_Getting_into_C_Sharp
{
    internal class Program
    {

        abstract public class Animal
        {
            private String Name;
            private int Age;
            private String Noise;
            private int Weight;

            public String name
            {
                get { return Name; }
                set { Name = value; }
            }
            public int age
            {
                get { return Age; }
                set { Age = value; }
            }
            public String noise
            {
                get { return Noise; }
                set { Noise = value; }
            }
            public int weight
            {
                get { return Weight; }
                set { Weight = value; }
            }


            public virtual void printInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.Write("Age: " + Age);
                Console.WriteLine(" years");
                Console.Write("Weight: " + Weight);
                Console.WriteLine(" pounds");
            }
            public virtual void makeNoise()
            {
                Console.WriteLine(Noise);
            }
            public virtual int ageUp()
            {
                Age = Age + 3;
                Console.WriteLine("Age:");
                return Age;
            }
        }

        public class Cat : Animal
        {
            public override void printInfo()
            {
                name = "Aya";
                age = 4;
                weight = 9;
            }

            public override void makeNoise()
            {
                noise = "meow";
            }

            public override int ageUp()
            {
                throw new NotImplementedException();
            }
        }

            public class Cassowary : Animal
            {
                public override void printInfo()
                {
                   name = "Devil Bird";
                   age = 24;
                   weight = 97;
                }

                public override void makeNoise()
                {
                   noise = "*Horrifying Growling/Rumbling Sounds*";
                }

                public override int ageUp()
                {
                    throw new NotImplementedException();
                }
            }

                public class Austin_Powers : Animal
                {
                    public override void printInfo()
                    {
                        name = "Austin Powers";
                        age = 42;
                        weight = 156;
                    }

                    public override void makeNoise()
                    {
                        noise = "YEAHHH BAYBEE YEAHHH";
                    }

                    public override int ageUp()
                    {
                        throw new NotImplementedException();
                    }
                }

                    static void Main(string[] args)
        {
        }
    }
}
