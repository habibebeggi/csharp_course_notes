using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();
            if (IsPrimeNumber(193))
            {
                Console.WriteLine("this is a priem num");
            }
            else
            {
                Console.WriteLine("this is not a prime num");
            }
            Console.Read();
        }
        private static bool IsPrimeNumber(int num)
        {
            bool result = true;
            for (int i = 2; i < num-1; i++)
            {
                if (num%i==0)
                {
                    result = false;
                    i = num;
                }
            }
            return result;
        }
        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("fınıshed");
            Console.ReadLine();

            //// tek sayıları yazdırmak ıstesetdı i+=2 yazılırdı.
            //// cıft ıcın de i=0 olmalıydı
            ////100 den geriye de i=100 yapıpı i-- olurdu.
            ///bu forun metot halidir. 
        }
        private static void WhileLoop()
        {
            int num = 100;
            while (num >= 0)
            {
                Console.WriteLine(num);
                num--; //bu da whilenın şarta mudahale etem kısmı. yanı burda tanımlanıyor.
            }
            Console.WriteLine("now num is {0}", num); // -1 yazar. nedeni de 0' dan sonra 1 daha azalttı
                                                      //sarta gitti -1<0 oldu ve while ın dısından devam etti
        }
        private static void DoWhileLoop()
        {
            int num = 10;
            do
            {
                Console.WriteLine(num);
                num--;
            } while (num >= 11);
            //while dan farkı ilk etapta do çalışır sonra while a bakar. şart sağlanmasa bile döngü satır satır
            //çalışacagından edo dongusu en az 1 kez çalısacaktır.
            //mutlaka yapılması gerekne bır sey varsa do while kullanılabilir.

        }
        private static void ForeachLoop()
        {
            string[] students = new string[] { "Engin", "Salih", "Derin" };
            foreach (var s in students)
            {
                Console.WriteLine(students);
            }
            //dizi temelli bir döngüdür. Dizinin tüm elemanlarını tek tek gezer.
            //Foreachle dondugun elemanları dongunun ıcınde degıstıremezsın.
            //Yani foreach içinde student="Ahmet; diyemezsin. Foreach daha cok veritabanından tablo cekıldıgınde verielri tek tek gezmek ıcın kull.
            //bunun dısında tamamen enumerable özelliğe sahiptir.--> üzerinde dolasılabılır nesnelere karsılık gelır

        }


    }

}
