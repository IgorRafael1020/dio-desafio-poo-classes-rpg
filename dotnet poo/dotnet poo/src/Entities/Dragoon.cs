using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_poo.src.Entities
{
    class Dragoon : Hero
    {
        public Dragoon(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Atacou com uma lança";
        }
    }
}
