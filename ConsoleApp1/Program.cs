using Estudo_Cache_Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cache cache = new Cache();

            for (int i = 0; i < 10; i++)
            {
                cache.WriteRedisData(i + "\n");
            }

            cache.Clear();


            Console.WriteLine(cache.ReadRedisData());
        }
    }
}
