using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_poo.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + " " + this.MP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a mão";
        }
    }
}
