using System;

namespace Battle_Tank
{
    class program
    {
        /*

        Nama  : Ilham Jaya Kusuma
        Nim   : 2207112593
        Kelas : Teknik Informatika A

        */
        static void Main(string[] args)
        {
            //inisialisai variabel yang dibutuhkan
            int Panjang_area = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int Total_tank = 3;

            //Buat Array 2 Dimensi untuk menempatkan tank
            char[,] ruang = Buat_ruang(Panjang_area, rumput, tank, Total_tank);

            //print Array 2 Dimensi untuk ke console
            printRuangan(ruang, rumput, tank);

            //jumlah tank tersembunyi
            int jumlahTankTersembunyi = Total_tank;

            //gameplay
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakKoordinat = getKoordinatpemain(Panjang_area);
                char updateTampilRuang = verifikasiTebakanPemain(tebakKoordinat, ruang, tank, rumput, hit, miss);
                if (updateTampilRuang == hit)
                {
                    jumlahTankTersembunyi--;
                }
                ruang = updateRuangan(ruang, tebakKoordinat, updateTampilRuang);
                printRuangan(ruang, rumput, tank);
            }
            Console.WriteLine("GameOver!!!,\nTerimkasih dan sampai jumpa");
            Console.Read();

        }
        //Buat Array 2 Dimensi
        private static char[,] Buat_ruang(int Panjang_area, char rumput, char tank, int Total_tank)
        {
            char[,] ruangan = new char[Panjang_area, Panjang_area];
            for (int baris = 0; baris < Panjang_area; baris++)
            {
                for (int kolom = 0; kolom < Panjang_area; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return Letakkan_tank(ruangan, Total_tank, rumput, tank);
        }
        //Letakkan 3 tank di dalam array 2 dimensi
        private static char[,] Letakkan_tank(char[,] ruang, int Total_tank, char rumput, char tank)
        {
            int letak_tank = 0;
            int Panjang_area = 5;

            while (letak_tank < Total_tank)
            {
                int[] lokasi_tank = tentukanKoordinatTank(Panjang_area);
                char posisiZ = ruang[lokasi_tank[0], lokasi_tank[1]];

                if (posisiZ == rumput)
                {
                    ruang[lokasi_tank[0], lokasi_tank[1]] = tank;
                    letak_tank++;
                }
            }
            return ruang;
        }
        //menentukan posisi random koordinat tank dalam array 2 dimensi
        private static int[] tentukanKoordinatTank(int Panjang_area)
        {
            Random rng = new Random();
            int[] koordinat = new int[2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rng.Next(Panjang_area);

            }
            return koordinat;
        }
        //print array 2 dimensi ke console
        private static void printRuangan(char[,] ruang, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = ruang[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    }
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        //tebakan user
        private static int[] getKoordinatpemain(int Panjang_area)
        {
            int baris;
            int kolom;
            do
            {
                Console.Write("Pilih Baris = ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris < 0 || baris > Panjang_area);

            do
            {
                Console.Write("piliha kolom = ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom < 0 || kolom > Panjang_area);

            return new[] { baris - 1, kolom - 1 };

        }
        //cek validasi tebakan user (miss, hit, sudah hancur)
        private static char verifikasiTebakanPemain(int[] tebakKoordinat, char[,] ruang, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            char target = ruang[baris, kolom];

            if (target == tank)
            {
                pesan = "TEMBAKANMU TEPAT SASARAN!!!";
                target = hit;
            }
            else if (target == rumput)
            {
                pesan = "SAYANG SEKALI, TEMBAKANMU MELESET...";
                target = miss;
            }
            else
            {
                pesan = "AREA INI AMAN";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("  ");
            return target;
        }
        //update tampilan array 2 dimensi berdasarkan hasil tebakan user
        private static char[,] updateRuangan(char[,] ruang, int[] tebakKoordinat, char updateTampilRuang)
        {
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            ruang[baris, kolom] = updateTampilRuang;
            return ruang;
        }
    }
}
