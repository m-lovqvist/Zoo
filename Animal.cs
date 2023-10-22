using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        protected string _name { get; set; }
        protected string _species { get; set; }
        protected int _age { get; set; }
        protected string _gender { get; set; }
        protected string _color { get; set; }

        public Animal(string name = "djur", string species = "art", int age = 3, string gender = "kön", string color = "färg") 
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
        }

        /// <summary>
        /// Skriver ut översiktsinformation om djuret
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{_name} är en {_species}. {_name} är {_age} år, {_gender} och färgen är {_color}.");
        }

        /// <summary>
        /// Berättar vad djuret äter
        /// </summary>
        public virtual void EatFood()
        {
            Console.WriteLine("Djuret äter");
        }

        /// <summary>
        /// Talar om djurets sovvanor
        /// </summary>
        public virtual void NapTime()
        {
            Console.WriteLine("Djuret sover");
        }

        /// <summary>
        /// Berättar hur djuret låter
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret låter");
        }
    }
}
