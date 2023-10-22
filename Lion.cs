using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Lion : Animal
    {
        private int _speed;
        public Lion(string name = "Scar", string species = "lejon", int age = 8, string gender = "hane", string color = "brun med svarta detaljer", int speed = 60 )
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
            _speed = speed;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} är ett {_species}. {_name} är {_age} år, {_gender} och {_color}. {_name} springer {_speed} km/h.");
        }
        public override void MakeSound()
        {
            Console.WriteLine(_name + " ryter för att få uppmärksamhet! ");
        }
        public override void EatFood()
        {
            Console.Write(_name + " äter mellan 5 och 7 kilo kött per dag. ");
        }
        public override void NapTime()
        {
            Console.WriteLine(_name + " vilar upp till 20 timmar om dagen. ");
        }

        /// <summary>
        /// Berättar hur lejonet jagar
        /// </summary>
        public void GoHunting()
        {
            Console.Write(_name + " smyger sig på sitt byte. ");
        }
    }
}
