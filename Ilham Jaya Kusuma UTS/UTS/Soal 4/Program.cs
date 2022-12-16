using System;

namespace SoalNo4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Batu, Gunting, Kertas");

            int menang = 0;
            int kalah = 0;
            int seri = 0;
            bool main = false;

            Random rng = new Random();
            string[] komputer = { "batu", "gunting", "kertas" };
            int index = rng.Next(komputer.Length);

            while (!main)
            {
                string jawaban_komputer = komputer[index];
                Console.Write("Choose [b]atu, [g]unting, [k]ertas or [e]xit: ");
                string jawaban = Console.ReadLine();

                if (jawaban == "b")
                {
                    Console.WriteLine("Komputer memilih " + jawaban_komputer);
                    if (jawaban_komputer == "batu")
                    {
                        Console.WriteLine("Seri");
                        seri++;
                    }
                    else if (jawaban_komputer == "gunting")
                    {
                        Console.WriteLine("Anda menang");
                        menang++;
                    }
                    else if (jawaban_komputer == "kertas")
                    {
                        Console.WriteLine("Anda kalah");
                        kalah++;
                    }

                }
                else if (jawaban == "g")
                {
                    Console.WriteLine("Komputer memilih " + jawaban_komputer);
                    if (jawaban_komputer == "batu")
                    {
                        Console.WriteLine("Anda kalah");
                        kalah++;
                    }
                    else if (jawaban_komputer == "gunting")
                    {
                        Console.WriteLine("Seri");
                        seri++;
                    }
                    else if (jawaban_komputer == "kertas")
                    {
                        Console.WriteLine("Anda menang");
                        menang++;
                    }
                }
                else if (jawaban == "k")
                {
                    Console.WriteLine("Komputer memilih " + jawaban_komputer);
                    if (jawaban_komputer == "batu")
                    {
                        Console.WriteLine("Anda menang");
                        menang++;
                    }
                    else if (jawaban_komputer == "gunting")
                    {
                        Console.WriteLine("Anda kalah");
                        kalah++;
                    }
                    else if (jawaban_komputer == "kertas")
                    {
                        Console.WriteLine("Seri");
                        seri++;
                    }
                }
                else if (jawaban == "e")
                {
                    break;

                }
                Console.WriteLine("Skor : " + menang + " menang " + kalah + " kalah " + seri + " seri ");
                Console.WriteLine("Tekan enter untuk melanjutkan permainan...");
                Console.ReadKey();
                Console.Clear();

            }


        }
    }
}
