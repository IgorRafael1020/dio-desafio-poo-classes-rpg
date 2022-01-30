using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_poo.src.Entities
{
    public class Summoner : Hero
    {
        public Summoner(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Atacou com um chicote";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
                return this.Name + " Invocou um super monstro";
            else
                return this.Name + " Invocou um monstro";
        }
    }
}
