//Name: Spencer Karpati
//Instructor: Dr. Kathleen Ericson
//Class: CSCI 352
//Description: This program helps with learning C# and the concept of abstract and concrete classes.

using System;
using System.Collections.Generic;
using System.Linq;
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

            public abstract void printInfo();
            public abstract void makeNoise();
            public abstract int ageUp();
        }

        public class Cat : Animal
        {
            public override void printInfo()
            {
                throw new NotImplementedException();
            }

            public override void makeNoise()
            {
                throw new NotImplementedException();
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
                    throw new NotImplementedException();
                }

                public override void makeNoise()
                {
                    throw new NotImplementedException();
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
                        throw new NotImplementedException();
                    }

                    public override void makeNoise()
                    {
                        throw new NotImplementedException();
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
