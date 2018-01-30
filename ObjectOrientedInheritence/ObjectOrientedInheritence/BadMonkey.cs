using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedInheritence
{
    class BadMonkey : Creature
    {


        public BadMonkey()
        {
            Name = "BadMonkey";
            Hitpoints = 50;
            Damage = 15;
            Defence = 10;
            Ranged = true;
        }

        //public int Attack(int hp)
        //{
        //    Console.WriteLine(Name + " is throwing a banana at you");
        //    Console.WriteLine(Name + " did " + Damage + " Damage");
        //    var userHitpoints = hp - 15;
        //    Console.WriteLine("User has " + userHitpoints + " hitpoints");
        //    return userHitpoints;
        //}

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " has hit you with a big banana");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + userHitpoints + " hitpoints");
            return userHitpoints;
        }
    }
}
