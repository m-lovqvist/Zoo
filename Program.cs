using System.Drawing;
using System.Xml.Linq;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till vårt Zoo! Här bor flera olika djur. Nedan följer information så du kan lära känna dem lite bättre:");
            Console.WriteLine();

            Bear bear = new Bear("Koda", "brunbjörn", 2, "hane", "brun", "skygg");
            bear.PrintInfo(); bear.EatFood(); bear.NapTime(); bear.ShedFur(); bear.MakeSound(); Console.WriteLine();
            
            Grizzly grizzly = new Grizzly("Bamse", "grizzlybjörn", 5, "hane", "gråskimrande brun", "skygg");
            grizzly.PrintInfo(); grizzly.EatFood(); grizzly.NapTime(); grizzly.ShedFur(); grizzly.GoFish(); grizzly.MakeSound(); Console.WriteLine();
            
            Polar polar = new Polar("Nallemaja", "isbjörn", 3, "hona", "vit", "skygg");
            polar.PrintInfo(); polar.EatFood(); polar.NapTime(); polar.ShedFur(); polar.GoSwim(); polar.MakeSound(); Console.WriteLine();
            
            Lion lion = new Lion("Simba", "lejon", 1, "hane", "gyllenbrun", 30);
            lion.PrintInfo(); lion.EatFood(); lion.NapTime(); lion.GoHunting(); lion.MakeSound(); Console.WriteLine();
            
            Lynx lynx = new Lynx("Lotus", "lodjur", 4, "hane", "gyllenbrun med mörka fläckar", "20 kg");
            lynx.PrintInfo(); lynx.EatFood(); lynx.NapTime(); lynx.HuntingTime(); lynx.MakeSound(); Console.WriteLine();

            Bear bear2 = new Bear();
            bear2.PrintInfo(); bear2.EatFood(); bear2.NapTime(); bear2.ShedFur(); bear2.MakeSound(); Console.WriteLine();
            
            Grizzly grizzly2 = new Grizzly();
            grizzly2.PrintInfo(); grizzly2.EatFood(); grizzly2.NapTime(); grizzly2.ShedFur(); grizzly2.GoFish(); grizzly2.MakeSound(); Console.WriteLine();
            
            Polar polar2 = new Polar();
            polar2.PrintInfo(); polar2.EatFood(); polar2.NapTime(); polar2.ShedFur(); polar2.GoSwim(); polar2.MakeSound(); Console.WriteLine();
            
            Lion lion2 = new Lion();
            lion2.PrintInfo(); lion2.EatFood(); lion2.NapTime(); lion2.GoHunting(); lion2.MakeSound(); Console.WriteLine();
            
            Lynx lynx2 = new Lynx();
            lynx2.PrintInfo(); lynx2.EatFood(); lynx2.NapTime(); lynx2.HuntingTime(); lynx2.MakeSound(); Console.WriteLine();
        }
    }
}