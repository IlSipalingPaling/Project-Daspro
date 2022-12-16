using System;

namespace SoalNo1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama :");
            String Nama = Console.ReadLine();
            Console.WriteLine("Nim :");
            String Nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            String Kons = Console.ReadLine();

            Console.WriteLine("|*************************|");
            Console.WriteLine("|Nama: {0,19}|", Nama);
            Console.WriteLine("|{0,25}|", Nim);
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("|{0,25}|", Kons);
            Console.WriteLine("|*************************|");
        }
    }
}
