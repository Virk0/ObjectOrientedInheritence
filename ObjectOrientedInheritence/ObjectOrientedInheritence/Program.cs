using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängija loomine
            var hp = 100;

            //loome vaenlase
            var enemyWolf = new Wolf();
            hp = enemyWolf.Attack(hp);
            //hp = enemyWolf.SpecialAttack(hp);
            var enemyFireWolf = new FireWolf();
            hp = enemyFireWolf.Attack(hp);

            var enemyBadMoneky = new BadMonkey();
            hp = enemyBadMoneky.Attack(hp);

            //var creature = new Creature();
            //creature.Name = "Creature";
            //creature.Hitpoints = 100;
            //creature.Damage = 20;
            //creature.Attack(hp);
            Console.ReadLine();
        }
    }
}
