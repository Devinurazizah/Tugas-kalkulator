using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Kalkulator
{
    class Program
    {
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan (int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int bil1, bil2;
            char pilihan;
            Console.WriteLine(" Pilih menu calculator :\n");
            Console.WriteLine("1.   Penambahan");
            Console.WriteLine("2.   Pengurangan");
            Console.WriteLine("3.   Perkalian");
            Console.WriteLine("4.   Pembagian\n");
            Console.Write("Masukan Pilihan [1..4] : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == '1')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua  : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write(" Hasil Penambahan : {0} + {1} = {2}", bil1, bil2, penambahan(bil1, bil2));
            }
            else if (pilihan == '2')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilang Kedua  : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pengurangan : {0} - {1} = {2}", bil1, bil2, pengurangan(bil1, bil2));
            }
            else if (pilihan == '3')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua  : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Perkalian : {0} * {1} = {2}", bil1, bil2, perkalian(bil1, bil2));
            }
            else if (pilihan == '4')
            {
                Console.Write("Masukan Bilangan Pertama  : ");
                bil1 = int.Parse(Console.ReadLine());

                Console.Write("Masukan Bilangan Kedua  : ");
                bil2 = int.Parse(Console.ReadLine());

                Console.Write("Hasil Pembagian : {0} / {1} = {2}", bil1, bil2, pembagian(bil1, bil2));
            }
            else
            {
                Console.WriteLine("Maaf, Pilihan Anda Tidak Tersedia Di Menu");
            }

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }
    }
}
