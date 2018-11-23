using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RastgeleHarflerdenKelime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*sesli harfleri bir stringe sessiz harfleri bir stringe aktararak bir sesli bir sessiz olmak üzere 5 harfli 5 kelime üret
            */



            Random rastgele = new Random();
            string sesliler = "aeıiuüoö";
            string sessizler = "qwrtypğsdfghjklşzxcvbnmç";
            string cumle = "";
            string kelime = "";
            int harfsayaci = 0;
            int kelimesayaci = 0;
            int index;


            kelimeolustur:
            //tekse sesli çiftse sessiz harf alalım?
            #region harf alınma bölümü
            if (harfsayaci % 2 == 0) // çift ise
            {
                index = rastgele.Next(0, sessizler.Length);
                kelime += sessizler[index];
            }
            else // tek ise
            {
                index = rastgele.Next(0, sesliler.Length);
                kelime += sesliler[index];
            }
            #endregion
            harfsayaci++;
            if (harfsayaci < 5) goto kelimeolustur;
            // 5 harflik kelime oluşturuldu
            cumle += kelime;
            cumle += " ";
            kelimesayaci++;
            if(kelimesayaci<5)
            {
                harfsayaci = 0;
                kelime = "";
                goto kelimeolustur;
            }
            //5 kelimelik cümle oluştur

            Console.WriteLine(cumle);
            Console.ReadKey();


        }
    }
}
