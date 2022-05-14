namespace app1
{
    class Program
    {
        static void yaz(int a)
        {
            if (a > 10) return;
            yaz(a + 1);
            Console.WriteLine(a);
        }
       static void Main(string[]args)
        {
            yaz(0);
        }


    }
}
