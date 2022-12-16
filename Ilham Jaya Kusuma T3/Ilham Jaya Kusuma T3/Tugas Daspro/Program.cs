/*

Tugas Daspro Adu Dadu
Nama : Ilham Jaya Kusuma
Nim : 2207112593

*/

using System;

namespace TugasDaspro
{
    class Program
    {
        static int LimitRonde = 10;
        static int NoRonde = 1;
        static int PlayerWin = 0;
        static int BotWin = 0;

        static void Main(string[] args)
        {
            Intro();
            Console.ReadKey();

            while (LimitRonde > 0)
            {
                GamePlay();
            }

            EndGame();
            Outro();


        }
        static void Intro()
        {
            Console.Clear();
            System.Console.WriteLine("Nama : Ilham Jaya Kusuma\nNim : 2207112593\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("GAME ADU DADU!\n");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Peraturan dari game ini sederhana\nDadu akan dilempar secara bergilir");
            System.Console.WriteLine("Dadu pertama adalah dadu bot\nDadu kedua adalah dadu player");
            System.Console.WriteLine("Dadu dengan nilai terbesar akan mendapat poin\nPoin terbanyak akan menang");
            System.Console.WriteLine("Selamat mencoba...\nGood Luck :)\n");

        }
        static void GamePlay()
        {
            Console.Clear();
            Random rng = new Random();
            int player = rng.Next(1, 7);
            int bot = rng.Next(1, 7);

            System.Console.WriteLine("Ronde : " + NoRonde + " !\n");
            System.Console.WriteLine("Bot mendapat dadu " + bot);
            System.Console.WriteLine("Tekan enter untuk melempar dadu...");
            System.Console.ReadKey();
            System.Console.WriteLine("Player mendapat dadu " + player + "\n");

            if (bot > player)
            {
                System.Console.WriteLine("Bot mendapat 1 poin!");
                BotWin++;
            }
            else if (player > bot)
            {
                System.Console.WriteLine("Player mendapat 1 poin!");
                PlayerWin++;
            }
            else
            {
                System.Console.WriteLine("Seri!");
                NoRonde--;
                LimitRonde++;
            }
            System.Console.WriteLine("Poin bot : " + BotWin + "\nPoin player : " + PlayerWin + "\n");
            NoRonde++;
            LimitRonde--;
            System.Console.ReadKey();

        }
        static void EndGame()
        {
            if (BotWin > PlayerWin)
            {
                System.Console.WriteLine("Sayang sekali... Kamu kalah...");
            }
            else if (PlayerWin > BotWin)
            {
                System.Console.WriteLine("Selamat! Kamu menang!");
            }
            else
            {
                System.Console.WriteLine("Hasilnya seri...");
            }

        }
        static void Outro()
        {
            System.Console.WriteLine("apakah kamu ingin bermain lagi? (y/n)");
            String answer = Console.ReadLine();

            if (answer == "y")
            {
                LimitRonde = 10;
                NoRonde = 1;
                BotWin = 0;
                PlayerWin = 0;

                while (LimitRonde > 0)
                {
                    GamePlay();
                }

                EndGame();
                Outro();
            }
            else if (answer == "n")
            {
                System.Console.WriteLine("\nTerimkasih telah bermain :)");

            }
            else if (answer != "y" && answer != "n")
            {
                Outro();
            }


        }
    }

}

