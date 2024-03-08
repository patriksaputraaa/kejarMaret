using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    public abstract class Hero
    {
        public String name { set; get; }
        public int health { set; get; }
        public int attack { set; get; }

        //buat konstruktor
        public Hero(String name, int health, int attack)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }

        public void showPlayer()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Name\t: " + this.name);
            Console.WriteLine("Health\t: " + this.health);
            Console.WriteLine("Attack\t: " + this.attack);
            Console.WriteLine("======================");
        }

        public void isAttacking(Hero enemy)
        {
            Console.WriteLine("ATTACK!");
            Console.WriteLine(this.name + " is attacking " + enemy.name);
            Console.WriteLine("With " + this.attack + " damage!!!");
            enemy.health -= this.attack;
            enemy.showPlayer();
        }

        public void isHealing()
        {
            int HEAL_AMOUNT = 30;
            Console.WriteLine("HEALING!");
            Console.WriteLine(this.name + " is healing with " + HEAL_AMOUNT);
            this.health += HEAL_AMOUNT;
            this.showPlayer();
        }
    }
}
