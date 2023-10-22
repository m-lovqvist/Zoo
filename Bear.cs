using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Bear : Animal
    {
        protected string _shy { get; set; }
        public Bear(string name = "Nalle", string species = "björn", int age = 1, string gender = "hane", string color = "brun", string shy = "skygg")
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
            _shy = shy;

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} är en {_species}. {_name} är {_age} år, {_gender} och färgen är {_color}. {_name} är {_shy}.");
        }
        public override void MakeSound() 
        {
            Console.WriteLine(_name + " visslar ofta och mycket. ");
        }
        public override void EatFood()
        {
            Console.Write(_name + " äter bär, myror och klövvilt. ");
        }
        public override void NapTime()
        {
            Console.Write(_name + " går i ide under vinterhalvåret. ");
        }

        /// <summary>
        /// Talar om när och om björnen fäller pälsen
        /// </summary>
        public virtual void ShedFur()
        {
            Console.WriteLine(_name + " fäller vinterpälsen under senvåren. ");
        }

    }
}
