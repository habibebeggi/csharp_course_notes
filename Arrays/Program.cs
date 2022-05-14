using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] Args)
        {
            //string student1 = "Engin";
            
            ////aynı tıptekı degrleı tek bır noktada yonetme ıhtıyacı
            //string[] students = new string[5];
            //students[0] = "Engin";
            //students[1] = "Ahmet";
            //students[2] = "Ayşe";
            //string[] students2 = new []{ "Engin", "Salih", "Ayşe", "Ahmet" };
            ////students2[4] array tasma hatası verır
            //string[] students3 = { "Engin", "Salih", "Ayşe", "Ahmet" };
            //// bu sekılde de tanımlanabılır

            ////foreach arrayı gezmek ıvın kull.
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine();
            //Console.ReadLine();
            ////cok boyutlu dızıler
            
           
            string[,] regions = new string[5,3]
            {
                {"İstanbul","İzmit","Bursa" },
                { "Ankara","Kırıkkale","Konya" },
                { "Antalya","Adana","Mersin" },
                { "Rize","Trabzon","Samsun" },
                { "İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //0.dimentionun en ust degerını verır
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("----");
            }
            Console.ReadLine();

        }
    }
}