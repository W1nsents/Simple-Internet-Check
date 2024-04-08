using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (Internet.OK())
            {
                Console.WriteLine("Connect");
            }
            else
            {
                Console.WriteLine("Сonnection lost");
            }

            Console.ReadKey();
        }
    }

    public class Internet
    {
        public static bool OK()
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    Dns.GetHostEntry("google.com");
                    return false;
                }
                catch
                {
                    return true;
                }
            }
        }
    }
}
