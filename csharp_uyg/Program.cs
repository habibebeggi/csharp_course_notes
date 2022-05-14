namespace csharp_uyg
{
    class Program
    {
        static void Main(string[] Args)
        {
            int[] s1 = new int[] { 1, 2, 3 };
            int[] s2 = new int[] { 10, 20, 30 };

            s1 = s2;
            s2[0] = 1000;
            //Console.WriteLine("s1[0]" + s1[0]);

            person p=new person();
            person p2=new person();
            p.name = "Engin";

            p2 = p; //--> deger esitlemesi değila adres eitlemesi yapıldı.
            p.name = "Ayşe";

            customer c=new customer();
            c.name = "AA";
            c.CreditCardNumber = "254785288996";
            //Console.WriteLine(p2.name);

            //iki sınıf biribirine atanamaz. --> customer=employee; yapılamaz
            person p3=c; //--> bu atama yapılabılır. Miras aldıgından dolayı.--> customer bir persondur.employee bir persondur.
            //base class: person derived class: customer, employee. base classa onu inherite eden sınıfların referansını atayabiliriz.
            // boxing --kutulama 
            Console.WriteLine(((customer)p3).CreditCardNumber);
            // aynı sekılde persondan employee de kullanılabılır.
            employee e=new employee();
            e.name = "Veli";
            //
            //Console.WriteLine(p3.name);
            PersonManager pm=new PersonManager();
            pm.Add(c);     // --> Aynı kodu farklı nesneler için de çalıştırır.    
        /* class referans tiptedir. person base class olarak tanımlanmıstır. Buna baglı olarak
         da diğer derived classlardan çağırılan nesneler için de metot calısır. Çunku arka tarafta metota person parametre gecıldı. Bu person da kimin adresi varsa o gelir.
         
         */
        }

    }
    class person
    {
        public int id; 
        public string name; 
        public int sname; 
    }
    class customer:person
    {
        public string CreditCardNumber;
    }   
    class employee:person
    {
        public int employeeNumber;
    }
    class PersonManager
    {
       public void Add(person p)
        {
            Console.WriteLine(p.name);
        }

    }
}
