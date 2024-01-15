using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Enemy
    {
        public HealthSystem healthSystem;

        public Enemy(int health)
        {
            healthSystem = new HealthSystem(health);
        }
    }
}
