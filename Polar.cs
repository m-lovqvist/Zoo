using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Polar : Bear
    {
        private string _habitat;
        public Polar(string name = "Brumma", string species = "isbjörn", int age = 10, string gender = "hona", string color = "vit", string shy = "skygg", string habitat = "lever på isflak") : base(name, species, age, gender, color, shy)
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
            _shy = shy;
            _habitat = habitat;  
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} är en {_species}. {_name} är {_age} år, {_gender} och {_color}. {_name} är {_shy} och bor på isflak.");
        }
        public override void MakeSound()
        {
            Console.WriteLine(_name + " fnyser vid irritation. ");
        }
        public override void EatFood()
        {
            Console.Write(_name + " äter sälar och fisk. ");
        }
        public override void NapTime()
        {
            Console.WriteLine(_name + " vilar upp till 20 timmar om dagen. ");
        }
        public override void ShedFur()
        {
            Console.Write(_name + " fäller inte pälsen under sommaren. ");
        }

        /// <summary>
        /// Berättar hur björnen simmar
        /// </summary>
        public void GoSwim()
        {
            Console.Write(_name + " simmar snabbt.");
        }
    }
}
