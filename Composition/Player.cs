using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Player
    {

        public HealthSystem healthSystem;

        public Player(int health) 
        {
            healthSystem = new HealthSystem(health);
        }
    }
}
