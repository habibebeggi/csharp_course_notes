using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Progrma
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();
            //bir interface asla new lenemez.--> instance' sı olusturulamaz. Ama su ssekılde kullanılabılrı.
            IPerson person = new Customer(); //bu sekılde olusturulabılır.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            //bu kullanımla metot farklı classlara uyarlanabılır. Gercek hayatta katmanalr arası gecıste yogun kullanılır.

        }
        private static void InterfaceIntro()
        {
            //isimlendirme standardı olarak ınterfaceler I ile baslar. 
            //en buyuk kullanım amacı bır temel operasyon/nesne olusturup butun nesneleri ondan impelemnte etmektir.
            //classlar somut nesneyken ınterfaceler soyut nesnedır. tek basına bır sey ıfade etmez.
            //customer da kısı student da. bu neddenle ıpersondan mıras alırsa ıpersonda tanımlanmıs her seyı customer ve student classlarında gorebılırız
            // ınterfaceler yazılırken tamamen metodun ımzası voidse void, donus degerı varsa donus degerı, ismi ve ozellıgı yazılır.
            // ınterface tanımladıysan tanımladıgın ozellıklerı mıras alan class ıcınde yazmak zorundasın.--> yenı versıyonda degısıklık olmus olabılır

            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Derin", LastName = "Deniz", Address = "Çankaya" });
            //Bu tanımlama su sekılde de yapılabılırdı.
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = " Derin",
            //    LastName = "Deniz",
            //    Address = "Çankaya"
            //};
            //personManager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Deniz",
                LastName = "Deren",
                Departmant = "CSE"

            };

            // asagıda add metoduna ınterface i parametre gec ctiği için bu kullanımı yapabıldık
            //eger temel nesne uzerınden gıdılecekse buna gore propları da ayarlamak gerekecektır. yanı temel proplar gelecek.
            //dıger propları kendın yaz. person.Departmant gibi
            personManager.Add(student);
            Console.ReadLine();
        }
        }
        
    interface IPerson
    { 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        //resharper olmadan boyle implemente edılır. ınterface de tanımlanan ozellık/metot her neyse mıras alan classlarda ımpelemte edılmek zorundadır
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get; set; } //ayrıca musteriye aıt bır ozellık de tanımlanabılır
    }

    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Departmant { get; set; } //ayrıca ogrencıye aıt bır ozellık de tanımlanabılır

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

