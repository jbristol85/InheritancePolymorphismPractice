﻿using System;
using System.Linq;

namespace InheritancePolymorphismPractice
{
    public class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();
        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public Animal()
            : this("No Name", "No Sound") {}

        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }

                name = value;
            }
        }
        public string Sound
        {
            get
            {
                return sound;
            }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }

                sound = value;
            }
        }
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
