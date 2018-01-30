using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedInheritence
{
    class Wolf : Creature
    {
       
        public Wolf()
        {
            Name = "Wolf";
            Hitpoints = 50;
            Damage = 15;
            Defence = 10;
            Ranged = false;
        }

        public override int Attack(int hp)
        {
            Console.WriteLine(Name + " has bit you");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - 15;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }

        public override int SpecialAttack(int hp)
        {
            int SpecialDmg = Damage + 10;
            Console.WriteLine(Name + " has hit you with his claw");
            Console.WriteLine(Name + " did " + SpecialDmg + " Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }
    }
}
