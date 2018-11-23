using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CumledenRastgeleHarfSec
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            
Kullanıcının girdiği bir cümle içinden rastgele harfler seçerek 5 harfli bir kelime oluştur 

Random 
String içindeki char a erişme
yeni string oluşturma? 

>>merhaba dünya naber?
ahbdn
-------*/

            Random rnd = new Random();
            cumleal:
            Console.Write("Bir Cümle Giriniz : ");
            string cumle = Console.ReadLine().Trim();
            string kelime = "";
            int sayac = 0;
            int harfindexi;
        uret:
            harfindexi = rnd.Next(cumle.Length);  // 0 ile kelimenin uzunluğu arası değer üret. 
            if (cumle[harfindexi] == ' ') goto uret;
            kelime += cumle[harfindexi];
            sayac++;
            if (sayac < 5) goto uret;
            Console.WriteLine("Yeni Kelime: "+kelime);
            goto cumleal;













        }
    }
}
