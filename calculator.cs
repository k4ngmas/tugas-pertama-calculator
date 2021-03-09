//NAMA  : Muhammad Abiyyu
//NIM   : 20.11.3346
//CLASS : 20S1-IF01


using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        kembali:
            Console.Clear();
            Console.WriteLine("Aplikasi Calculator");
            Console.WriteLine();
            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine("---------------------");
            Console.WriteLine("Input Nomer Menu:");

            int pilihan = Int32.Parse(Console.ReadLine());
            int a, b, c;
            int number = 1;

            if (pilihan == 1)
            {
                Console.Write("Input Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Hasil Penambahan = {0} + {1} = {2}", a, b, Penambahan(a, b));

                Console.ReadKey();
            }
            else if (pilihan == 2)
            {
                Console.Write("Input Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Hasil Pengurangan = {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilihan == 3)
            {
                Console.Write("Input Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Hasil Perkalian = {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (pilihan == 4)
            {
                Console.Write("Input Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Hasil Pembagian = {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf,Menu yang anda pilih tidak tersedia.");
            }
            Console.ReadKey();
            goto kembali;

            static int Penambahan(int a, int b)
            {
                return a + b;
            }

            static int Pengurangan(int a, int b)
            {
                return a - b;
            }

            static int Perkalian(int a, int b)
            {
                return a * b;
            }

            static int Pembagian(int a, int b)
            {
                return a / b;
            }
        }
    }
}