using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletondesignPattern.Model
{
    internal class DataServices
    {
        private static DataServices? instance;

        DataServices()
        {
            Console.WriteLine("DATA SERVICES IS CREATED ");

        }

        public void DoProcess()
        {
            Console.WriteLine("PROCESSING IS DONE"+GetHashCode());
        }

        public static DataServices GetInstance()
        {
            if (instance == null)
                instance = new DataServices();
            return
                instance;
        }
    }
}
