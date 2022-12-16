using System;

namespace TebakKata
{
    class program
    {
        static string katarahasia = "spongebob";
        static int kesempatan = 5;
        static List<string> tebakanpemain = new List<string> { };
        static void Main(string[] args)
        {
            intro();
            Mulaimain();
        }

        static void intro()
        {
            System.Console.WriteLine("Selamat datang dalam permainan tebakkata");
            System.Console.WriteLine($"Kamu memiliki kesempatan sebanyak {kesempatan} untuk menebak kata");
            System.Console.WriteLine("Petunjuknya adalah film animasi terkenal");
            System.Console.WriteLine($"Kata terdiri dari {katarahasia.Length} karakter");
            System.Console.WriteLine("Film animasi apakah yang dimaksud?");
        }
        static void Mulaimain()
        {
            while (kesempatan > 0)
            {
                Console.Write("Apa karakter tebakan? (a-z) : ");
                string input = Console.ReadLine();
                tebakanpemain.Add(input);

                if (cekjawaban(katarahasia, tebakanpemain))
                {
                    System.Console.WriteLine("Selamat kamu berhasil");
                    System.Console.WriteLine($"Kata misteri hari ini adalah {katarahasia}");
                    System.Console.WriteLine("Terimakasih telah bermain");
                    break;
                }
                else if (katarahasia.Contains(input))
                {
                    System.Console.WriteLine("Kata tebakanmu ada di dalamnya");
                    System.Console.WriteLine("Silahkan masukkan huruf lain");
                    System.Console.WriteLine(cekhuruf(katarahasia, tebakanpemain));
                }
                else
                {
                    System.Console.WriteLine("Tebakan kamu salah");
                    kesempatan--;
                    System.Console.WriteLine($"Sisa kesemapatan anda adalah : {kesempatan}");
                    System.Console.WriteLine("Silahkan coba lagi");
                }

                if (kesempatan == 0)
                {
                    System.Console.WriteLine("Sayang sekali kesempatan kamu sudah habis");
                    System.Console.WriteLine($"Jawabannya adalah : {katarahasia}");
                    System.Console.WriteLine("Terimakasih telah bermain");
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia, List<string> list)
        {
            bool status = false;
            for (int i = 0; i < katarahasia.Length; i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if (list.Contains(c))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

            }
            return status;
        }
        static string cekhuruf(string katarahasia, List<string> list)
        {
            string a = "";
            for (int i = 0; i < katarahasia.Length; i++)
            {
                string b = Convert.ToString(katarahasia[i]);
                if (list.Contains(b))
                {
                    a = a + b;

                }
                else
                {
                    a = a + "_";

                }

            }
            return a;
        }

    }
}
