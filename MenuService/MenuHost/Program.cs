using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MenuHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(MenuService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
