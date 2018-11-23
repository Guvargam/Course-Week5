using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DonguOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ekrana Rastgele 0 - 50 arası 10 sayı yazdır
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(50);
                Console.WriteLine(sayi);

            }

            //Kullanıcıdan alınan sayıdan geriye doğru sayıları 1 er 1 er yazdır

            int girilensayi;

            while (true)
            {
                Console.Write("Sayı Girin : ");
                if (int.TryParse(Console.ReadLine(), out girilensayi))
                {
                    for (int i = girilensayi; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                }
            }


            /*Kullanıcının girdiği sayı ile iki katı arasındaki ÇİFT sayıları yazdırın **/

            int sayi2;
            Console.Write("Sayı Girin : ");
            if (int.TryParse (Console.ReadLine(),out sayi2))
            {
                // birinci yol
                for (int i = sayi2; i < sayi2*2; i++)
                {
                    if (i % 2 == 0) Console.WriteLine(i);
                }

                // ikinci yol
                if (sayi2 % 2 != 0) sayi2++;// eğer sayı çift değilse çift hale geldi              
                for (int i = sayi2; i <= sayi2*2; i+=2)
                {
                    Console.WriteLine(i);
                }
            }
                





            Console.Read();


        }
    }
}
