using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /// C # TA DONGULER
            ///  1- WHILE DONGUSU

            // kısayolu : while 2 tab
            // eğer şart sağlanıoyorsa döngüye girer

            //while (true)   // parantezx içinde yazılan şart sağlandıı müddetçe döngü tekrar eder
            { // dong. baslangic

                // komut1
                //komut 2
            }  // dong bitişi 

            // genellikle sayac vs. lazım olmadığı durumlarda kullanılır



            // isim ahmet girilene kadar isim sorulsun
            /*
            string isim = "";

            while (isim != "ahmet")
            {
                Console.Write("isim girin ");
                isim = Console.ReadLine();
            }
            //bu dongu isim ahmet girildiğinde sonlanacak 



            while (true)  // BAK 
            { }
            //YAP

            // 2 - DO WHİLE DONGUSU

            do          //YAP 
            {

            } while (true); // BAK

            // dongunun en az bir kere çalışması istenen durumlarda doo while kullanılır


            // ESCAPE E BASILANA KADAR HARF SOR ?
           
    *//*
    ConsoleKeyInfo tus;
            do
            {
                Console.WriteLine("bir tuş giriniz ");
                tus = Console.ReadKey();
            }
            while (tus.Key!=ConsoleKey.Escape);  // şart sağlanıyorsa DO bölümüne döner 

            // 3 - FOR DONGUSU
            // Genellikle  kez adet kere gibi fadeler olduğu durumlarda  ve ardışık sayılarla yapılan işlemlerde kullanılır 
            // ekrana 10 defa merhaba yaz

            for (int sayac = 0; sayac <10; sayac++)   // (sayac tanımla ve deger ver ; şart(sayac nereye kadar gşdecek? ) ; sayac kacar kacar artacak, azalacak)
            {
                Console.WriteLine("merhaba");
                // şart sağlandığı muddetce buradakı komutlar tekrar eder
            }

            // 4- Foreach Döngüsü

            // dizi  ve koleksiyon mantığıyla çalışan dizilerin içinde otomatik dolaşmayı sağlayan bir döngüdür
            string[] isimler = { "ali", "ayşe", "veli", "orhan" };
            //  isimler dizisinin kaç elemanlı olup kaç kez doneceğini vs otomatik belirler.     
            foreach (var ad in isimler)   // rastladığın her elemanı temsili ad ismini ver 
            {
                Console.WriteLine(ad);
            }



            /// NOT:



            for (int i = 0; i < 10; i++)
            {

            }

            for (int i = 10; i >0 ; i--)  // 10dan geriye 1 er 1 er
            {


            }

            for (int i = 10; i <0; i+=3)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >=-10; i-=3)
            {
                Console.WriteLine(i);
            }  */

            int sayi = 50;
            for (int i = sayi; i > 40; i -= 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0, y = 10; i <10 && y<20; i++,y+=3)
            {

            }


            // not: döngüler iç içe kullanılabilir


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine(i);
                }
            }


            while (true)
            {
                for (int i = 0; i < 3; i++)
                {

                }
            }


            for (int i = 0; i < 5; i++)
            {
                do
                {

                } while (true);

            }

            do
            {
            } while (true);

            // sonsuz döngü :

            while (true)   //sonsuz döngü
            {

            }

            for (;;)  // sonsuz döngü
            {

            }


            // break , continue 

            Console.ReadKey();
        }
    }
}
