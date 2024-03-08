using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    class Tank:Hero
    {
        private String shield { get; set; }

        public Tank(String name, int health, int attack, String shield)
            : base(name, health, attack)
        {
            this.shield = shield;
        }
    }
}
