using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mükemmel_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) {
                    toplam = toplam + i;
                    
                }
            }
            if (toplam == sayi)
                Console.WriteLine(sayi + " sayısı mükemmel sayıdır.");
            else
                Console.WriteLine(sayi + " sayısı mükemmel sayı değildir.");
            Console.ReadKey();
        }
    }
}
