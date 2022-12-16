using System;

namespace SoalNo2
{
    class program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int angka = rng.Next(0, 100);
            bool tebakan = false;

            while (!tebakan)
            {
                Console.Write("Tebak angka antara 1-100 :");
                int jawaban = Convert.ToInt32(Console.ReadLine());

                if (jawaban == angka)
                {
                    Console.WriteLine("Anda benar!\nBye...");
                    break;
                }
                else if (jawaban > angka)
                {
                    Console.WriteLine("Salah. Nilai terlalu besar");
                }
                else if (jawaban < angka)
                {
                    Console.WriteLine("Salah. Nilai terlalu kecil");
                }
            }
        }
    }
}
