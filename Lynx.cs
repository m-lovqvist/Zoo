using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Lynx : Animal
    {
        private string _size;
        public Lynx(string name = "Lilja", string species = "lodjur", int age = 3, string gender = "hona", string color = "rödbrun med mörka fläckar", string size = "15 kg")
        {
            _name = name;
            _species = species;
            _age = age;
            _gender = gender;
            _color = color;
            _size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} är ett {_species}. {_name} är {_age} år, {_gender}, {_color} och {_size} stor.");
        }
        public override void MakeSound()
        {
            Console.WriteLine(_name + " morrar och fräser som en katt. ");
        }
        public override void EatFood()
        {
            Console.Write(_name + " äter ren, rådjur och småvilt. ");
        }
        public override void NapTime()
        {
            Console.WriteLine(_name + " vilar i daglega på en sten eller klippavsats. ");
        }

        /// <summary>
        /// Berättar när lodjuret jagar
        /// </summary>
        public void HuntingTime()
        {
            Console.Write(_name + " jagar i skymning. ");
        }
    }
}
