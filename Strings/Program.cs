using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "I work about C#";
            var result = sentence.Length;
            var result2 = sentence.Clone(); // ilgili string dgerin bir referansını daha olusturmaya yarar.

            string sentence2 = "I work about OOP";
            Console.WriteLine(result2); // ekrana ilk string dgerini yazar. Çunku result2.clone da referans olusturuldu
            //o result2 nin referansında ilk string var.

            bool res2 = sentence.StartsWith("i"); // bu string i ile başlıyor mu --> burada ide dili ingilizce olsa da
           // i ile I yı farklı karakter olarak kabul etti
            Console.WriteLine(res2);
            bool res3=sentence.EndsWith("s"); // bu string s ile bitiyor mu onu dondurur
            Console.WriteLine(res3);
            var result3 = sentence.IndexOf("about"); // work kacıncı karakterden baslıyor. Bunu arar. 2
            //bulamadıgında -1 doner
            var result4 = sentence.IndexOf(" "); // buldugu ılk boslugu alır-->1. karakterde
            var result5 = sentence.LastIndexOf(" "); //aramaya sondan baslar--> bastan 12.karakter bosluk.
            var res6 = sentence.Insert(0," Hello"); //bir stringe baska bir stringi yerleştirmek için kull.
            var res7 = sentence.Substring(5); //5.karakterden ıtıbaren al --> k about C# yazar
            var res8=sentence.Substring(2,5); //2. karakterden ıtıbaren 5 karakter al

            var res10 = sentence.ToLower(); //tumunu kucuk harf
            var res11 = sentence.ToUpper(); //tumunu buyuk harf yap
            var res12 = sentence.Replace(" ","-"); // belirtilen karakterleri değiştirmeyi sağlar.
            var res13 = sentence.Remove(2); //2.karakterden ıtıbaren gerısını at
            var res14=sentence.Remove(2,4);
            Console.WriteLine(res14); 
        }
        
        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var s in city)
            {
                Console.WriteLine(s);
            }
            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2)); //bellekte 3. bir değişken kullanmadan ekrana yadırdı
            //metinsel verileri tutmak için kullanılan değişken tipidir.
            //stringler aslında birer char dizisidir.
            // CWL de aslında formatı bir stringtir

        }
    }
}
