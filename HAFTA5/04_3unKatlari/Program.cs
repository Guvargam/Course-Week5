using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3unKatlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 0 ile üretilen bir sayı arasındaki 3 e bölünen sayıları yazdır . max 100 üret

0.... 3 ün 0 katı
3....3 ün 1 katı
6.....3 ün 2 katı
*/

            Random rnd = new Random();
            int sinirsayi = rnd.Next(100);

            Console.WriteLine("üretilen: "+sinirsayi);
            for (int i = 0; i <=sinirsayi; i+=3)
            {
                Console.WriteLine($"{i}\t3'ün\t{i/3}\tkatı");
            }

            Console.WriteLine("-------------------------------");
            for (int i = 0; i <= sinirsayi; i++)
            {

                Console.WriteLine($"{i*3}\t3'ün\t{i}\tkatı");
            }

            // ÖDEV : ÇARPIM TABLOSUNU YAZ (10 a kadar )
            ///   1 x 1 =1 
            ///   1 x 2=2  

            Console.ReadKey();
        }
    }
}
