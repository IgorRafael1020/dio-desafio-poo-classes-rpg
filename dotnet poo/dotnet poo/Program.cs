using dotnet_poo.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Paladin Cecil = new Paladin("Cecil", 46, "Paladin");
            Summoner Rydia = new Summoner("Rydia", 46, "Summoner");
            WhiteMage Rosa = new WhiteMage("Rosa", 46, "White Mage");
            Dragoon Kain = new Dragoon("Kain", 46, "Dragoon");
            Ninja Edge = new Ninja("Edge", 46, "Ninja");

            Cecil.HP = 2100;
            Cecil.MP = 160;

            Rydia.HP = 1100;
            Rydia.MP = 330;

            Rosa.HP = 1500;
            Rosa.MP = 350;

            Kain.HP = 1880;
            Kain.MP = 0;

            Edge.HP = 1700;
            Edge.MP = 120;

            Console.WriteLine(Cecil);
            Console.WriteLine(Cecil.Attack() + "\n");

            Console.WriteLine(Rydia);
            Console.WriteLine(Rydia.Attack());
            Console.WriteLine(Rydia.Attack(2));
            Console.WriteLine(Rydia.Attack(8) + "\n");

            Console.WriteLine(Rosa);
            Console.WriteLine(Rosa.Attack() + "\n");

            Console.WriteLine(Kain);
            Console.WriteLine(Kain.Attack() + "\n");

            Console.WriteLine(Edge);
            Console.WriteLine(Edge.Attack() + "\n");

            Console.ReadKey();
        }
    }
}
