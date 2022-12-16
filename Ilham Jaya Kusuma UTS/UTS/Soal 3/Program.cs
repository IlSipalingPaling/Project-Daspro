using System;

namespace SoalNo3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Input jumlah peminjaman:");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            int denda = 0;
            int denda_awal = 10000;
            int denda_akhir = 20000;
            int denda_berkelanjutan = 30000;

            int jumlah_dendaAwal = 5;
            int jumlah_dendaAkhir = 20;

            int dendaAwal = jumlah_dendaAwal * denda_awal;
            int dendaAkhir = jumlah_dendaAkhir * denda_akhir;


            if (5 < jumlah && jumlah < 11)
            {
                jumlah -= 5;
                denda = jumlah * denda_awal;
                Console.WriteLine("Total denda: Rp." + denda);
            }
            else if (10 < jumlah && jumlah < 31)
            {
                jumlah -= 10;
                int Denda_Akhir = jumlah * denda_akhir;
                denda = Denda_Akhir + dendaAwal;
                Console.WriteLine("Total denda: Rp." + denda);
            }
            else if (jumlah > 30)
            {
                Console.WriteLine("Keanggotaan anda dibatalkan");
                jumlah -= 30;
                int dendaBerkelanjutan = jumlah * denda_berkelanjutan;
                denda = dendaBerkelanjutan + dendaAkhir + dendaAwal;
                Console.WriteLine("Total denda: Rp." + denda);
            }
        }
    }
}