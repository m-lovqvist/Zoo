using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Grizzly : Bear
    {
        private string _shoulderbuckle;
        public Grizzly(string name = "Teddy", string species = "grizzlybjörn", int age = 1, string gender = "hane", string color = "gråskimrande brun", string shy = "skygg", string shoulderbuckle = "axelbuckla") : base(name, species, age, gender, color, shy)
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
            _shy = shy;
            _shoulderbuckle = shoulderbuckle;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} är en {_species}. {_name} är {_age} år, {_gender} och {_color}. {_name} är {_shy} och har en stor {_shoulderbuckle}.");
        }
        public override void MakeSound()
        {
            Console.WriteLine(_name + " vrålar när " + _name + " blir arg! ");
        }
        public override void EatFood()
        {
            Console.Write(_name + " äter bär, gnagare, hjortdjur och lax. ");
        }
        public override void NapTime()
        {
            Console.WriteLine(_name + " går i dvala under vinterhalvåret. ");
        }
        public override void ShedFur()
        {
            Console.WriteLine(_name + " fäller vanligtvis vinterpälsen under våren eller sommaren. ");
        }

        /// <summary>
        /// Berättar hur björnen fiskar
        /// </summary>
        public void GoFish()
        {
            Console.Write(_name + " samlas med uppemot 19 andra grizzlybjörnar för att fånga lax. ");
        }
    }
}
