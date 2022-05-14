using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        //bir classı kullanabılmek ıcın onun bır ornegını olusturmak gereklıdır.
         //yapılmak ıstenen ıslmelerı gruplara ayırmak ve o gruplar uzerınden ıslemlerı yapmak ve rahatlıkla bu gruba ulasmak ıcın kull.
        CustomerManager customerManager=new CustomerManager();
        customerManager.Add();
        customerManager.Update();
        ProductManager productManager=new ProductManager();
         productManager.Add();
         productManager.Update();
        Customer customer=new Customer();
            customer.Id = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Demir";
            customer.City = "İstanbul";
            //classın propertysi = denildiginde set bloğu kullanılıyor. Çağırma/ okumada ise get blogu kullanılır.
            //
            Customer customer2 = new Customer
            { Id = 2, FirstName="Derin", LastName="Demiroğ", City="Sakarya"};
            Console.WriteLine(customer2.LastName);

        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}
