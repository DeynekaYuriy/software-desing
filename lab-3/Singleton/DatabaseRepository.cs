using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Singleton
{
    sealed public class DatabaseRepository
    {
        private static DatabaseRepository? _instance;
        private static object _lockRef = new object();

        private DatabaseRepository()
        {
            Console.WriteLine("Database Initializing!!!");
        }
        public static DatabaseRepository GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockRef)
                {
                    if (_instance == null)
                        _instance = new DatabaseRepository();
                }
            }
            return _instance;
        }

        public List<string> GetOrders()
        {
            return new List<string> { "Order #1", "Order #2", "Order #3" };
        }
    }
}
