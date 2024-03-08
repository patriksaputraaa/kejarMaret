using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    class Player:Hero
    {
        private String waepon{get; set;}

        public Player(String name, int health, int attack, String waepon)
            : base(name, health, attack)
        {
            this.waepon = waepon;
        }

    }
}
