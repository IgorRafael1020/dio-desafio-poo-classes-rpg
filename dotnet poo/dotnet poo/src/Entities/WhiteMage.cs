using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_poo.src.Entities
{
    class WhiteMage : Hero
    {
        public WhiteMage(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Atacou com um cajado";
        }
    }
}
