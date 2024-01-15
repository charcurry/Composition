using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composition");
            Console.WriteLine();

            Player player = new Player(100);
            Enemy enemy = new Enemy(50);

            Console.WriteLine("Player Health: " + player.healthSystem.health);
            Console.WriteLine("Enemy Health: " + enemy.healthSystem.health);

            player.healthSystem.TakeDamage(10);
            enemy.healthSystem.TakeDamage(10);

            Console.WriteLine("Player Health: " + player.healthSystem.health);
            Console.WriteLine("Enemy Health: " + enemy.healthSystem.health);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
