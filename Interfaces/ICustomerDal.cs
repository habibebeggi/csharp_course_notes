using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL SERVER ADDED!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL SERVER DELETEDED!");
        }

        public void Update()
        {
            Console.WriteLine("SQL SERVER UPDATED!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("ORACLE ADDED!");
        }

        public void Delete()
        {
            Console.WriteLine("ORACLE DELETED!");
        }

        public void Update()
        {
            Console.WriteLine("ORACLE UPDATED!");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            //bu kullanımda ne sqlserver var ne oracle. yanı yazılacak kod bunlardan bagımsız. 
        }
    }
}
