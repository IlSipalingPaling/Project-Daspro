using System;

namespace Daspro
{
    class Program
    {

        //Main Method
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            int KodeA;
            int KodeB;
            int KodeC;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            //Inisialisasi Variabel
            KodeA = 1;
            KodeB = 2;
            KodeC = 3;
            
            int Hasiltambah;
            int Hasilkali;
            int Jumlahkode;

            Hasilkali= KodeA*KodeB*KodeC;
            Hasiltambah= KodeA+KodeB+KodeC;
            Jumlahkode= 3;


            //Intro
            Console.WriteLine("Anda adalah seorang agen rahasia yang berugas mendapatkan data dari server rahasia");
            Console.WriteLine("Akses ke sever membutuhkan password yang tidak diketahui");
            Console.WriteLine("Password terdiri dari " +Jumlahkode+ " angka");
            System.Console.WriteLine("Jika ditambahkan hasilnya " +Hasiltambah);
            System.Console.WriteLine("Jika dikalikan hasilnya " +Hasilkali);

            System.Console.Write("Masukkan kode 1 : ");
            tebakanA =  Console.ReadLine();
            System.Console.Write("Masukkan kode 2 : ");
            tebakanB = Console.ReadLine();
            System.Console.Write("Masukkan kode 3 : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Jawabannnya " +tebakanA+tebakanB+tebakanC +" ?");

            //If Statement
            if(tebakanA == KodeA.ToString()&& tebakanC == KodeC.ToString()&& tebakanB == KodeB.ToString())
            {
              Console.WriteLine("Tebakan anda Benar!");
            }
            else
            {
              Console.WriteLine("Tebakan anda Salah!");
            }


            
        }

    }
}