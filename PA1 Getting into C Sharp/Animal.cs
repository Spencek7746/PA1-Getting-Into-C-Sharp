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

namespace PA1_Getting_into_C_Sharp
{
        abstract public class Animal
        {
            private String Name; Noise;
            private int Age; Weight;

            public abstract void printInfo();
            public virtual void makeNoise();
            public virtual int ageUp();
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
    }

