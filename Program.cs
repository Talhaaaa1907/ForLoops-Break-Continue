using System;

namespace ForLoops_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("Bir sayı giriniz...");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Tek Sayılar: " + i);
                }
            }


            // 1 ile 1000 arasındaki tek ve çift sayıları toplama
            int ciftToplam = 0;
            int tekToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
                Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
                Console.WriteLine("Tek sayıların toplamı: " + tekToplam);


            // break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                    Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
