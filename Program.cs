using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    class Program
    {
        static void Main(string[] args)
        {
            //input character
            String name, waepon;
            Console.WriteLine("Create your character!");
            Console.Write("Name\t: ");
            name = Console.ReadLine();
            Console.Write("Waepon\t: ");
            waepon = Console.ReadLine();

            //instansiasi character
            Player player = new Player(name, 100, 50, waepon);
            player.showPlayer();

            //instansiasi musuh
            Console.WriteLine("Musuh anda adalah : ");
            Tank musuh = new Tank("Tigreal", 200, 15, "Tameng Air");
            musuh.showPlayer();

            bool ulang = true;
            int pilih;
            do
            {
                Utility.showMenu();
                Console.WriteLine("Pilihan : ");
                pilih = Convert.ToInt16(Console.ReadLine());

                switch (pilih)
                {
                    case 1: Utility.clearScreen();
                        player.isAttacking(musuh);
                        break;
                    case 2: player.isHealing();
                        break;
                    case 3: ulang = false;
                        break;
                }

                if (musuh.health <= 0)
                {
                    Console.WriteLine("CONGRATS YOU WIN!");
                    ulang = false;
                }

            } while (ulang);


            




            
            //Marksman player2 = new Marksman("Miya", 100, 30, "Panah Api");
            //player2.showPlayer();

            //player2.isAttacking(player1);


            //menunggu input key dari user
            Console.ReadKey();
        }


    }
}
