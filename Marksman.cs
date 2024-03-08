using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    class Marksman:Hero
    {
        private String bow;

        public Marksman(String name, int health, int attack, String bow)
            : base(name, health, attack)
        {
            this.bow = bow;
        }
    }
}
